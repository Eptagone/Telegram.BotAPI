// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.TelegramPassport;

/// <summary>
/// This object represents a file uploaded to Telegram Passport. Currently all Telegram Passport files are in JPEG format when decrypted and don't exceed 10MB.
/// </summary>
public class PassportFile
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
    /// File size in bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.FileSize)]
    public long FileSize { get; set; }

    /// <summary>
    /// Unix time when the file was uploaded
    /// </summary>
    [JsonPropertyName(PropertyNames.FileDate)]
    public int FileDate { get; set; }
}
