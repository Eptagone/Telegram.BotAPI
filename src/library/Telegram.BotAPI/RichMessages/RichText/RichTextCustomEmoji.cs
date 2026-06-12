// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.RichMessages;

/// <summary>
/// A custom emoji.
/// </summary>
public class RichTextCustomEmoji : RichText
{
    /// <summary>
    /// Type of the rich text, always “custom_emoji”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "custom_emoji";

    /// <summary>
    /// Unique identifier of the custom emoji. Use <a href="https://core.telegram.org/bots/api#getcustomemojistickers">getCustomEmojiStickers</a> to get full information about the sticker.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiId)]
    public string CustomEmojiId { get; set; } = null!;

    /// <summary>
    /// Alternative emoji for the custom emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.AlternativeText)]
    public string AlternativeText { get; set; } = null!;
}
