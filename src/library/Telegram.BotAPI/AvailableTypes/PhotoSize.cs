// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents one size of a photo or a <a href="https://core.telegram.org/bots/api#document">file</a> / <a href="https://core.telegram.org/bots/api#sticker">sticker</a> thumbnail.
/// </summary>
public class PhotoSize
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
    /// Photo width
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int Width { get; set; }

    /// <summary>
    /// Photo height
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int Height { get; set; }

    /// <summary>
    /// Optional. File size in bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.FileSize)]
    public long? FileSize { get; set; }
}
