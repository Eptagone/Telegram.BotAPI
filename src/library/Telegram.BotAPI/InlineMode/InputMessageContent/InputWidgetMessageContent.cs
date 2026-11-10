// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a> to be sent as the result of an inline query. Currently, widgets can't be sent in response to inline queries in the production environment.
/// </summary>
public class InputWidgetMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputWidgetMessageContent"/> class.
    /// </summary>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    public InputWidgetMessageContent(string html)
    {
        this.Html = html ?? throw new ArgumentNullException(nameof(html));
    }

    /// <summary>
    /// HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.
    /// </summary>
    [JsonPropertyName(PropertyNames.Html)]
    public string Html { get; set; }

    /// <summary>
    /// Optional. Width of the widget in logical pixels; omit if the widget must occupy the whole width of the message bubble. The width is clamped by the app to the range from 200 to the maximum width of the message bubble.
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int? Width { get; set; }

    /// <summary>
    /// Optional. Height of the widget in logical pixels; omit if the height of the widget isn't fixed. The height is clamped by the app to the range 50-600.
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int? Height { get; set; }

    /// <summary>
    /// Optional. Public data of the widget, 0-1024 bytes, which will be available wherever the widget is shown. If the widget is shared, then all messages with it will have the same public data.
    /// </summary>
    [JsonPropertyName(PropertyNames.PublicData)]
    public string? PublicData { get; set; }

    /// <summary>
    /// Optional. Data of the widget, which is specific to the message, 0-1024 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatData)]
    public string? ChatData { get; set; }

    /// <summary>
    /// Optional. Widget caption, 0-1024 characters after entities parsing
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Optional. Mode for parsing entities in the widget caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// Optional. List of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> if the caption must be shown above the widget
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowCaptionAboveMedia)]
    public bool? ShowCaptionAboveMedia { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to allow the widget to send queries to the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowQueries)]
    public bool? AllowQueries { get; set; }

    /// <summary>
    /// Optional. Pass <em>True</em> to create a shared widget. Each message sent from the result creates a separate shared widget, whose identifier is received by the bot only in the field <em>widget_id</em> of queries from the widget. To send an existing shared widget in response to an inline query, use <see cref="InputSharedWidgetMessageContent"/> instead.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsShared)]
    public bool? IsShared { get; set; }
}
