// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// EditMessageMedia method arguments.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class EditMessageMediaArgs : AttachedFilesArgsBase
{
	/// <summary>
	/// Initializes a new instance of <see cref="EditMessageMediaArgs"/> with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the message to edit</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message</param>
	public EditMessageMediaArgs(long chatId, int messageId, InputMedia media)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
		this.Media = media;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="EditMessageMediaArgs"/> with required parameters.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the message to edit</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message</param>
	public EditMessageMediaArgs(string chatId, int messageId, InputMedia media)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
		this.Media = media;
	}

	/// <summary>
	/// Initializes a new instance of <see cref="EditMessageMediaArgs"/> with required parameters.
	/// </summary>
	/// <param name="inlineMessageId">Identifier of the inline message</param>
	/// <param name="media">A JSON-serialized object for a new media content of the message</param>
	public EditMessageMediaArgs(string inlineMessageId, InputMedia media)
	{
		this.InlineMessageId = inlineMessageId;
		this.Media = media;
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
	/// A JSON-serialized object for a new media content of the message
	/// </summary>
	[JsonPropertyName(PropertyNames.Media)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputMedia Media { get; set; }
	/// <summary>
	/// A JSON-serialized object for a new inline keyboard.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
