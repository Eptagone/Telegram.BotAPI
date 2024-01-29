// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes reply parameters for the message that is being sent.
/// </summary>
public class ReplyParameters
{
    /// <summary>
    /// Identifier of the message that will be replied to in the current chat, or in the chat <em>chat_id</em> if it is specified
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// <em>Optional</em>. If the message to be replied to is from a different chat, unique identifier for the chat or username of the channel (in the format <code>@channelusername</code>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object? ChatId { get; set; }

    /// <summary>
    /// <em>Optional</em>. Pass <em>True</em> if the message should be sent even if the specified message to be replied to is not found; can be used only for replies in the same chat and forum topic.
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowSendingWithoutReply)]
    public bool? AllowSendingWithoutReply { get; set; }

    /// <summary>
    /// <em>Optional</em>. Quoted part of the message to be replied to; 0-1024 characters after entities parsing. The quote must be an exact substring of the message to be replied to, including <em>bold</em>, <em>italic</em>, <em>underline</em>, <em>strikethrough</em>, <em>spoiler</em>, and <em>custom_emoji</em> entities. The message will fail to send if the quote isn't found in the original message.
    /// </summary>
    [JsonPropertyName(PropertyNames.Quote)]
    public string? Quote { get; set; }

    /// <summary>
    /// <em>Optional</em>. Mode for parsing entities in the quote. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.QuoteParseMode)]
    public string? QuoteParseMode { get; set; }

    /// <summary>
    /// <em>Optional</em>. A JSON-serialized list of special entities that appear in the quote. It can be specified instead of <em>quote_parse_mode</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.QuoteEntities)]
    public IEnumerable<MessageEntity>? QuoteEntities { get; set; }

    /// <summary>
    /// <em>Optional</em>. Position of the quote in the original message in UTF-16 code units
    /// </summary>
    [JsonPropertyName(PropertyNames.QuotePosition)]
    public int? QuotePosition { get; set; }
}
