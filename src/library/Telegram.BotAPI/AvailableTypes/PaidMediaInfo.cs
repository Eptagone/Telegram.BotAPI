// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the paid media added to a message.
/// </summary>
public class PaidMediaInfo
{
    /// <summary>
    /// The number of Telegram Stars that must be paid to buy access to the media
    /// </summary>
    [JsonPropertyName(PropertyNames.StarCount)]
    public int StarCount { get; set; }

    /// <summary>
    /// Information about the paid media
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMedia)]
    public IEnumerable<PaidMedia> PaidMedia { get; set; } = null!;
}
