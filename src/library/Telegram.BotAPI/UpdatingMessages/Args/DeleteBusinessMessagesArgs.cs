// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Represents the arguments of the "DeleteBusinessMessages" method.
/// </summary>
public class DeleteBusinessMessagesArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DeleteBusinessMessagesArgs"/> class.
    /// </summary>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which to delete the messages</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. All messages must be from the same chat. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    public DeleteBusinessMessagesArgs(string businessConnectionId, IEnumerable<int> messageIds)
    {
        this.BusinessConnectionId = businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId));
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Unique identifier of the business connection on behalf of which to delete the messages
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string BusinessConnectionId { get; set; }

    /// <summary>
    /// A JSON-serialized list of 1-100 identifiers of messages to delete. All messages must be from the same chat. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageIds)]
    public IEnumerable<int> MessageIds { get; set; }
}
