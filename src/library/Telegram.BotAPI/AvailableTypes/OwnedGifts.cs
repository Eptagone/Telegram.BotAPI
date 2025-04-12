// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Contains the list of gifts received and owned by a user or a chat.
/// </summary>
public class OwnedGifts
{
    /// <summary>
    /// The total number of gifts owned by the user or the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalCount)]
    public int TotalCount { get; set; }

    /// <summary>
    /// The list of gifts
    /// </summary>
    [JsonPropertyName(PropertyNames.Gifts)]
    public IEnumerable<OwnedGift> Gifts { get; set; } = null!;

    /// <summary>
    /// Optional. Offset for the next request. If empty, then there are no more results
    /// </summary>
    [JsonPropertyName(PropertyNames.NextOffset)]
    public string? NextOffset { get; set; }
}
