// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// This object represents a rich formatted text. Currently, it can be either a String for plain text, an Array of <see cref="RichText"/>, or any of the following types:
/// <list type="bullet">
/// <item><description><see cref="RichTextBold"/></description></item>
/// <item><description><see cref="RichTextItalic"/></description></item>
/// <item><description><see cref="RichTextUnderline"/></description></item>
/// <item><description><see cref="RichTextStrikethrough"/></description></item>
/// <item><description><see cref="RichTextSpoiler"/></description></item>
/// <item><description><see cref="RichTextDateTime"/></description></item>
/// <item><description><see cref="RichTextTextMention"/></description></item>
/// <item><description><see cref="RichTextSubscript"/></description></item>
/// <item><description><see cref="RichTextSuperscript"/></description></item>
/// <item><description><see cref="RichTextMarked"/></description></item>
/// <item><description><see cref="RichTextCode"/></description></item>
/// <item><description><see cref="RichTextCustomEmoji"/></description></item>
/// <item><description><see cref="RichTextMathematicalExpression"/></description></item>
/// <item><description><see cref="RichTextUrl"/></description></item>
/// <item><description><see cref="RichTextEmailAddress"/></description></item>
/// <item><description><see cref="RichTextPhoneNumber"/></description></item>
/// <item><description><see cref="RichTextBankCardNumber"/></description></item>
/// <item><description><see cref="RichTextMention"/></description></item>
/// <item><description><see cref="RichTextHashtag"/></description></item>
/// <item><description><see cref="RichTextCashtag"/></description></item>
/// <item><description><see cref="RichTextBotCommand"/></description></item>
/// <item><description><see cref="RichTextAnchor"/></description></item>
/// <item><description><see cref="RichTextAnchorLink"/></description></item>
/// <item><description><see cref="RichTextReference"/></description></item>
/// <item><description><see cref="RichTextReferenceLink"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(RichTextConverter))]
public abstract class RichText
{
    /// <summary>
    /// Type of the rich text
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
