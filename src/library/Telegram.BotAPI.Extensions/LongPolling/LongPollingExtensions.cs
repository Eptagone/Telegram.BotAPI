// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.Extensions.LongPolling;

public static class LongPollingExtensions
{
    /// <summary>
    /// Starts a long polling session using the current bot client.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="updateHandler">A function to handle incoming updates.</param>
    /// <param name="errorHandler">A function to handle errors.</param>
    /// <param name="options">Optional. Options for the long polling session.</param>
    /// <param name="cancellationToken">Optional. The cancellation token to cancel operation.</param>
    /// <returns></returns>
    public static async Task StartLongPolling(
        this ITelegramBotClient client,
        Func<ITelegramBotClient, Update, CancellationToken, Task> updateHandler,
        Func<ITelegramBotClient, Exception, CancellationToken, Task> errorHandler,
        LongPollingOptions? options = null,
        CancellationToken cancellationToken = default
    )
    {
        if (options?.DropPendingUpdates is true)
        {
            await client.DeleteWebhookAsync(true, cancellationToken).ConfigureAwait(false);
        }

        var args = new GetUpdatesArgs()
        {
            Limit = options?.Limit,
            Timeout = options?.Timeout,
            AllowedUpdates = options?.AllowedUpdates,
        };

        var tasks = new List<Task>();
        var semaphore = new SemaphoreSlim(options?.ParallelLimit ?? 1);

        while (!cancellationToken.IsCancellationRequested)
        {
            try
            {
                var updates = await client
                    .GetUpdatesAsync(args, cancellationToken)
                    .ConfigureAwait(false);
                if (updates.Any())
                {
                    args.Offset = updates.Last().UpdateId + 1;
                    foreach (var update in updates)
                    {
                        await semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
                        tasks.Add(
                            updateHandler(client, update, cancellationToken)
                                .ContinueWith(
                                    task =>
                                    {
                                        if (task.IsFaulted)
                                        {
                                            return errorHandler(
                                                    client,
                                                    task.Exception.InnerException,
                                                    cancellationToken
                                                )
                                                .ContinueWith(_ => semaphore.Release());
                                        }
                                        return Task.FromResult(semaphore.Release());
                                    },
                                    cancellationToken
                                )
                        );
                    }
                }
                else
                {
                    await Task.Delay(200, cancellationToken).ConfigureAwait(false);
                }
            }
            catch (Exception error)
            {
                await errorHandler(client, error, cancellationToken).ConfigureAwait(false);
            }

            await Task.WhenAll(tasks).ConfigureAwait(false);
            tasks.Clear();
        }

        await Task.WhenAll(tasks).ConfigureAwait(false);
    }
}
