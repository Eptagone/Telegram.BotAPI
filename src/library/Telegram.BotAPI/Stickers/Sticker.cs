// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers;

/// <summary>
/// This object represents a sticker.
/// </summary>
public class Sticker
{
    /// <summary>
    /// Identifier for this file, which can be used to download or reuse the file
    /// </summary>
    [JsonPropertyName(PropertyNames.FileId)]
    public string FileId { get; set; } = null!;

    /// <summary>
    /// Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
    /// </summary>
    [JsonPropertyName(PropertyNames.FileUniqueId)]
    public string FileUniqueId { get; set; } = null!;

    /// <summary>
    /// Type of the sticker, currently one of “regular”, “mask”, “custom_emoji”. The type of the sticker is independent from its format, which is determined by the fields <em>is_animated</em> and <em>is_video</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public string Type { get; set; } = null!;

    /// <summary>
    /// Sticker width
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int Width { get; set; }

    /// <summary>
    /// Sticker height
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int Height { get; set; }

    /// <summary>
    /// <em>True</em>, if the sticker is <a href="https://telegram.org/blog/animated-stickers">animated</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnimated)]
    public bool IsAnimated { get; set; }

    /// <summary>
    /// <em>True</em>, if the sticker is a <a href="https://telegram.org/blog/video-stickers-better-reactions">video sticker</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.IsVideo)]
    public bool IsVideo { get; set; }

    /// <summary>
    /// Optional. Sticker thumbnail in the .WEBP or .JPG format
    /// </summary>
    [JsonPropertyName(PropertyNames.Thumbnail)]
    public PhotoSize? Thumbnail { get; set; }

    /// <summary>
    /// Optional. Emoji associated with the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.Emoji)]
    public string? Emoji { get; set; }

    /// <summary>
    /// Optional. Name of the sticker set to which the sticker belongs
    /// </summary>
    [JsonPropertyName(PropertyNames.SetName)]
    public string? SetName { get; set; }

    /// <summary>
    /// Optional. For premium regular stickers, premium animation for the sticker
    /// </summary>
    [JsonPropertyName(PropertyNames.PremiumAnimation)]
    public File? PremiumAnimation { get; set; }

    /// <summary>
    /// Optional. For mask stickers, the position where the mask should be placed
    /// </summary>
    [JsonPropertyName(PropertyNames.MaskPosition)]
    public MaskPosition? MaskPosition { get; set; }

    /// <summary>
    /// Optional. For custom emoji stickers, unique identifier of the custom emoji
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiId)]
    public string? CustomEmojiId { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the sticker must be repainted to a text color in messages, the color of the Telegram Premium badge in emoji status, white color on chat photos, or another appropriate color in other places
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedsRepainting)]
    public bool? NeedsRepainting { get; set; }

    /// <summary>
    /// Optional. File size in bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.FileSize)]
    public long? FileSize { get; set; }
}
