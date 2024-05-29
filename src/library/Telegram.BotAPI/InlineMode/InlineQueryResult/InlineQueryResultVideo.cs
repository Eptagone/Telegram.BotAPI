// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a link to a page containing an embedded video player or a video file. By default, this video file will be sent by the user with an optional caption. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the video.
/// </summary>
public class InlineQueryResultVideo : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>video</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "video";

    /// <summary>
    /// Unique identifier for this result, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// A valid URL for the embedded video player or video file
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoUrl)]
    public string VideoUrl { get; set; } = null!;

    /// <summary>
    /// MIME type of the content of the video URL, “text/html” or “video/mp4”
    /// </summary>
    [JsonPropertyName(PropertyNames.MimeType)]
    public string MimeType { get; set; } = null!;

    /// <summary>
    /// URL of the thumbnail (JPEG only) for the video
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailUrl)]
    public string ThumbnailUrl { get; set; } = null!;

    /// <summary>
    /// Title for the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the video to be sent, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the video caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em>, if the caption must be shown above the message media
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowCaptionAboveMedia)]
    public bool? ShowCaptionAboveMedia { get; set; }

    /// <summary>
    /// Optional. Video width
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoWidth)]
    public int? VideoWidth { get; set; }

    /// <summary>
    /// Optional. Video height
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoHeight)]
    public int? VideoHeight { get; set; }

    /// <summary>
    /// Optional. Video duration in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoDuration)]
    public int? VideoDuration { get; set; }

    /// <summary>
    /// Optional. Short description of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string? Description { get; set; }

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the video. This field is <strong>required</strong> if InlineQueryResultVideo is used to send an HTML-page as a result (e.g., a YouTube video).
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent? InputMessageContent { get; set; }
}
