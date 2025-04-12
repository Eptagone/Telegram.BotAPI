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
    /// Upgrades a given regular gift to a unique gift. Requires the <em>can_transfer_and_upgrade_gifts</em> business bot right. Additionally requires the <em>can_transfer_stars</em> business bot right if the upgrade is paid. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be upgraded to a unique one</param>
    /// <param name="keepOriginalDetails">Pass True to keep the original gift text, sender and receiver in the upgraded gift</param>
    /// <param name="starCount">The amount of Telegram Stars that will be paid for the upgrade from the business account balance. If <em>gift.prepaid_upgrade_star_count &gt; 0</em>, then pass 0, otherwise, the <em>can_transfer_stars</em> business bot right is required and <em>gift.upgrade_star_count</em> must be passed.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool UpgradeGift(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId, bool? keepOriginalDetails = null, int? starCount = null) =>
        client.UpgradeGiftAsync(businessConnectionId, ownedGiftId, keepOriginalDetails, starCount).GetAwaiter().GetResult();

    /// <summary>
    /// Upgrades a given regular gift to a unique gift. Requires the <em>can_transfer_and_upgrade_gifts</em> business bot right. Additionally requires the <em>can_transfer_stars</em> business bot right if the upgrade is paid. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be upgraded to a unique one</param>
    /// <param name="keepOriginalDetails">Pass True to keep the original gift text, sender and receiver in the upgraded gift</param>
    /// <param name="starCount">The amount of Telegram Stars that will be paid for the upgrade from the business account balance. If <em>gift.prepaid_upgrade_star_count &gt; 0</em>, then pass 0, otherwise, the <em>can_transfer_stars</em> business bot right is required and <em>gift.upgrade_star_count</em> must be passed.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> UpgradeGiftAsync(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId, bool? keepOriginalDetails = null, int? starCount = null, CancellationToken cancellationToken = default)
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
        if (keepOriginalDetails is not null)
        {
            args.Add(PropertyNames.KeepOriginalDetails, keepOriginalDetails);
        }
        if (starCount is not null)
        {
            args.Add(PropertyNames.StarCount, starCount);
        }

        return client.CallMethodAsync<bool>(MethodNames.UpgradeGift, args, cancellationToken);
    }
}
