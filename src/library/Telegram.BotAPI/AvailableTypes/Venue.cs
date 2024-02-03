// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a venue.
/// </summary>
public class Venue
{
    /// <summary>
    /// Venue location. Can't be a live location
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location Location { get; set; } = null!;

    /// <summary>
    /// Name of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Address of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Optional. Foursquare identifier of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.FoursquareId)]
    public string? FoursquareId { get; set; }

    /// <summary>
    /// Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)
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
