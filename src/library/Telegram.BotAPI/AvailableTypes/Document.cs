// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a general file (as opposed to <a href="https://core.telegram.org/bots/api#photosize">photos</a>, <a href="https://core.telegram.org/bots/api#voice">voice messages</a> and <a href="https://core.telegram.org/bots/api#audio">audio files</a>).
/// </summary>
public class Document
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
    /// Optional. Document thumbnail as defined by the sender
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
