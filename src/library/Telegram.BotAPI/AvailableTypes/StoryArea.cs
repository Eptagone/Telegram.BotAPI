// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a clickable area on a story media.
/// </summary>
public class StoryArea
{
    /// <summary>
    /// Position of the area
    /// </summary>
    [JsonPropertyName(PropertyNames.Position)]
    public StoryAreaPosition Position { get; set; } = null!;

    /// <summary>
    /// Type of the area
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public StoryAreaType Type { get; set; } = null!;
}
