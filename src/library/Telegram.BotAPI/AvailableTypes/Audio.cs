// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an audio file to be treated as music by the Telegram clients.
/// </summary>
public class Audio
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
    /// Duration of the audio in seconds as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Duration)]
    public int Duration { get; set; }

    /// <summary>
    /// Optional. Performer of the audio as defined by the sender or by audio tags
    /// </summary>
    [JsonPropertyName(PropertyNames.Performer)]
    public string? Performer { get; set; }

    /// <summary>
    /// Optional. Title of the audio as defined by the sender or by audio tags
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string? Title { get; set; }

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

    /// <summary>
    /// Optional. Thumbnail of the album cover to which the music file belongs
    /// </summary>
    [JsonPropertyName(PropertyNames.Thumbnail)]
    public PhotoSize? Thumbnail { get; set; }
}
