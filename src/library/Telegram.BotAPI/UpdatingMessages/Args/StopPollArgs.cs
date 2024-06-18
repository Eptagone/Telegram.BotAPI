// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "StopPoll" method.
/// </summary>
public class StopPollArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="StopPollArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the original message with the poll</param>
    public StopPollArgs(long chatId, int messageId)
    {
        this.ChatId = chatId;
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="StopPollArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Identifier of the original message with the poll</param>
    public StopPollArgs(string chatId, int messageId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.MessageId = messageId;
    }

    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message to be edited was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string? BusinessConnectionId { get; set; }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Identifier of the original message with the poll
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// A JSON-serialized object for a new message <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
