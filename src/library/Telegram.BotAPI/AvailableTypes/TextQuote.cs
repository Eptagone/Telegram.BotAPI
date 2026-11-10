// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the quoted part of a message that is replied to by the given message.
/// </summary>
public class TextQuote
{
    /// <summary>
    /// Text of the quoted part of a message that is replied to by the given message; may be empty if the quote was chosen from a rich message
    /// </summary>
    [JsonPropertyName(PropertyNames.Text)]
    public string Text { get; set; } = null!;

    /// <summary>
    /// Optional. Special entities that appear in the quote. Currently, only <em>bold</em>, <em>italic</em>, <em>underline</em>, <em>strikethrough</em>, <em>spoiler</em>, <em>custom_emoji</em>, and <em>date_time</em> entities are kept in quotes.
    /// </summary>
    [JsonPropertyName(PropertyNames.Entities)]
    public IEnumerable<MessageEntity>? Entities { get; set; }

    /// <summary>
    /// Optional. Rich text of the quote if it was chosen from a <a href="https://core.telegram.org/bots/api#richmessage">rich message</a>. May contain only plain text, <see cref="RichTextBold"/>, <see cref="RichTextItalic"/>, <see cref="RichTextUnderline"/>, <see cref="RichTextStrikethrough"/>, <see cref="RichTextSpoiler"/>, <see cref="RichTextSubscript"/>, <see cref="RichTextSuperscript"/>, <see cref="RichTextDateTime"/>, <see cref="RichTextCustomEmoji"/>, <see cref="RichTextMathematicalExpression"/>, and arrays of them.
    /// </summary>
    [JsonPropertyName(PropertyNames.RichTexts)]
    public IEnumerable<RichText>? RichTexts { get; set; }

    /// <summary>
    /// Approximate quote position in the original message in UTF-16 code units as specified by the sender. For quotes from rich messages, it is the position in the text formed by joining plain texts of all quotable texts of the message, separated by line feeds.
    /// </summary>
    [JsonPropertyName(PropertyNames.Position)]
    public int Position { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the quote was chosen manually by the message sender. Otherwise, the quote was added automatically by the server.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsManual)]
    public bool? IsManual { get; set; }
}
