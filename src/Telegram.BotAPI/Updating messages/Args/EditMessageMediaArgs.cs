// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Linq;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
	/// <summary>EditMessageMedia method arguments.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public class EditMessageMediaArgs : IMultipartForm
	{
		/// <summary>
		/// Initialize a new instance of <see cref="EditMessageMediaArgs"/>.
		/// </summary>
		/// <param name="media">A <see cref="InputMedia"/> object for a new media content of the message.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public EditMessageMediaArgs(InputMedia media)
		{
			this.Media = media ?? throw new ArgumentNullException(nameof(media));
		}

		/// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
		[JsonPropertyName(PropertyNames.ChatId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public object? ChatId { get; set; }
		/// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
		[JsonPropertyName(PropertyNames.MessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int? MessageId { get; set; }
		/// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
		[JsonPropertyName(PropertyNames.InlineMessageId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? InlineMessageId { get; set; }
		/// <summary>A <see cref="InputMedia"/> object for a new media content of the message.</summary>
		[JsonPropertyName(PropertyNames.Media)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMedia Media { get; }
		/// <summary>A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
		[JsonPropertyName(PropertyNames.ReplyMarkup)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InlineKeyboardMarkup? ReplyMarkup { get; set; }

		/// <inheritdoc />
		[System.Text.Json.Serialization.JsonIgnore]
		public IEnumerable<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

		bool IMultipartForm.UseMultipart() => this.AttachedFiles.Any();
	}
}
