// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>.
/// </summary>
public class Widget
{
    /// <summary>
    /// Optional. Unique identifier of the shared widget, which can be used to send the widget again using the method <a href="https://core.telegram.org/bots/api#sendsharedwidget">sendSharedWidget</a>; omitted if the widget isn't shared
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string? Id { get; set; }

    /// <summary>
    /// Optional. Width of the widget in logical pixels; omitted if the widget must occupy the whole width of the message bubble
    /// </summary>
    [JsonPropertyName(PropertyNames.Width)]
    public int? Width { get; set; }

    /// <summary>
    /// Optional. Height of the widget in logical pixels; omitted if the height of the widget isn't fixed
    /// </summary>
    [JsonPropertyName(PropertyNames.Height)]
    public int? Height { get; set; }

    /// <summary>
    /// HTML code of the widget
    /// </summary>
    [JsonPropertyName(PropertyNames.Html)]
    public string Html { get; set; } = null!;

    /// <summary>
    /// Optional. Public data of the widget, which is available wherever the widget is shown. All messages with a shared widget have the same public data.
    /// </summary>
    [JsonPropertyName(PropertyNames.PublicData)]
    public string? PublicData { get; set; }

    /// <summary>
    /// Optional. Data of the widget, which is specific to the message
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatData)]
    public string? ChatData { get; set; }
}
