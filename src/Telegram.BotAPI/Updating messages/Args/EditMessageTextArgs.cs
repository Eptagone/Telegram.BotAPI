// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
	/// <summary>EditMessage method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class EditMessageTextArgs : IFormattableMessage
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="EditMessageTextArgs"/> class.
		/// </summary>
		/// <param name="text">New text of the message.</param>
		public EditMessageTextArgs(string text)
		{
			this.Text = text ?? throw new ArgumentNullException(nameof(text));
		}

		/// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object? ChatId { get; set; }
		/// <summary>Required if inline_message_id is not specified. Identifier of the message to edit.</summary>
		[JsonPropertyName(PropertyNames.MessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int? MessageId { get; set; }
		/// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
		[JsonPropertyName(PropertyNames.InlineMessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? InlineMessageId { get; set; }
		/// <summary>New text of the message.</summary>
		[JsonPropertyName(PropertyNames.Text)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Text { get; }
		/// <summary>Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
		[JsonPropertyName(PropertyNames.ParseMode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ParseMode { get; set; }
		/// <summary>List of special entities that appear in message text, which can be specified instead of parse_mode.</summary>
		[JsonPropertyName(PropertyNames.Entities)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<MessageEntity>? Entities { get; set; }
		/// <summary>Disables link previews for links in this message</summary>
		[JsonPropertyName(PropertyNames.DisableWebPagePreview)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool? DisableWebPagePreview { get; set; }
		/// <summary>A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard.</summary>
		[JsonPropertyName(PropertyNames.ReplyMarkup)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InlineKeyboardMarkup? ReplyMarkup { get; set; }
	}
}
