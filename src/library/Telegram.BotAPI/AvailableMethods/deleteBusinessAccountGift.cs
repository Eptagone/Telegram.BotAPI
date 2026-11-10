// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Deletes a regular gift owned by a managed business account without receiving Telegram Stars for it. Requires the <em>can_convert_gifts_to_stars</em> business bot right. The gift can be deleted only if it isn't limited (the field <em>total_count</em> of the <see cref="Gift"/> is omitted) and wasn't refunded. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be deleted</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteBusinessAccountGift(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId) =>
        client.DeleteBusinessAccountGiftAsync(businessConnectionId, ownedGiftId).GetAwaiter().GetResult();

    /// <summary>
    /// Deletes a regular gift owned by a managed business account without receiving Telegram Stars for it. Requires the <em>can_convert_gifts_to_stars</em> business bot right. The gift can be deleted only if it isn't limited (the field <em>total_count</em> of the <see cref="Gift"/> is omitted) and wasn't refunded. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be deleted</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteBusinessAccountGiftAsync(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.OwnedGiftId, ownedGiftId ?? throw new ArgumentNullException(nameof(ownedGiftId)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.DeleteBusinessAccountGift, args, cancellationToken);
    }
}
