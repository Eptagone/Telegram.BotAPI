// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a video file of a specific quality.
/// </summary>
public class VideoQuality
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
    /// Video width
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int Width { get; set; }

    /// <summary>
    /// Video height
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int Height { get; set; }

    /// <summary>
    /// Codec that was used to encode the video, for example, “h264”, “h265”, or “av01”
    /// </summary>
    [JsonPropertyName(PropertyNames.Codec)]
    public string Codec { get; set; } = null!;

    /// <summary>
    /// Optional. File size in bytes. It can be bigger than 2^31 and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this value.
    /// </summary>
    [JsonPropertyName(PropertyNames.FileSize)]
    public long? FileSize { get; set; }
}
