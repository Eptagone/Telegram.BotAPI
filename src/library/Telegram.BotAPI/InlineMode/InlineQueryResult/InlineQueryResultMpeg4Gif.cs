// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a link to a video animation (H.264/MPEG-4 AVC video without sound). By default, this animated MPEG-4 file will be sent by the user with optional caption. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the animation.
/// </summary>
public class InlineQueryResultMpeg4Gif : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>mpeg4_gif</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "mpeg4_gif";

    /// <summary>
    /// Unique identifier for this result, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// A valid URL for the MPEG4 file. File size must not exceed 1MB
    /// </summary>
    [JsonPropertyName(PropertyNames.Mpeg4Url)]
    public string Mpeg4Url { get; set; } = null!;

    /// <summary>
    /// Optional. Video width
    /// </summary>
    [JsonPropertyName(PropertyNames.Mpeg4Width)]
    public int? Mpeg4Width { get; set; }

    /// <summary>
    /// Optional. Video height
    /// </summary>
    [JsonPropertyName(PropertyNames.Mpeg4Height)]
    public int? Mpeg4Height { get; set; }

    /// <summary>
    /// Optional. Video duration in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.Mpeg4Duration)]
    public int? Mpeg4Duration { get; set; }

    /// <summary>
    /// URL of the static (JPEG or GIF) or animated (MPEG4) thumbnail for the result
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailUrl)]
    public string ThumbnailUrl { get; set; } = null!;

    /// <summary>
    /// Optional. MIME type of the thumbnail, must be one of “image/jpeg”, “image/gif”, or “video/mp4”. Defaults to “image/jpeg”
    /// </summary>
    [JsonPropertyName(PropertyNames.ThumbnailMimeType)]
    public string? ThumbnailMimeType { get; set; }

    /// <summary>
    /// Optional. Title for the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string? Title { get; set; }

    /// <summary>
    /// Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
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
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the video animation
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent? InputMessageContent { get; set; }
}
