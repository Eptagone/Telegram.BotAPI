// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the audios displayed on a user's profile.
/// </summary>
public class UserProfileAudios
{
    /// <summary>
    /// Total number of profile audios for the target user
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalCount)]
    public int TotalCount { get; set; }

    /// <summary>
    /// Requested profile audios
    /// </summary>
    [JsonPropertyName(PropertyNames.Audios)]
    public IEnumerable<Audio> Audios { get; set; } = null!;
}
