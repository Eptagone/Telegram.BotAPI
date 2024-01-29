// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about a chat boost.
/// </summary>
public class ChatBoost
{
    /// <summary>
    /// Unique identifier of the boost
    /// </summary>
    [JsonPropertyName(PropertyNames.BoostId)]
    public string BoostId { get; set; } = null!;

    /// <summary>
    /// Point in time (Unix timestamp) when the chat was boosted
    /// </summary>
    [JsonPropertyName(PropertyNames.AddDate)]
    public int AddDate { get; set; }

    /// <summary>
    /// Point in time (Unix timestamp) when the boost will automatically expire, unless the booster's Telegram Premium subscription is prolonged
    /// </summary>
    [JsonPropertyName(PropertyNames.ExpirationDate)]
    public int ExpirationDate { get; set; }

    /// <summary>
    /// Source of the added boost
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public ChatBoostSource Source { get; set; } = null!;
}
