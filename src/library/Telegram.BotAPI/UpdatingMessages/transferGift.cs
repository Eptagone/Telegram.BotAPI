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
    /// Transfers an owned unique gift to another user. Requires the <em>can_transfer_and_upgrade_gifts</em> business bot right. Requires <em>can_transfer_stars</em> business bot right if the transfer is paid. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be transferred</param>
    /// <param name="newOwnerChatId">Unique identifier of the chat which will own the gift. The chat must be active in the last 24 hours.</param>
    /// <param name="starCount">The amount of Telegram Stars that will be paid for the transfer from the business account balance. If positive, then the <em>can_transfer_stars</em> business bot right is required.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool TransferGift(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId, long newOwnerChatId, int? starCount = null) =>
        client.TransferGiftAsync(businessConnectionId, ownedGiftId, newOwnerChatId, starCount).GetAwaiter().GetResult();

    /// <summary>
    /// Transfers an owned unique gift to another user. Requires the <em>can_transfer_and_upgrade_gifts</em> business bot right. Requires <em>can_transfer_stars</em> business bot right if the transfer is paid. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be transferred</param>
    /// <param name="newOwnerChatId">Unique identifier of the chat which will own the gift. The chat must be active in the last 24 hours.</param>
    /// <param name="starCount">The amount of Telegram Stars that will be paid for the transfer from the business account balance. If positive, then the <em>can_transfer_stars</em> business bot right is required.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> TransferGiftAsync(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId, long newOwnerChatId, int? starCount = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.OwnedGiftId, ownedGiftId ?? throw new ArgumentNullException(nameof(ownedGiftId)) },
            { PropertyNames.NewOwnerChatId, newOwnerChatId }
        };
        if (starCount is not null)
        {
            args.Add(PropertyNames.StarCount, starCount);
        }

        return client.CallMethodAsync<bool>(MethodNames.TransferGift, args, cancellationToken);
    }
}
