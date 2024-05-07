// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is automatically filled based on the selected colors.
/// </summary>
public class BackgroundTypeFill : BackgroundType
{
    /// <summary>
    /// Type of the background, always “fill”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "fill";

    /// <summary>
    /// The background fill
    /// </summary>
    [JsonPropertyName(PropertyNames.Fill)]
    public BackgroundFill Fill { get; set; } = null!;

    /// <summary>
    /// Dimming of the background in dark themes, as a percentage; 0-100
    /// </summary>
    [JsonPropertyName(PropertyNames.DarkThemeDimming)]
    public int DarkThemeDimming { get; set; }
}
