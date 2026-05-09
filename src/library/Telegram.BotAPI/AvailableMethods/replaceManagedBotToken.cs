// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to revoke the current token of a managed bot and generate a new one. Returns the new token as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of the managed bot whose token will be replaced</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static string ReplaceManagedBotToken(this ITelegramBotClient client, long userId) =>
        client.ReplaceManagedBotTokenAsync(userId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to revoke the current token of a managed bot and generate a new one. Returns the new token as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of the managed bot whose token will be replaced</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<string> ReplaceManagedBotTokenAsync(
        this ITelegramBotClient client,
        long userId,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>() { { PropertyNames.UserId, userId } };

        return client.CallMethodAsync<string>(
            MethodNames.ReplaceManagedBotToken,
            args,
            cancellationToken
        );
    }
}
