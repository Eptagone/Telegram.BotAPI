// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>EditMessage method arguments.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class EditMessageTextArgs
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageTextArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the message to edit</param>
	/// <param name="text">New text of the message.</param>
	public EditMessageTextArgs(long chatId, int messageId, string text)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
		this.Text = text ?? throw new ArgumentNullException(nameof(text));
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageTextArgs"/> class.
	/// </summary>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
	/// <param name="messageId">Identifier of the message to edit</param>
	/// <param name="text">New text of the message.</param>
	public EditMessageTextArgs(string chatId, int messageId, string text)
	{
		this.ChatId = chatId;
		this.MessageId = messageId;
		this.Text = text ?? throw new ArgumentNullException(nameof(text));
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="EditMessageTextArgs"/> class.
	/// </summary>
	/// <param name="inlineMessageId">Identifier of the inline message</param>
	/// <param name="text">New text of the message.</param>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public EditMessageTextArgs(string inlineMessageId, string text)
	{
		this.InlineMessageId = inlineMessageId;
		this.Text = text ?? throw new ArgumentNullException(nameof(text));
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
	public long? MessageId { get; }
	/// <summary>
	/// Required if chat_id and message_id are not specified. Identifier of the inline message
	/// </summary>
	[JsonPropertyName(PropertyNames.InlineMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? InlineMessageId { get; }
	/// <summary>
	/// New text of the message, 1-4096 characters after entities parsing
	/// </summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text { get; set; }
	/// <summary>
	/// Mode for parsing entities in the message text. See formatting options for more details.
	/// </summary>
	[JsonPropertyName(PropertyNames.ParseMode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ParseMode { get; set; }
	/// <summary>
	/// A JSON-serialized list of special entities that appear in message text, which can be specified instead of parse_mode
	/// </summary>
	[JsonPropertyName(PropertyNames.Entities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? Entities { get; set; }
	/// <summary>
	/// Link preview generation options for the message
	/// </summary>
	[JsonPropertyName(PropertyNames.LinkPreviewOptions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public LinkPreviewOptions? LinkPreviewOptions { get; set; }
	/// <summary>
	/// A JSON-serialized object for an inline keyboard.
	/// </summary>
	[JsonPropertyName(PropertyNames.ReplyMarkup)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
