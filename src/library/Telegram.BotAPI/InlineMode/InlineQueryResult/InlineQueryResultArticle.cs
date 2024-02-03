// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents a link to an article or web page.
/// </summary>
public class InlineQueryResultArticle : InlineQueryResult
{
    /// <summary>
    /// Type of the result, must be <em>article</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "article";

    /// <summary>
    /// Unique identifier for this result, 1-64 Bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public override string Id { get; set; } = null!;

    /// <summary>
    /// Title of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; } = null!;

    /// <summary>
    /// Content of the message to be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.InputMessageContent)]
    public InputMessageContent InputMessageContent { get; set; } = null!;

    /// <summary>
    /// Optional. <a href="https://core.telegram.org/bots/features#inline-keyboards">Inline keyboard</a> attached to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public override InlineKeyboardMarkup? ReplyMarkup { get; set; }

    /// <summary>
    /// Optional. URL of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string? Url { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if you don't want the URL to be shown in the message
    /// </summary>
    [JsonPropertyName(PropertyNames.HideUrl)]
    public bool? HideUrl { get; set; }

    /// <summary>
    /// Optional. Short description of the result
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string? Description { get; set; }

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
