// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Games;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an incoming callback query from a callback button in an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>. If the button that originated the query was attached to a message sent by the bot, the field <em>message</em> will be present. If the button was attached to a message sent via the bot (in <a href="https://core.telegram.org/bots/api#inline-mode">inline mode</a>), the field <em>inline_message_id</em> will be present. Exactly one of the fields <em>data</em> or <em>game_short_name</em> will be present.
/// </summary>
public class CallbackQuery
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
    /// Optional. Message sent by the bot with the callback button that originated the query
    /// </summary>
    [JsonPropertyName(PropertyNames.Message)]
    public MaybeInaccessibleMessage? Message { get; set; }

    /// <summary>
    /// Optional. Identifier of the message sent via the bot in inline mode, that originated the query.
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }

    /// <summary>
    /// Global identifier, uniquely corresponding to the chat to which the message with the callback button was sent. Useful for high scores in <a href="https://core.telegram.org/bots/api#games">games</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatInstance)]
    public string ChatInstance { get; set; } = null!;

    /// <summary>
    /// Optional. Data associated with the callback button. Be aware that the message originated the query can contain no callback buttons with this data.
    /// </summary>
    [JsonPropertyName(PropertyNames.Data)]
    public string? Data { get; set; }

    /// <summary>
    /// Optional. Short name of a <see cref="Game"/> to be returned, serves as the unique identifier for the game
    /// </summary>
    [JsonPropertyName(PropertyNames.GameShortName)]
    public string? GameShortName { get; set; }
}
