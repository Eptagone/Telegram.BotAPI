// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a link to a file. By default, this file will be sent by the user with an optional caption. Alternatively, you can use <em>input_message_content</em> to send a message with the specified content instead of the file. Currently, only <strong>.PDF</strong> and <strong>.ZIP</strong> files can be sent using this method.
/// </summary>
public class InlineQueryResultDocument : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>document</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "document";

    /// <summary>
    /// Unique identifier for this result, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// Title for the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Optional. Caption of the document to be sent, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// A valid URL for the file
    /// </summary>
    [JsonPropertyName(PropertyNames.DocumentUrl)]
    public string DocumentUrl { get; set; } = null!;

    /// <summary>
    /// MIME type of the content of the file, either “application/pdf” or “application/zip”
    /// </summary>
    [JsonPropertyName(PropertyNames.MimeType)]
    public string MimeType { get; set; } = null!;

    /// <summary>
    /// Optional. Short description of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string? Description { get; set; }

    /// <summary>
    /// Optional. Inline keyboard attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. Content of the message to be sent instead of the file
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent? InputMessageContent { get; set; }

    /// <summary>
    /// Optional. URL of the thumbnail (JPEG only) for the file
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
