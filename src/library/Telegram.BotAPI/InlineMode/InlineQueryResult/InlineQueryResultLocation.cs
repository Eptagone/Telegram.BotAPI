// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the location.
/// </summary>
public class InlineQueryResultLocation : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>location</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "location";

    /// <summary>
    /// Unique identifier for this result, 1-64 Bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// Location latitude in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Latitude)]
    public float Latitude { get; set; }

    /// <summary>
    /// Location longitude in degrees
    /// </summary>
    [JsonPropertyName(PropertyNames.Longitude)]
    public float Longitude { get; set; }

    /// <summary>
    /// Location title
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

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

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the location
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
