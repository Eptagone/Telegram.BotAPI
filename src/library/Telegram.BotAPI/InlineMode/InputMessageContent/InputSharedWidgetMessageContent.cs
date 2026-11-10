// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#inputmessagecontent">content</a> of a message with a shared widget to be sent as the result of an inline query. Currently, widgets can't be sent in response to inline queries in the production environment.
/// </summary>
public class InputSharedWidgetMessageContent : InputMessageContent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="InputSharedWidgetMessageContent"/> class.
    /// </summary>
    /// <param name="widgetId">Unique identifier of the shared widget created by the bot</param>
    public InputSharedWidgetMessageContent(string widgetId)
    {
        this.WidgetId = widgetId ?? throw new ArgumentNullException(nameof(widgetId));
    }

    /// <summary>
    /// Unique identifier of the shared widget created by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.WidgetId)]
    public string WidgetId { get; set; }

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
}
