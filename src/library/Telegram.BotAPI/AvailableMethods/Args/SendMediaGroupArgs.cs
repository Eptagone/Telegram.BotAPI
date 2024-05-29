// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SendMediaGroup" method.
/// </summary>
public class SendMediaGroupArgs : AttachedFilesArgsBase
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(long chatId, IEnumerable<InputMediaAudio> media)
    {
        this.ChatId = chatId;
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(long chatId, IEnumerable<InputMediaDocument> media)
    {
        this.ChatId = chatId;
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(long chatId, IEnumerable<InputMediaPhoto> media)
    {
        this.ChatId = chatId;
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(long chatId, IEnumerable<InputMediaVideo> media)
    {
        this.ChatId = chatId;
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(string chatId, IEnumerable<InputMediaAudio> media)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(string chatId, IEnumerable<InputMediaDocument> media)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(string chatId, IEnumerable<InputMediaPhoto> media)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendMediaGroupArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    public SendMediaGroupArgs(string chatId, IEnumerable<InputMediaVideo> media)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Media = media ?? throw new ArgumentNullException(nameof(media));
    }

    /// <summary>
    /// Unique identifier of the business connection on behalf of which the message will be sent
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessConnectionId)]
    public string? BusinessConnectionId { get; set; }

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
    /// A JSON-serialized array describing messages to be sent, must include 2-10 items
    /// </summary>
    [JsonPropertyName(PropertyNames.Media)]
    public object Media { get; set; }

    /// <summary>
    /// Sends messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the sent messages from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Unique identifier of the message effect to be added to the message; for private chats only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageEffectId)]
    public string? MessageEffectId { get; set; }

    /// <summary>
    /// Description of the message to reply to
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyParameters)]
    public ReplyParameters? ReplyParameters { get; set; }
}
