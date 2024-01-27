// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>EditMessageReplyMarkup method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class EditMessageReplyMarkupArgs
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageReplyMarkupArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the message to edit</param>
	public EditMessageReplyMarkupArgs(long chatId, int messageId)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageReplyMarkupArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the message to edit</param>
	public EditMessageReplyMarkupArgs(string chatId, int messageId)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageReplyMarkupArgs"/> class.
	/// </summary>
	/// <param name="inlineMessageId">Identifier of the inline message</param>
	public EditMessageReplyMarkupArgs(string inlineMessageId)
	{
		this.InlineMessageId = inlineMessageId;
	}

	/// <summary>
	/// Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? ChatId { get; }
	/// <summary>
	/// Required if inline_message_id is not specified. Identifier of the message to edit
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? MessageId { get; }
	/// <summary>
	/// Required if chat_id and message_id are not specified. Identifier of the inline message
	/// </summary>
	[JsonPropertyName(PropertyNames.InlineMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? InlineMessageId { get; }
	/// <summary>
	/// A JSON-serialized object for an inline keyboard.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
