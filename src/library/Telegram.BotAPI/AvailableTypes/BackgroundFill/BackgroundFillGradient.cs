// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is a gradient fill.
/// </summary>
public class BackgroundFillGradient : BackgroundFill
{
    /// <summary>
    /// Type of the background fill, always “gradient”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "gradient";

    /// <summary>
    /// Top color of the gradient in the RGB24 format
    /// </summary>
    [JsonPropertyName(PropertyNames.TopColor)]
    public int TopColor { get; set; }

    /// <summary>
    /// Bottom color of the gradient in the RGB24 format
    /// </summary>
    [JsonPropertyName(PropertyNames.BottomColor)]
    public int BottomColor { get; set; }

    /// <summary>
    /// Clockwise rotation angle of the background fill in degrees; 0-359
    /// </summary>
    [JsonPropertyName(PropertyNames.RotationAngle)]
    public int RotationAngle { get; set; }
}
