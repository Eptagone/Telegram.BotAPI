// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents one special entity in a text message. For example, hashtags, usernames, URLs, etc.
/// </summary>
public class MessageEntity
{
    /// <summary>
    /// Type of the entity. Currently, can be “mention” (<code>@username</code>), “hashtag” (<code>#hashtag</code>), “cashtag” (<code>$USD</code>), “bot_command” (<code>/start@jobs_bot</code>), “url” (<code>https://telegram.org</code>), “email” (<code>do-not-reply@telegram.org</code>), “phone_number” (<code>+1-212-555-0123</code>), “bold” (<strong>bold text</strong>), “italic” (<em>italic text</em>), “underline” (underlined text), “strikethrough” (strikethrough text), “spoiler” (spoiler message), “blockquote” (block quotation), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users <a href="https://telegram.org/blog/edit#new-mentions">without usernames</a>), “custom_emoji” (for inline custom emoji stickers)
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Offset in <a href="https://core.telegram.org/api/entities#entity-length">UTF-16 code units</a> to the start of the entity
    /// </summary>
    [JsonPropertyName(PropertyNames.Offset)]
    public int Offset { get; set; }

    /// <summary>
    /// Length of the entity in <a href="https://core.telegram.org/api/entities#entity-length">UTF-16 code units</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Length)]
    public int Length { get; set; }

    /// <summary>
    /// <em>Optional</em>. For “text_link” only, URL that will be opened after user taps on the text
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// <em>Optional</em>. For “text_mention” only, the mentioned user
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User? User { get; set; }

    /// <summary>
    /// <em>Optional</em>. For “pre” only, the programming language of the entity text
    /// </summary>
    [JsonPropertyName(PropertyNames.Language)]
    public string? Language { get; set; }

    /// <summary>
    /// <em>Optional</em>. For “custom_emoji” only, unique identifier of the custom emoji. Use <a href="https://core.telegram.org/bots/api#getcustomemojistickers">getCustomEmojiStickers</a> to get full information about the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiId)]
    public string? CustomEmojiId { get; set; }
}
