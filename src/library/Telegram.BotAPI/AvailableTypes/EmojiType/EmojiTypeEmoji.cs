// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// A regular emoji.
/// </summary>
public class EmojiTypeEmoji : EmojiType
{
    /// <summary>
    /// Type of the emoji, always “emoji”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "emoji";

    /// <summary>
    /// The emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.Emoji)]
    public string Emoji { get; set; } = null!;
}
