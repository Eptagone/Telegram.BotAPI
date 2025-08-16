// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class PaymentsExtensions
{
    /// <summary>
    /// A method to get the current Telegram Stars balance of the bot. Requires no parameters. On success, returns a <see cref="StarAmount"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static StarAmount GetMyStarBalance(this ITelegramBotClient client) =>
        client.GetMyStarBalanceAsync().GetAwaiter().GetResult();

    /// <summary>
    /// A method to get the current Telegram Stars balance of the bot. Requires no parameters. On success, returns a <see cref="StarAmount"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<StarAmount> GetMyStarBalanceAsync(this ITelegramBotClient client, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<StarAmount>(MethodNames.GetMyStarBalance, cancellationToken: cancellationToken);
    }
}
