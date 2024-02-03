// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.GettingUpdates;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class GettingUpdatesExtensions
{
    /// <summary>
    /// Use this method to remove webhook integration if you decide to switch back to <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="dropPendingUpdates">Pass <em>True</em> to drop all pending updates</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteWebhook(this ITelegramBotClient client, bool? dropPendingUpdates = null) =>
        client.DeleteWebhookAsync(dropPendingUpdates).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to remove webhook integration if you decide to switch back to <a href="https://core.telegram.org/bots/api#getupdates">getUpdates</a>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="dropPendingUpdates">Pass <em>True</em> to drop all pending updates</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteWebhookAsync(this ITelegramBotClient client, bool? dropPendingUpdates = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (dropPendingUpdates is not null)
        {
            args.Add(PropertyNames.DropPendingUpdates, dropPendingUpdates);
        }

        return client.CallMethodAsync<bool>(MethodNames.DeleteWebhook, args, cancellationToken);
    }
}
