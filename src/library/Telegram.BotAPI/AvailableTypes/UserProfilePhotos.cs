// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represent a user's profile pictures.
/// </summary>
public class UserProfilePhotos
{
    /// <summary>
    /// Total number of profile pictures the target user has
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalCount)]
    public int TotalCount { get; set; }

    /// <summary>
    /// Requested profile pictures (in up to 4 sizes each)
    /// </summary>
    [JsonPropertyName(PropertyNames.Photos)]
    public IEnumerable<IEnumerable<PhotoSize>> Photos { get; set; } = null!;
}
