// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is a wallpaper in the JPEG format.
/// </summary>
public class BackgroundTypeWallpaper : BackgroundType
{
    /// <summary>
    /// Type of the background, always “wallpaper”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "wallpaper";

    /// <summary>
    /// Document with the wallpaper
    /// </summary>
    [JsonPropertyName(PropertyNames.Document)]
    public Document Document { get; set; } = null!;

    /// <summary>
    /// Dimming of the background in dark themes, as a percentage; 0-100
    /// </summary>
    [JsonPropertyName(PropertyNames.DarkThemeDimming)]
    public int DarkThemeDimming { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the wallpaper is downscaled to fit in a 450x450 square and then box-blurred with radius 12
    /// </summary>
    [JsonPropertyName(PropertyNames.IsBlurred)]
    public bool? IsBlurred { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the background moves slightly when the device is tilted
    /// </summary>
    [JsonPropertyName(PropertyNames.IsMoving)]
    public bool? IsMoving { get; set; }
}
