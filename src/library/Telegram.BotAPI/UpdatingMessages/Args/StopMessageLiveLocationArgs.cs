// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "StopMessageLiveLocation" method.
/// </summary>
public class StopMessageLiveLocationArgs
{
    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message to be edited was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string? BusinessConnectionId { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object? ChatId { get; set; }

    /// <summary>
    /// Required if <em>inline_message_id</em> is not specified. Identifier of the message with live location to stop
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int? MessageId { get; set; }

    /// <summary>
    /// Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message
    /// </summary>
    [JsonPropertyName(PropertyNames.InlineMessageId)]
    public string? InlineMessageId { get; set; }

    /// <summary>
    /// A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
