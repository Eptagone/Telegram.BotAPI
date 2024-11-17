// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// Represents the arguments of the "SendGift" method.
/// </summary>
public class SendGiftArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendGiftArgs"/> class.
    /// </summary>
    /// <param name="userId">Unique identifier of the target user that will receive the gift</param>
    /// <param name="giftId">Identifier of the gift</param>
    public SendGiftArgs(long userId, string giftId)
    {
        this.UserId = userId;
        this.GiftId = giftId ?? throw new ArgumentNullException(nameof(giftId));
    }

    /// <summary>
    /// Unique identifier of the target user that will receive the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Identifier of the gift
    /// </summary>
    [JsonPropertyName(PropertyNames.GiftId)]
    public string GiftId { get; set; }

    /// <summary>
    /// Text that will be shown along with the gift; 0-255 characters
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
