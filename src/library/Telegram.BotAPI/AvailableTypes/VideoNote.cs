// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a <a href="https://telegram.org/blog/video-messages-and-telescope">video message</a> (available in Telegram apps as of <a href="https://telegram.org/blog/video-messages-and-telescope">v.4.0</a>).
/// </summary>
public class VideoNote
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
    /// Video width and height (diameter of the video message) as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Length)]
    public int Length { get; set; }

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
    /// Optional. File size in bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.FileSize)]
    public long? FileSize { get; set; }
}
