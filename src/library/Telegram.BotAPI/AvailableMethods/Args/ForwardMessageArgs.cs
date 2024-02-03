// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "ForwardMessage" method.
/// </summary>
public class ForwardMessageArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public ForwardMessageArgs(long chatId, long fromChatId, int messageId)
    {
        this.ChatId = chatId;
        this.FromChatId = fromChatId;
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public ForwardMessageArgs(long chatId, string fromChatId, int messageId)
    {
        this.ChatId = chatId;
        this.FromChatId = fromChatId ?? throw new ArgumentNullException(nameof(fromChatId));
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public ForwardMessageArgs(string chatId, long fromChatId, int messageId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.FromChatId = fromChatId;
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ForwardMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public ForwardMessageArgs(string chatId, string fromChatId, int messageId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.FromChatId = fromChatId ?? throw new ArgumentNullException(nameof(fromChatId));
        this.MessageId = messageId;
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
    /// Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.FromChatId)]
    public object FromChatId { get; set; }

    /// <summary>
    /// Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the forwarded message from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Message identifier in the chat specified in <em>from_chat_id</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }
}
