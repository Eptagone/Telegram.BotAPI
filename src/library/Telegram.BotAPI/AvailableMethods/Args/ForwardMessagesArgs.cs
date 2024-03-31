// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "ForwardMessages" method.
/// </summary>
public class ForwardMessagesArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessagesArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    public ForwardMessagesArgs(long chatId, long fromChatId, IEnumerable<int> messageIds)
    {
        this.ChatId = chatId;
        this.FromChatId = fromChatId;
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessagesArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    public ForwardMessagesArgs(long chatId, string fromChatId, IEnumerable<int> messageIds)
    {
        this.ChatId = chatId;
        this.FromChatId = fromChatId ?? throw new ArgumentNullException(nameof(fromChatId));
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessagesArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    public ForwardMessagesArgs(string chatId, long fromChatId, IEnumerable<int> messageIds)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.FromChatId = fromChatId;
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessagesArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    public ForwardMessagesArgs(string chatId, string fromChatId, IEnumerable<int> messageIds)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.FromChatId = fromChatId ?? throw new ArgumentNullException(nameof(fromChatId));
        this.MessageIds = messageIds ?? throw new ArgumentNullException(nameof(messageIds));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.FromChatId)]
    public object FromChatId { get; set; }

    /// <summary>
    /// A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageIds)]
    public IEnumerable<int> MessageIds { get; set; }

    /// <summary>
    /// Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the forwarded messages from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }
}
