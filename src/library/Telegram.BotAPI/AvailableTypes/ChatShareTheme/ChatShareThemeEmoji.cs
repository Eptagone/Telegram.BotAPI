// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The theme with emoji placed on a background.
/// </summary>
public class ChatShareThemeEmoji : ChatShareTheme
{
    /// <summary>
    /// Type of the theme, always “emoji”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "emoji";

    /// <summary>
    /// The emoji; 0-6 regular or custom emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.Emojis)]
    public IEnumerable<EmojiType> Emojis { get; set; } = null!;

    /// <summary>
    /// Optional. Identifier of the backdrop used as the background; omitted if the default background is used. Use <a href="https://core.telegram.org/bots/api#getchatsharethemebackdrops">getChatShareThemeBackdrops</a> to get details about the backdrop.
    /// </summary>
    [JsonPropertyName(PropertyNames.BackgroundBackdropId)]
    public int? BackgroundBackdropId { get; set; }
}
