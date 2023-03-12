// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to an animated GIF file. By default, this animated GIF file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultGif : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultGif>
	{
		/// <summary>Type of the result, must be gif.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Gif;
		/// <summary>A valid URL for the GIF file. File size must not exceed 1MB.</summary>
		[JsonPropertyName(PropertyNames.GifUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string GifUrl { get; set; }
		/// <summary>Optional. Width of the GIF.</summary>
		[JsonPropertyName(PropertyNames.GifWidth)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? GifWidth { get; set; }
		/// <summary>Optional. Height of the GIF.</summary>
		[JsonPropertyName(PropertyNames.GifHeight)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? GifHeight { get; set; }
		/// <summary>Optional. Duration of the GIF.</summary>
		[JsonPropertyName(PropertyNames.GifDuration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? GifDuration { get; set; }
		/// <summary>URL of the static (JPEG or GIF) or animated (MPEG4) thumbnail for the result.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string ThumbnailUrl { get; set; }
		/// <summary>Optional. MIME type of the thumbnail, must be one of “image/jpeg”, “image/gif”, or “video/mp4”. Defaults to “image/jpeg”.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailMimeType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ThumbnailMimeType { get; set; }
		/// <summary>Optional. Title of the result.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Title { get; set; }
		/// <summary>Optional. Caption of the GIF file to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent? InputMessageContent { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultGif);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultGif? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.ParseMode == other.ParseMode &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.GifUrl == other.GifUrl &&
				   this.GifWidth == other.GifWidth &&
				   this.GifHeight == other.GifHeight &&
				   this.GifDuration == other.GifDuration &&
				   this.ThumbnailUrl == other.ThumbnailUrl &&
				   this.ThumbnailMimeType == other.ThumbnailMimeType &&
				   this.Title == other.Title &&
				   this.Caption == other.Caption &&
				   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1113146679;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.GifUrl);
			hashCode = hashCode * -1521134295 + EqualityComparer<uint?>.Default.GetHashCode(this.GifWidth);
			hashCode = hashCode * -1521134295 + EqualityComparer<uint?>.Default.GetHashCode(this.GifHeight);
			hashCode = hashCode * -1521134295 + EqualityComparer<uint?>.Default.GetHashCode(this.GifDuration);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbnailUrl);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ThumbnailMimeType);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultGif? left, InlineQueryResultGif? right)
		{
			return EqualityComparer<InlineQueryResultGif>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultGif? left, InlineQueryResultGif? right)
		{
			return !(left == right);
		}

	}
}
