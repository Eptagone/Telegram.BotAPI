// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.UpdatingMessages
{
	/// <summary>EditMessageCaption method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class EditMessageCaptionArgs : ICaption, IFormattableMessage
	{
		/// <summary>
		/// Initialize a new instance of <see cref="EditMessageCaptionArgs"/>.
		/// </summary>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="messageId">Identifier of the message to edit.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public EditMessageCaptionArgs(long chatId, int messageId)
		{
			this.ChatId = chatId;
			this.MessageId = messageId;
		}

		/// <summary>
		/// Initialize a new instance of <see cref="EditMessageCaptionArgs"/>.
		/// </summary>
		/// <param name="chatId"></param>
		/// <param name="messageId">Identifier of the message to edit.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public EditMessageCaptionArgs(string chatId, int messageId)
		{
			this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
			this.MessageId = messageId;
		}
		/// <summary>
		/// Initialize a new instance of <see cref="EditMessageCaptionArgs"/>.
		/// </summary>
		/// <param name="inlineMessageId">Identifier of the inline message.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public EditMessageCaptionArgs(string inlineMessageId)
		{
			this.InlineMessageId = inlineMessageId ?? throw new ArgumentNullException(nameof(inlineMessageId));
		}


		///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object? ChatId { get; }
		///<summary>Required if inline_message_id is not specified. Identifier of the message to edit.</summary>
		[JsonPropertyName(PropertyNames.MessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int? MessageId { get; }
		///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
		[JsonPropertyName(PropertyNames.InlineMessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? InlineMessageId { get; }
		///<summary>New caption of the message.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		///<summary>Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
		[JsonPropertyName(PropertyNames.ParseMode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ParseMode { get; set; }
		///<summary>List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
		[JsonPropertyName(PropertyNames.CaptionEntities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
		///<summary>A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard.</summary>
		[JsonPropertyName(PropertyNames.ReplyMarkup)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InlineKeyboardMarkup? ReplyMarkup { get; set; }
	}
}
