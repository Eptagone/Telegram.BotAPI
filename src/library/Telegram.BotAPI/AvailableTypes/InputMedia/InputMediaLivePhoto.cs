// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a live photo to be sent.
/// </summary>
public class InputMediaLivePhoto : InputMedia
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputMediaLivePhoto"/> class.
    /// </summary>
    /// <param name="media">Video of the live photo to send. Pass a file_id to send a file that exists on the Telegram servers (recommended) or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending live photos by a URL is currently unsupported.</param>
    /// <param name="photo">The static photo to send. Pass a file_id to send a file that exists on the Telegram servers (recommended) or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending live photos by a URL is currently unsupported.</param>
    public InputMediaLivePhoto(string media, string photo)
    {
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
        this.Photo = photo ?? throw new ArgumentNullException(nameof(photo));
    }

    /// <summary>
    /// Type of the result, must be <em>live_photo</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "live_photo";

    /// <summary>
    /// Video of the live photo to send. Pass a file_id to send a file that exists on the Telegram servers (recommended) or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending live photos by a URL is currently unsupported.
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public string Media { get; set; }

    /// <summary>
    /// The static photo to send. Pass a file_id to send a file that exists on the Telegram servers (recommended) or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a>. Sending live photos by a URL is currently unsupported.
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public string Photo { get; set; }

    /// <summary>
    /// Optional. Caption of the live photo to be sent, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the live photo caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
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
    /// Optional. Pass <em>True</em> if the live photo needs to be covered with a spoiler animation
    /// </summary>
    [JsonPropertyName(PropertyNames.HasSpoiler)]
    public bool? HasSpoiler { get; set; }
}
