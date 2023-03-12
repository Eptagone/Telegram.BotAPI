// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound) stored on the Telegram servers. By default, this animated MPEG-4 file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultCachedMpeg4Gif : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultCachedMpeg4Gif>
	{
		/// <summary>Type of the result, must be mpeg4_gif.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Mpeg4Gif;
		/// <summary>A valid file identifier for the MP4 file.</summary>
		[JsonPropertyName(PropertyNames.Mpeg4FileId)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Mpeg4FileId { get; set; }
		/// <summary>Optional. Title of the result.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Title { get; set; }
		/// <summary>Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the video animation.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent? InputMessageContent { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultCachedMpeg4Gif);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultCachedMpeg4Gif? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.ParseMode == other.ParseMode &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.Mpeg4FileId == other.Mpeg4FileId &&
				   this.Title == other.Title &&
				   this.Caption == other.Caption &&
				   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -645860403;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Mpeg4FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultCachedMpeg4Gif? left, InlineQueryResultCachedMpeg4Gif? right)
		{
			return EqualityComparer<InlineQueryResultCachedMpeg4Gif>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultCachedMpeg4Gif? left, InlineQueryResultCachedMpeg4Gif? right)
		{
			return !(left == right);
		}

	}
}
