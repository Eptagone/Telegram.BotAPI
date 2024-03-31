// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "DeleteMessages" method.
/// </summary>
public class DeleteMessagesArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteMessagesArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    public DeleteMessagesArgs(long chatId, IEnumerable<int> messageIds)
    {
        this.ChatId = chatId;
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteMessagesArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    public DeleteMessagesArgs(string chatId, IEnumerable<int> messageIds)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageIds)]
    public IEnumerable<int> MessageIds { get; set; }
}
