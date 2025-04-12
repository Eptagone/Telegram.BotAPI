// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a regular gift that was sent or received.
/// </summary>
public class GiftInfo
{
    /// <summary>
    /// Information about the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public Gift Gift { get; set; } = null!;

    /// <summary>
    /// Optional. Unique identifier of the received gift for the bot; only present for gifts received on behalf of business accounts
    /// </summary>
    [JsonPropertyName(PropertyNames.OwnedGiftId)]
    public string? OwnedGiftId { get; set; }

    /// <summary>
    /// Optional. Number of Telegram Stars that can be claimed by the receiver by converting the gift; omitted if conversion to Telegram Stars is impossible
    /// </summary>
    [JsonPropertyName(PropertyNames.ConvertStarCount)]
    public int? ConvertStarCount { get; set; }

    /// <summary>
    /// Optional. Number of Telegram Stars that were prepaid by the sender for the ability to upgrade the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.PrepaidUpgradeStarCount)]
    public int? PrepaidUpgradeStarCount { get; set; }

    /// <summary>
    /// Optional. True, if the gift can be upgraded to a unique gift
    /// </summary>
    [JsonPropertyName(PropertyNames.CanBeUpgraded)]
    public bool? CanBeUpgraded { get; set; }

    /// <summary>
    /// Optional. Text of the message that was added to the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// Optional. Special entities that appear in the text
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// Optional. True, if the sender and gift text are shown only to the gift receiver; otherwise, everyone will be able to see them
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPrivate)]
    public bool? IsPrivate { get; set; }
}
