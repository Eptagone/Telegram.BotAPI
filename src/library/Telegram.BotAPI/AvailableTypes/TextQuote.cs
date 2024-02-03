// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the quoted part of a message that is replied to by the given message.
/// </summary>
public class TextQuote
{
    /// <summary>
    /// Text of the quoted part of a message that is replied to by the given message
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the quote. Currently, only <em>bold</em>, <em>italic</em>, <em>underline</em>, <em>strikethrough</em>, <em>spoiler</em>, and <em>custom_emoji</em> entities are kept in quotes.
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// Approximate quote position in the original message in UTF-16 code units as specified by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Position)]
    public int Position { get; set; }

    /// <summary>
    /// Optional. True, if the quote was chosen manually by the message sender. Otherwise, the quote was added automatically by the server.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsManual)]
    public bool? IsManual { get; set; }
}
