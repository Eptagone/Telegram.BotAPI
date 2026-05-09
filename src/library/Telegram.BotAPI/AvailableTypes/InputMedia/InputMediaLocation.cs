// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a location to be sent.
/// </summary>
public class InputMediaLocation : InputMedia
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputMediaLocation"/> class.
    /// </summary>
    /// <param name="latitude">Latitude of the location</param>
    /// <param name="longitude">Longitude of the location</param>
    public InputMediaLocation(float latitude, float longitude)
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
    }

    /// <summary>
    /// Type of the result, must be <em>location</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "location";

    /// <summary>
    /// Latitude of the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Longitude of the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    public float Longitude { get; set; }

    /// <summary>
    /// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
    /// </summary>
    [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
    public float? HorizontalAccuracy { get; set; }
}
