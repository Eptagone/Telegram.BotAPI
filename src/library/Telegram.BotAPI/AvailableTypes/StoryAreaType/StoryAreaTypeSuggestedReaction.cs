// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a story area pointing to a suggested reaction. Currently, a story can have up to 5 suggested reaction areas.
/// </summary>
public class StoryAreaTypeSuggestedReaction : StoryAreaType
{
    /// <summary>
    /// Type of the area, always “suggested_reaction”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "suggested_reaction";

    /// <summary>
    /// Type of the reaction
    /// </summary>
    [JsonPropertyName(PropertyNames.ReactionType)]
    public ReactionType ReactionType { get; set; } = null!;

    /// <summary>
    /// Optional. Pass <em>True</em> if the reaction area has a dark background
    /// </summary>
    [JsonPropertyName(PropertyNames.IsDark)]
    public bool? IsDark { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if reaction area corner is flipped
    /// </summary>
    [JsonPropertyName(PropertyNames.IsFlipped)]
    public bool? IsFlipped { get; set; }
}
