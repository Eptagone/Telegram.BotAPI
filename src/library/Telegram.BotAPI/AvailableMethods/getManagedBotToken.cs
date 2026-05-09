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
    /// Use this method to get the token of a managed bot. Returns the token as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of the managed bot whose token will be returned</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static string GetManagedBotToken(this ITelegramBotClient client, long userId) =>
        client.GetManagedBotTokenAsync(userId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the token of a managed bot. Returns the token as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of the managed bot whose token will be returned</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<string> GetManagedBotTokenAsync(
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
            MethodNames.GetManagedBotToken,
            args,
            cancellationToken
        );
    }
}
