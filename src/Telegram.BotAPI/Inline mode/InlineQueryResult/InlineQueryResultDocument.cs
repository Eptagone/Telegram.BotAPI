// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to a file. By default, this file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the file. Currently, only .PDF and .ZIP files can be sent using this method.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultDocument : InlineQueryResultWithEntities, ICaption, IExternalThumbnail, IEquatable<InlineQueryResultDocument>
	{
		/// <summary>Type of the result, must be document.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Document;
		/// <summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>A valid URL for the file.</summary>
		[JsonPropertyName(PropertyNames.DocumentUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string DocumentUrl { get; set; }
		/// <summary>Mime type of the content of the file, either “application/pdf” or “application/zip”.</summary>
		[JsonPropertyName(PropertyNames.MimeType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string MimeType { get; set; }
		/// <summary>Optional. Short description of the result.</summary>
		[JsonPropertyName(PropertyNames.Description)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Description { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the file.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent? InputMessageContent { get; set; }
		/// <summary>Optional. URL of the thumbnail (jpeg only) for the file.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? ThumbnailUrl { get; set; }
		/// <summary>Optional. Thumbnail width.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailWidth)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ThumbnailWidth { get; set; }
		/// <summary>Optional. Thumbnail height.</summary>
		[JsonPropertyName(PropertyNames.ThumbnailHeight)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? ThumbnailHeight { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultDocument);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultDocument? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.ParseMode == other.ParseMode &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.Caption == other.Caption &&
				   this.DocumentUrl == other.DocumentUrl &&
				   this.MimeType == other.MimeType &&
				   this.Description == other.Description &&
				   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent) &&
				   this.ThumbnailUrl == other.ThumbnailUrl &&
				   this.ThumbnailWidth == other.ThumbnailWidth &&
				   this.ThumbnailHeight == other.ThumbnailHeight;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -238500675;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.DocumentUrl);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MimeType);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Description);
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ThumbnailUrl);
			hashCode = hashCode * -1521134295 + this.ThumbnailWidth.GetHashCode();
			hashCode = hashCode * -1521134295 + this.ThumbnailHeight.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultDocument? left, InlineQueryResultDocument? right)
		{
			return EqualityComparer<InlineQueryResultDocument>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultDocument? left, InlineQueryResultDocument? right)
		{
			return !(left == right);
		}

	}
}
