// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a video file.
/// </summary>
public class Video
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
    /// Video width as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int Width { get; set; }

    /// <summary>
    /// Video height as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int Height { get; set; }

    /// <summary>
    /// Duration of the video in seconds as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Duration)]
    public int Duration { get; set; }

    /// <summary>
    /// Optional. Video thumbnail
    /// </summary>
    [JsonPropertyName(PropertyNames.Thumbnail)]
    public PhotoSize? Thumbnail { get; set; }

    /// <summary>
    /// Optional. Original filename as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.FileName)]
    public string? FileName { get; set; }

    /// <summary>
    /// Optional. MIME type of the file as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.MimeType)]
    public string? MimeType { get; set; }

    /// <summary>
    /// Optional. File size in bytes. It can be bigger than 2^31 and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this value.
    /// </summary>
    [JsonPropertyName(PropertyNames.FileSize)]
    public long? FileSize { get; set; }
}
