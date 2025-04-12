// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a story area containing weather information. Currently, a story can have up to 3 weather areas.
/// </summary>
public class StoryAreaTypeWeather : StoryAreaType
{
    /// <summary>
    /// Type of the area, always “weather”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "weather";

    /// <summary>
    /// Temperature, in degree Celsius
    /// </summary>
    [JsonPropertyName(PropertyNames.Temperature)]
    public float Temperature { get; set; }

    /// <summary>
    /// Emoji representing the weather
    /// </summary>
    [JsonPropertyName(PropertyNames.Emoji)]
    public string Emoji { get; set; } = null!;

    /// <summary>
    /// A color of the area background in the ARGB format
    /// </summary>
    [JsonPropertyName(PropertyNames.BackgroundColor)]
    public int BackgroundColor { get; set; }
}
