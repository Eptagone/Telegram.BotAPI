// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>CopyMessage method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class CopyMessageArgs
{
	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(long chatId, long fromChatId, int messageId)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(string chatId, long fromChatId, int messageId)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(long chatId, string fromChatId, int messageId)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(string chatId, string fromChatId, int messageId)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; set; }
	/// <summary>
	/// Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.FromChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object FromChatId { get; set; }
	/// <summary>
	/// Message identifier in the chat specified in from_chat_id
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int MessageId { get; set; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept
	/// </summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Caption { get; set; }
	/// <summary>
	/// Mode for parsing entities in the new caption. See formatting options for more details.
	/// </summary>
	[JsonPropertyName(PropertyNames.ParseMode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ParseMode { get; set; }
	/// <summary>
	/// A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode
	/// </summary>
	[JsonPropertyName(PropertyNames.CaptionEntities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
	/// <summary>
	/// Sends the message silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent message from forwarding and saving
	/// </summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
	/// <summary>
	/// Description of the message to reply to
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyParameters)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyParameters? ReplyParameters { get; set; }
	/// <summary>
	/// Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReplyMarkup? ReplyMarkup { get; set; }
}
