// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;


namespace Telegram.BotAPI;

/// <summary>Base object for message-sending methods arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public abstract class SendMessageBase : SendMessageBase<object>
{
	/// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <exception cref="ArgumentNullException"></exception>
	protected SendMessageBase(long chatId) : base(chatId)
	{
	}

	/// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <exception cref="ArgumentNullException"></exception>
	protected SendMessageBase(string chatId) : base(chatId)
	{
	}
}

/// <summary>Base object for message-sending methods arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public abstract class SendMessageBase<TChatId>
{
	/// <summary>Initialize a new instance of <see cref="SendMessageBase"/>.</summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <exception cref="ArgumentNullException"></exception>
	protected SendMessageBase(TChatId chatId)
	{
		this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
	}

	/// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public virtual TChatId ChatId { get; }
	/// <summary>
	/// Optional. Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageThreadId { get; set; }
	/// <summary>Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</summary>
	[JsonPropertyName(PropertyNames.DisableNotification)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? DisableNotification { get; set; }
	/// <summary>Optional. If the message is a reply, ID of the original message.</summary>
	[JsonPropertyName(PropertyNames.ReplyToMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? ReplyToMessageId { get; set; }
	/// <summary>Pass True, if the message should be sent even if the specified replied-to message is not found.</summary>
	[JsonPropertyName(PropertyNames.AllowSendingWithoutReply)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowSendingWithoutReply { get; set; }
	/// <summary>Protects the contents of the sent message from forwarding and saving.</summary>
	[JsonPropertyName(PropertyNames.ProtectContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? ProtectContent { get; set; }
}
