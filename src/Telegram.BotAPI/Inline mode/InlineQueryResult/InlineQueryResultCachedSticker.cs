// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to a sticker stored on the Telegram servers. By default, this sticker will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the sticker.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultCachedSticker : InlineQueryResult, IEquatable<InlineQueryResultCachedSticker>
	{
		/// <summary>Type of the result, must be sticker.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Sticker;
		/// <summary>A valid file identifier of the sticker.</summary>
		[JsonPropertyName(PropertyNames.StickerFileId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string StickerFileId { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the sticker.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent InputMessageContent { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultCachedSticker);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultCachedSticker? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.Type == other.Type &&
				   this.StickerFileId == other.StickerFileId &&
				   EqualityComparer<InputMessageContent>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -680348338;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.StickerFileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultCachedSticker? left, InlineQueryResultCachedSticker? right)
		{
			return EqualityComparer<InlineQueryResultCachedSticker>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultCachedSticker? left, InlineQueryResultCachedSticker? right)
		{
			return !(left == right);
		}

	}
}
