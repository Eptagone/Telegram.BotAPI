// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the position of a clickable area within a story.
/// </summary>
public class StoryAreaPosition
{
    /// <summary>
    /// The abscissa of the area's center, as a percentage of the media width
    /// </summary>
    [JsonPropertyName(PropertyNames.XPercentage)]
    public float XPercentage { get; set; }

    /// <summary>
    /// The ordinate of the area's center, as a percentage of the media height
    /// </summary>
    [JsonPropertyName(PropertyNames.YPercentage)]
    public float YPercentage { get; set; }

    /// <summary>
    /// The width of the area's rectangle, as a percentage of the media width
    /// </summary>
    [JsonPropertyName(PropertyNames.WidthPercentage)]
    public float WidthPercentage { get; set; }

    /// <summary>
    /// The height of the area's rectangle, as a percentage of the media height
    /// </summary>
    [JsonPropertyName(PropertyNames.HeightPercentage)]
    public float HeightPercentage { get; set; }

    /// <summary>
    /// The clockwise rotation angle of the rectangle, in degrees; 0-360
    /// </summary>
    [JsonPropertyName(PropertyNames.RotationAngle)]
    public float RotationAngle { get; set; }

    /// <summary>
    /// The radius of the rectangle corner rounding, as a percentage of the media width
    /// </summary>
    [JsonPropertyName(PropertyNames.CornerRadiusPercentage)]
    public float CornerRadiusPercentage { get; set; }
}
