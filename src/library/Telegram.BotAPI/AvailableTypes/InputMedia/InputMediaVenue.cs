// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a venue to be sent.
/// </summary>
public class InputMediaVenue : InputMedia
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputMediaVenue"/> class.
    /// </summary>
    /// <param name="latitude">Latitude of the location</param>
    /// <param name="longitude">Longitude of the location</param>
    /// <param name="title">Name of the venue</param>
    /// <param name="address">Address of the venue</param>
    public InputMediaVenue(float latitude, float longitude, string title, string address)
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Title = title ?? throw new ArgumentNullException(nameof(title));
        this.Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    /// <summary>
    /// Type of the result, must be <em>venue</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "venue";

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
    /// Name of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; }

    /// <summary>
    /// Address of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; }

    /// <summary>
    /// Optional. Foursquare identifier of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.FoursquareId)]
    public string? FoursquareId { get; set; }

    /// <summary>
    /// Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)
    /// </summary>
    [JsonPropertyName(PropertyNames.FoursquareType)]
    public string? FoursquareType { get; set; }

    /// <summary>
    /// Optional. Google Places identifier of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.GooglePlaceId)]
    public string? GooglePlaceId { get; set; }

    /// <summary>
    /// Optional. Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)
    /// </summary>
    [JsonPropertyName(PropertyNames.GooglePlaceType)]
    public string? GooglePlaceType { get; set; }
}
