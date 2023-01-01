// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents a link to a photo. By default, this photo will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the photo.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InlineQueryResultPhoto : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultPhoto>
	{
		/// <summary>Type of the result, must be photo.</summary>
		[JsonPropertyName(PropertyNames.Type)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public override string Type => InlineQueryResultType.Photo;
		/// <summary>A valid URL of the photo. Photo must be in jpeg format. Photo size must not exceed 5MB.</summary>
		[JsonPropertyName(PropertyNames.PhotoUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string PhotoUrl { get; set; }
		/// <summary>Optional. Title of the result.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Title { get; set; }
		/// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
		[JsonPropertyName(PropertyNames.ThumbUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string ThumbUrl { get; set; }
		/// <summary>Optional. Width of the photo.</summary>
		[JsonPropertyName(PropertyNames.PhotoWidth)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int PhotoWidth { get; set; }
		/// <summary>Optional. Height of the photo.</summary>
		[JsonPropertyName(PropertyNames.PhotoHeight)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public int PhotoHeight { get; set; }
		/// <summary>Optional. Short description of the result.</summary>
		[JsonPropertyName(PropertyNames.Description)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Description { get; set; }
		///<summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
		[JsonPropertyName(PropertyNames.Caption)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? Caption { get; set; }
		/// <summary>Optional. Content of the message to be sent instead of the photo.</summary>
		[JsonPropertyName(PropertyNames.InputMessageContent)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public InputMessageContent? InputMessageContent { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InlineQueryResultPhoto);
		}
		/// <inheritdoc/>
		public bool Equals(InlineQueryResultPhoto? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
				   this.ParseMode == other.ParseMode &&
				   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
				   this.Type == other.Type &&
				   this.PhotoUrl == other.PhotoUrl &&
				   this.Title == other.Title &&
				   this.ThumbUrl == other.ThumbUrl &&
				   this.PhotoWidth == other.PhotoWidth &&
				   this.PhotoHeight == other.PhotoHeight &&
				   this.Description == other.Description &&
				   this.Caption == other.Caption &&
				   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1395552640;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PhotoUrl);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbUrl);
			hashCode = hashCode * -1521134295 + this.PhotoWidth.GetHashCode();
			hashCode = hashCode * -1521134295 + this.PhotoHeight.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Description);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
			hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InlineQueryResultPhoto? left, InlineQueryResultPhoto? right)
		{
			return EqualityComparer<InlineQueryResultPhoto>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InlineQueryResultPhoto? left, InlineQueryResultPhoto? right)
		{
			return !(left == right);
		}

	}
}
