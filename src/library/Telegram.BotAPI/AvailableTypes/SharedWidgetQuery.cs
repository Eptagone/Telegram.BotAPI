// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an incoming query from a forwarded message with a shared widget created by the bot. Use <a href="https://core.telegram.org/bots/api#answerwidgetquery">answerWidgetQuery</a> to answer the query. Each user can send at most 5 queries per 5 seconds to the bot from all its widgets.
/// </summary>
public class SharedWidgetQuery
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
    /// Unique identifier of the shared widget, which sent the query
    /// </summary>
    [JsonPropertyName(PropertyNames.WidgetId)]
    public string WidgetId { get; set; } = null!;
}
