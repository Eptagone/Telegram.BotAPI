// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "GiftPremiumSubscription" method.
/// </summary>
public class GiftPremiumSubscriptionArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GiftPremiumSubscriptionArgs"/> class.
    /// </summary>
    /// <param name="userId">Unique identifier of the target user who will receive a Telegram Premium subscription</param>
    /// <param name="monthCount">Number of months the Telegram Premium subscription will be active for the user; must be one of 3, 6, or 12</param>
    /// <param name="starCount">Number of Telegram Stars to pay for the Telegram Premium subscription; must be 1000 for 3 months, 1500 for 6 months, and 2500 for 12 months</param>
    public GiftPremiumSubscriptionArgs(long userId, int monthCount, int starCount)
    {
        this.UserId = userId;
        this.MonthCount = monthCount;
        this.StarCount = starCount;
    }

    /// <summary>
    /// Unique identifier of the target user who will receive a Telegram Premium subscription
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Number of months the Telegram Premium subscription will be active for the user; must be one of 3, 6, or 12
    /// </summary>
    [JsonPropertyName(PropertyNames.MonthCount)]
    public int MonthCount { get; set; }

    /// <summary>
    /// Number of Telegram Stars to pay for the Telegram Premium subscription; must be 1000 for 3 months, 1500 for 6 months, and 2500 for 12 months
    /// </summary>
    [JsonPropertyName(PropertyNames.StarCount)]
    public int StarCount { get; set; }

    /// <summary>
    /// Text that will be shown along with the service message about the subscription; 0-128 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string? Text { get; set; }

    /// <summary>
    /// Mode for parsing entities in the text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.
    /// </summary>
    [JsonPropertyName(PropertyNames.TextParseMode)]
    public string? TextParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the gift text. It can be specified instead of <em>text_parse_mode</em>. Entities other than “bold”, “italic”, “underline”, “strikethrough”, “spoiler”, and “custom_emoji” are ignored.
    /// </summary>
    [JsonPropertyName(PropertyNames.TextEntities)]
    public IEnumerable<MessageEntity>? TextEntities { get; set; }
}
