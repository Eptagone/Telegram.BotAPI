// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a boost removed from a chat.
/// </summary>
public class ChatBoostRemoved
{
    /// <summary>
    /// Chat which was boosted
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Unique identifier of the boost
    /// </summary>
    [JsonPropertyName(PropertyNames.BoostId)]
    public string BoostId { get; set; } = null!;

    /// <summary>
    /// Point in time (Unix timestamp) when the boost was removed
    /// </summary>
    [JsonPropertyName(PropertyNames.RemoveDate)]
    public int RemoveDate { get; set; }

    /// <summary>
    /// Source of the removed boost
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public ChatBoostSource Source { get; set; } = null!;
}
