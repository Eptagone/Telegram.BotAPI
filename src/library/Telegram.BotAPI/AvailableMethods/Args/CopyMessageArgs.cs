// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "CopyMessage" method.
/// </summary>
public class CopyMessageArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="CopyMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public CopyMessageArgs(long chatId, long fromChatId, int messageId)
    {
        this.ChatId = chatId;
        this.FromChatId = fromChatId;
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public CopyMessageArgs(long chatId, string fromChatId, int messageId)
    {
        this.ChatId = chatId;
        this.FromChatId = fromChatId ?? throw new ArgumentNullException(nameof(fromChatId));
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public CopyMessageArgs(string chatId, long fromChatId, int messageId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.FromChatId = fromChatId;
        this.MessageId = messageId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="CopyMessageArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    public CopyMessageArgs(string chatId, string fromChatId, int messageId)
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
    /// Identifier of the direct messages topic to which the message will be sent; required if the message is sent to a direct messages chat
    /// </summary>
    [JsonPropertyName(PropertyNames.DirectMessagesTopicId)]
    public int? DirectMessagesTopicId { get; set; }

    /// <summary>
    /// Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.FromChatId)]
    public object FromChatId { get; set; }

    /// <summary>
    /// Message identifier in the chat specified in <em>from_chat_id</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageId)]
    public int MessageId { get; set; }

    /// <summary>
    /// New start timestamp for the copied video in the message
    /// </summary>
    [JsonPropertyName(PropertyNames.VideoStartTimestamp)]
    public int? VideoStartTimestamp { get; set; }

    /// <summary>
    /// New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept
    /// </summary>
    [JsonPropertyName(PropertyNames.Caption)]
    public string? Caption { get; set; }

    /// <summary>
    /// Mode for parsing entities in the new caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ParseMode)]
    public string? ParseMode { get; set; }

    /// <summary>
    /// A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of <em>parse_mode</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.CaptionEntities)]
    public IEnumerable<MessageEntity>? CaptionEntities { get; set; }

    /// <summary>
    /// Pass <em>True</em>, if the caption must be shown above the message media. Ignored if a new caption isn't specified.
    /// </summary>
    [JsonPropertyName(PropertyNames.ShowCaptionAboveMedia)]
    public bool? ShowCaptionAboveMedia { get; set; }

    /// <summary>
    /// Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the sent message from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance
    /// </summary>
    [JsonPropertyName(PropertyNames.AllowPaidBroadcast)]
    public bool? AllowPaidBroadcast { get; set; }

    /// <summary>
    /// A JSON-serialized object containing the parameters of the suggested post to send; for direct messages chats only. If the message is sent as a reply to another suggested post, then that suggested post is automatically declined.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedPostParameters)]
    public SuggestedPostParameters? SuggestedPostParameters { get; set; }

    /// <summary>
    /// Description of the message to reply to
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyParameters)]
    public ReplyParameters? ReplyParameters { get; set; }

    /// <summary>
    /// Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public object? ReplyMarkup { get; set; }
}
