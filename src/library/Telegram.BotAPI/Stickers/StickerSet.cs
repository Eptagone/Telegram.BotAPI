// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// This object represents a sticker set.
/// </summary>
public class StickerSet
{
    /// <summary>
    /// Sticker set name
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string Name { get; set; } = null!;

    /// <summary>
    /// Sticker set title
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Type of stickers in the set, currently one of “regular”, “mask”, “custom_emoji”
    /// </summary>
    [JsonPropertyName(PropertyNames.StickerType)]
    public string StickerType { get; set; } = null!;

    /// <summary>
    /// List of all set stickers
    /// </summary>
    [JsonPropertyName(PropertyNames.Stickers)]
    public IEnumerable<Sticker> Stickers { get; set; } = null!;

    /// <summary>
    /// Optional. Sticker set thumbnail in the .WEBP, .TGS, or .WEBM format
    /// </summary>
    [JsonPropertyName(PropertyNames.Thumbnail)]
    public PhotoSize? Thumbnail { get; set; }
}
