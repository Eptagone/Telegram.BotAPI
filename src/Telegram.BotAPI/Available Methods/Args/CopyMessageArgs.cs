// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.AvailableMethods;

/// <summary>CopyMessage method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class CopyMessageArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage
{
	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(long chatId, long fromChatId, int messageId) : base(chatId)
	{
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}
	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(string chatId, long fromChatId, int messageId) : base(chatId)
	{
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}
	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(long chatId, string fromChatId, int messageId) : base(chatId)
	{
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}
	/// <summary>
	/// Initialize a new instance of <see cref="CopyMessageArgs"/>.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
	/// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
	public CopyMessageArgs(string chatId, string fromChatId, int messageId) : base(chatId)
	{
		this.FromChatId = fromChatId;
		this.MessageId = messageId;
	}

	/// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername).</summary>
	[JsonPropertyName(PropertyNames.FromChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object FromChatId { get; }
	/// <summary>Message identifier in the chat specified in from_chat_id.</summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int MessageId { get; }
	/// <summary>New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Caption { get; set; }
	/// <summary>List of special entities that appear in the new caption, which can be specified instead of parse_mode.</summary>
	[JsonPropertyName(PropertyNames.CaptionEntities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
	/// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
	[JsonPropertyName(PropertyNames.ParseMode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ParseMode { get; set; }
}
