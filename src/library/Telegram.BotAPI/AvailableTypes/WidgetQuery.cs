// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an incoming query from a widget in a message sent by the bot or via the bot. Use <a href="https://core.telegram.org/bots/api#answerwidgetquery">answerWidgetQuery</a> to answer the query. Each user can send at most 5 queries per 5 seconds to the bot from all its widgets.
/// </summary>
public class WidgetQuery
{
    /// <summary>
    /// Unique identifier for this query
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Sender
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Optional. Chat with the message containing the widget; omitted if the widget is in an inline message
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat? Chat { get; set; }

    /// <summary>
    /// Optional. Identifier of the message containing the widget; omitted if the widget is in an inline message
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int? MessageId { get; set; }

    /// <summary>
    /// Optional. Identifier of the inline message containing the widget
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }

    /// <summary>
    /// Global identifier, uniquely corresponding to the chat to which the message with the widget was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatInstance)]
    public string ChatInstance { get; set; } = null!;

    /// <summary>
    /// Optional. For widgets in inline messages, type of the chat to which the message was sent. Can be either “sender” for a private chat with the inline query sender, “private”, “group”, “supergroup”, or “channel”.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatType)]
    public string? ChatType { get; set; }

    /// <summary>
    /// Type of the query
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public WidgetQueryType Type { get; set; } = null!;

    /// <summary>
    /// Data of the query, 1-64 bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public string Data { get; set; } = null!;

    /// <summary>
    /// Optional. Unique identifier of the shared widget, which sent the query; omitted if the widget isn't shared
    /// </summary>
    [JsonPropertyName(PropertyNames.WidgetId)]
    public string? WidgetId { get; set; }
}
