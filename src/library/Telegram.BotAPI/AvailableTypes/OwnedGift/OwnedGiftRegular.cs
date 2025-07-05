// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a regular gift owned by a user or a chat.
/// </summary>
public class OwnedGiftRegular : OwnedGift
{
    /// <summary>
    /// Type of the gift, always “regular”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "regular";

    /// <summary>
    /// Information about the regular gift
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public Gift Gift { get; set; } = null!;

    /// <summary>
    /// Optional. Unique identifier of the gift for the bot; for gifts received on behalf of business accounts only
    /// </summary>
    [JsonPropertyName(PropertyNames.OwnedGiftId)]
    public override string? OwnedGiftId { get; set; }

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
    /// Optional. <em>True</em>, if the sender and gift text are shown only to the gift receiver; otherwise, everyone will be able to see them
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPrivate)]
    public bool? IsPrivate { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift can be upgraded to a unique gift; for gifts received on behalf of business accounts only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanBeUpgraded)]
    public bool? CanBeUpgraded { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the gift was refunded and isn't available anymore
    /// </summary>
    [JsonPropertyName(PropertyNames.WasRefunded)]
    public bool? WasRefunded { get; set; }

    /// <summary>
    /// Optional. Number of Telegram Stars that can be claimed by the receiver instead of the gift; omitted if the gift cannot be converted to Telegram Stars
    /// </summary>
    [JsonPropertyName(PropertyNames.ConvertStarCount)]
    public int? ConvertStarCount { get; set; }

    /// <summary>
    /// Optional. Number of Telegram Stars that were paid by the sender for the ability to upgrade the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.PrepaidUpgradeStarCount)]
    public int? PrepaidUpgradeStarCount { get; set; }
}
