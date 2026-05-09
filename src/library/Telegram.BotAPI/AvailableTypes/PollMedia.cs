// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// At most <strong>one</strong> of the optional fields can be present in any given object.
/// </summary>
public class PollMedia
{
    /// <summary>
    /// Optional. Media is an animation, information about the animation
    /// </summary>
    [JsonPropertyName(PropertyNames.Animation)]
    public Animation? Animation { get; set; }

    /// <summary>
    /// Optional. Media is an audio file, information about the file; currently, can't be received in a poll option
    /// </summary>
    [JsonPropertyName(PropertyNames.Audio)]
    public Audio? Audio { get; set; }

    /// <summary>
    /// Optional. Media is a general file, information about the file; currently, can't be received in a poll option
    /// </summary>
    [JsonPropertyName(PropertyNames.Document)]
    public Document? Document { get; set; }

    /// <summary>
    /// Optional. Media is a live photo, information about the live photo
    /// </summary>
    [JsonPropertyName(PropertyNames.LivePhoto)]
    public LivePhoto? LivePhoto { get; set; }

    /// <summary>
    /// Optional. Media is a shared location, information about the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location? Location { get; set; }

    /// <summary>
    /// Optional. Media is a photo, available sizes of the photo
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public IEnumerable<PhotoSize>? Photo { get; set; }

    /// <summary>
    /// Optional. Media is a sticker, information about the sticker; currently, for poll options only
    /// </summary>
    [JsonPropertyName(PropertyNames.Sticker)]
    public Sticker? Sticker { get; set; }

    /// <summary>
    /// Optional. Media is a venue, information about the venue
    /// </summary>
    [JsonPropertyName(PropertyNames.Venue)]
    public Venue? Venue { get; set; }

    /// <summary>
    /// Optional. Media is a video, information about the video
    /// </summary>
    [JsonPropertyName(PropertyNames.Video)]
    public Video? Video { get; set; }
}
