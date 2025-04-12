// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Transfers Telegram Stars from the business account balance to the bot's balance. Requires the <em>can_transfer_stars</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="starCount">Number of Telegram Stars to transfer; 1-10000</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool TransferBusinessAccountStars(this ITelegramBotClient client, string businessConnectionId, int starCount) =>
        client.TransferBusinessAccountStarsAsync(businessConnectionId, starCount).GetAwaiter().GetResult();

    /// <summary>
    /// Transfers Telegram Stars from the business account balance to the bot's balance. Requires the <em>can_transfer_stars</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="starCount">Number of Telegram Stars to transfer; 1-10000</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> TransferBusinessAccountStarsAsync(this ITelegramBotClient client, string businessConnectionId, int starCount, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.StarCount, starCount }
        };

        return client.CallMethodAsync<bool>(MethodNames.TransferBusinessAccountStars, args, cancellationToken);
    }
}
