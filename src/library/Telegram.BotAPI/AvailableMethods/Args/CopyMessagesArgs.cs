// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// CopyMessages method arguments.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class CopyMessagesArgs
{
	/// <summary>
	/// Initializes a new instance of <see cref="CopyMessagesArgs"/> with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername)</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	public CopyMessagesArgs(long chatId, long fromChatId, IEnumerable<long> messageIds)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageIds = messageIds;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="CopyMessagesArgs"/> with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername)</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	public CopyMessagesArgs(string chatId, long fromChatId, IEnumerable<long> messageIds)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageIds = messageIds;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="CopyMessagesArgs"/> with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername)</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	public CopyMessagesArgs(long chatId, string fromChatId, IEnumerable<long> messageIds)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageIds = messageIds;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="CopyMessagesArgs"/> with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername)</param>
	/// <param name="messageIds">Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.</param>
	public CopyMessagesArgs(string chatId, string fromChatId, IEnumerable<long> messageIds)
	{
		this.ChatId = chatId;
		this.FromChatId = fromChatId;
		this.MessageIds = messageIds;
	}

	/// <summary>
	/// Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object ChatId { get; }
	/// <summary>
	/// Unique identifier for the chat where the original messages were sent (or channel username in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.FromChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object FromChatId { get; }
	/// <summary>
	/// Identifiers of 1-100 messages in the chat from_chat_id to copy. The identifiers must be specified in a strictly increasing order.
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageIds)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<long> MessageIds { get; }
	/// <summary>
	/// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>
	/// Sends the messages silently. Users will receive a notification with no sound.
	/// </summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>
	/// Protects the contents of the sent messages from forwarding and saving
	/// </summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
	/// <summary>
	/// Pass True to copy the messages without their captions
	/// </summary>
	[JsonPropertyName(PropertyNames.RemoveCaption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? RemoveCaption { get; set; }
}
