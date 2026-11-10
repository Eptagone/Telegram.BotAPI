// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// A custom emoji.
/// </summary>
public class EmojiTypeCustomEmoji : EmojiType
{
    /// <summary>
    /// Type of the emoji, always “custom_emoji”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "custom_emoji";

    /// <summary>
    /// Identifier of the custom emoji. Use <a href="https://core.telegram.org/bots/api#getcustomemojistickers">getCustomEmojiStickers</a> to get full information about the sticker.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiId)]
    public string CustomEmojiId { get; set; } = null!;
}
