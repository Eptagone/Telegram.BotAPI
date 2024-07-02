// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a point on the map.
/// </summary>
public class Location
{
    /// <summary>
    /// Latitude as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Longitude as defined by the sender
    /// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    public float Longitude { get; set; }

    /// <summary>
    /// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
    /// </summary>
    [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
    public float? HorizontalAccuracy { get; set; }

    /// <summary>
    /// Optional. Time relative to the message sending date, during which the location can be updated; in seconds. For active live locations only.
    /// </summary>
    [JsonPropertyName(PropertyNames.LivePeriod)]
    public int? LivePeriod { get; set; }

    /// <summary>
    /// Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.
    /// </summary>
    [JsonPropertyName(PropertyNames.Heading)]
    public int? Heading { get; set; }

    /// <summary>
    /// Optional. The maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.
    /// </summary>
    [JsonPropertyName(PropertyNames.ProximityAlertRadius)]
    public int? ProximityAlertRadius { get; set; }
}
