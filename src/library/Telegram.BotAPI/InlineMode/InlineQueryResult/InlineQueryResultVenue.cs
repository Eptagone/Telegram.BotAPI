// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the venue.
/// </summary>
public class InlineQueryResultVenue : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>venue</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "venue";

    /// <summary>
    /// Unique identifier for this result, 1-64 Bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// Latitude of the venue location in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Longitude of the venue location in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    public float Longitude { get; set; }

    /// <summary>
    /// Title of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Address of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Optional. Foursquare identifier of the venue if known
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

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent? InputMessageContent { get; set; }

    /// <summary>
    /// Optional. Url of the thumbnail for the result
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailUrl)]
    public string? ThumbnailUrl { get; set; }

    /// <summary>
    /// Optional. Thumbnail width
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailWidth)]
    public int? ThumbnailWidth { get; set; }

    /// <summary>
    /// Optional. Thumbnail height
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailHeight)]
    public int? ThumbnailHeight { get; set; }
}
