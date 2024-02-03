// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// This object represents an incoming inline query. When the user sends an empty query, your bot could return some default or trending results.
/// </summary>
public class InlineQuery
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
    /// Text of the query (up to 256 characters)
    /// </summary>
    [JsonPropertyName(PropertyNames.Query)]
    public string Query { get; set; } = null!;

    /// <summary>
    /// Offset of the results to be returned, can be controlled by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Offset)]
    public string Offset { get; set; } = null!;

    /// <summary>
    /// Optional. Type of the chat from which the inline query was sent. Can be either “sender” for a private chat with the inline query sender, “private”, “group”, “supergroup”, or “channel”. The chat type should be always known for requests sent from official clients and most third-party clients, unless the request was sent from a secret chat
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatType)]
    public string? ChatType { get; set; }

    /// <summary>
    /// Optional. Sender location, only for bots that request user location
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location? Location { get; set; }
}
