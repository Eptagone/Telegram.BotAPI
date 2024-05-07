// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The background is filled using the selected color.
/// </summary>
public class BackgroundFillSolid : BackgroundFill
{
    /// <summary>
    /// Type of the background fill, always “solid”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "solid";

    /// <summary>
    /// The color of the background fill in the RGB24 format
    /// </summary>
    [JsonPropertyName(PropertyNames.Color)]
    public int Color { get; set; }
}
