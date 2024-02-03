// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a venue message to be sent as the result of an inline query.
/// </summary>
public class InputVenueMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputVenueMessageContent"/> class.
    /// </summary>
    /// <param name="latitude">Latitude of the venue in degrees</param>
    /// <param name="longitude">Longitude of the venue in degrees</param>
    /// <param name="title">Name of the venue</param>
    /// <param name="address">Address of the venue</param>
    public InputVenueMessageContent(float latitude, float longitude, string title, string address)
    {
        this.Latitude = latitude;
        this.Longitude = longitude;
        this.Title = title ?? throw new ArgumentNullException(nameof(title));
        this.Address = address ?? throw new ArgumentNullException(nameof(address));
    }

    /// <summary>
    /// Latitude of the venue in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Longitude of the venue in degrees
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
    /// Optional. Foursquare identifier of the venue, if known
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
