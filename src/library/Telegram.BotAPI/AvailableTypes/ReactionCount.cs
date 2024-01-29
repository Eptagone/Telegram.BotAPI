// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a reaction added to a message along with the number of times it was added.
/// </summary>
public class ReactionCount
{
    /// <summary>
    /// Type of the reaction
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public ReactionType Type { get; set; } = null!;

    /// <summary>
    /// Number of times the reaction was added
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalCount)]
    public int TotalCount { get; set; }
}
