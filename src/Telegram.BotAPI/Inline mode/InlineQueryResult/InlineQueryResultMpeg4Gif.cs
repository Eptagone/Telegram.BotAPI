// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound). By default, this animated MPEG-4 file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultMpeg4Gif : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultMpeg4Gif>
{
	/// <summary>Type of the result, must be mpeg4_gif.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Mpeg4Gif;
	/// <summary>A valid URL for the MP4 file. File size must not exceed 1MB.</summary>
	[JsonPropertyName(PropertyNames.Mpeg4Url)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Mpeg4Url { get; set; }
	/// <summary>Optional. Video width.</summary>
	[JsonPropertyName(PropertyNames.Mpeg4Width)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Mpeg4Width { get; set; }
	/// <summary>Optional. Video height.</summary>
	[JsonPropertyName(PropertyNames.Mpeg4Height)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Mpeg4Height { get; set; }
	/// <summary>Optional. Video height.</summary>
	[JsonPropertyName(PropertyNames.Mpeg4Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Mpeg4Duration { get; set; }
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
		return this.Equals(obj as InlineQueryResultMpeg4Gif);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultMpeg4Gif? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.ParseMode == other.ParseMode &&
			   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
			   this.Type == other.Type &&
			   this.Mpeg4Url == other.Mpeg4Url &&
			   this.Mpeg4Width == other.Mpeg4Width &&
			   this.Mpeg4Height == other.Mpeg4Height &&
			   this.Mpeg4Duration == other.Mpeg4Duration &&
			   this.ThumbnailUrl == other.ThumbnailUrl &&
			   this.ThumbnailMimeType == other.ThumbnailMimeType &&
			   this.Title == other.Title &&
			   this.Caption == other.Caption &&
			   EqualityComparer<InputMessageContent?>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -572359803;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Mpeg4Url);
		hashCode = hashCode * -1521134295 + this.Mpeg4Width.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Mpeg4Height.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Mpeg4Duration.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbnailUrl);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ThumbnailMimeType);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Title);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent?>.Default.GetHashCode(this.InputMessageContent);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultMpeg4Gif? left, InlineQueryResultMpeg4Gif? right)
	{
		return EqualityComparer<InlineQueryResultMpeg4Gif>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultMpeg4Gif? left, InlineQueryResultMpeg4Gif? right)
	{
		return !(left == right);
	}

}
