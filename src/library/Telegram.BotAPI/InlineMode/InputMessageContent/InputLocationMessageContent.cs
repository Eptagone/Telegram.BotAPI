// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a location message to be sent as the result of an inline query.
/// </summary>
public class InputLocationMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputLocationMessageContent"/> class.
    /// </summary>
    /// <param name="latitude">Latitude of the location in degrees</param>
    /// <param name="longitude">Longitude of the location in degrees</param>
    public InputLocationMessageContent(float latitude, float longitude)
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
    }

    /// <summary>
    /// Latitude of the location in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Longitude of the location in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    public float Longitude { get; set; }

    /// <summary>
    /// Optional. The radius of uncertainty for the location, measured in meters; 0-1500
    /// </summary>
    [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
    public float? HorizontalAccuracy { get; set; }

    /// <summary>
    /// Optional. Period in seconds during which the location can be updated, should be between 60 and 86400, or 0x7FFFFFFF for live locations that can be edited indefinitely.
    /// </summary>
    [JsonPropertyName(PropertyNames.LivePeriod)]
    public int? LivePeriod { get; set; }

    /// <summary>
    /// Optional. For live locations, a direction in which the user is moving, in degrees. Must be between 1 and 360 if specified.
    /// </summary>
    [JsonPropertyName(PropertyNames.Heading)]
    public int? Heading { get; set; }

    /// <summary>
    /// Optional. For live locations, a maximum distance for proximity alerts about approaching another chat member, in meters. Must be between 1 and 100000 if specified.
    /// </summary>
    [JsonPropertyName(PropertyNames.ProximityAlertRadius)]
    public int? ProximityAlertRadius { get; set; }
}
