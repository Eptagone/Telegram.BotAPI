// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a chat photo.
/// </summary>
public class ChatPhoto
{
    /// <summary>
    /// File identifier of small (160x160) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.
    /// </summary>
    [JsonPropertyName(PropertyNames.SmallFileId)]
    public string SmallFileId { get; set; } = null!;

    /// <summary>
    /// Unique file identifier of small (160x160) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
    /// </summary>
    [JsonPropertyName(PropertyNames.SmallFileUniqueId)]
    public string SmallFileUniqueId { get; set; } = null!;

    /// <summary>
    /// File identifier of big (640x640) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.
    /// </summary>
    [JsonPropertyName(PropertyNames.BigFileId)]
    public string BigFileId { get; set; } = null!;

    /// <summary>
    /// Unique file identifier of big (640x640) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.
    /// </summary>
    [JsonPropertyName(PropertyNames.BigFileUniqueId)]
    public string BigFileUniqueId { get; set; } = null!;
}
