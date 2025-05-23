// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a video to be sent.
/// </summary>
public class InputMediaVideo : InputMedia
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputMediaVideo"/> class.
    /// </summary>
    /// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    public InputMediaVideo(string media)
    {
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Type of the result, must be <em>video</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "video";

    /// <summary>
    /// Optional. Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Thumbnail)]
    public string? Thumbnail { get; set; }

    /// <summary>
    /// Optional. Cover for the video in the message. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>
    /// </summary>
    [JsonPropertyName(PropertyNames.Cover)]
    public string? Cover { get; set; }

    /// <summary>
    /// Optional. Start timestamp for the video in the message
    /// </summary>
    [JsonPropertyName(PropertyNames.StartTimestamp)]
    public int? StartTimestamp { get; set; }

    /// <summary>
    /// Optional. Caption of the video to be sent, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public override string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the video caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public override string? ParseMode { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em>, if the caption must be shown above the message media
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowCaptionAboveMedia)]
    public bool? ShowCaptionAboveMedia { get; set; }

    /// <summary>
    /// Optional. Video width
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int? Width { get; set; }

    /// <summary>
    /// Optional. Video height
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int? Height { get; set; }

    /// <summary>
    /// Optional. Video duration in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.Duration)]
    public int? Duration { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the uploaded video is suitable for streaming
    /// </summary>
    [JsonPropertyName(PropertyNames.SupportsStreaming)]
    public bool? SupportsStreaming { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the video needs to be covered with a spoiler animation
    /// </summary>
    [JsonPropertyName(PropertyNames.HasSpoiler)]
    public bool? HasSpoiler { get; set; }
}
