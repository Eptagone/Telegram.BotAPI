// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>Represents a link to a page containing an embedded video player or a video file. By default, this video file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the video.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineQueryResultVideo : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultVideo>
{
	/// <summary>Type of the result, must be video.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InlineQueryResultType.Video;
	/// <summary>A valid URL for the embedded video player or video file.</summary>
	[JsonPropertyName(PropertyNames.VideoUrl)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string VideoUrl { get; set; }
	/// <summary>Mime type of the content of video url, “text/html” or “video/mp4”.</summary>
	[JsonPropertyName(PropertyNames.MimeType)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string MimeType { get; set; }
	/// <summary>URL of the thumbnail (jpeg only) for the video.</summary>
	[JsonPropertyName(PropertyNames.ThumbnailUrl)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ThumbnailUrl { get; set; }
	/// <summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Caption { get; set; }
	/// <summary>Optional. Video width.</summary>
	[JsonPropertyName(PropertyNames.VideoWidth)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? VideoWidth { get; set; }
	/// <summary>Optional. Video height.</summary>
	[JsonPropertyName(PropertyNames.VideoHeight)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? VideoHeight { get; set; }
	/// <summary>Optional. Video duration in seconds.</summary>
	[JsonPropertyName(PropertyNames.VideoDuration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? VideoDuration { get; set; }
	/// <summary>Optional. Short description of the result.</summary>
	[JsonPropertyName(PropertyNames.Description)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Description { get; set; }
	/// <summary>Optional. Content of the message to be sent instead of the video. This field is required if InlineQueryResultVideo is used to send an HTML-page as a result (e.g., a YouTube video).</summary>
	[JsonPropertyName(PropertyNames.InputMessageContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public InputMessageContent? InputMessageContent { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as InlineQueryResultVideo);
	}
	/// <inheritdoc/>
	public bool Equals(InlineQueryResultVideo? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(this.ReplyMarkup, other.ReplyMarkup) &&
			   this.ParseMode == other.ParseMode &&
			   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
			   this.Type == other.Type &&
			   this.VideoUrl == other.VideoUrl &&
			   this.MimeType == other.MimeType &&
			   this.ThumbnailUrl == other.ThumbnailUrl &&
			   this.Caption == other.Caption &&
			   this.VideoWidth == other.VideoWidth &&
			   this.VideoHeight == other.VideoHeight &&
			   this.VideoDuration == other.VideoDuration &&
			   this.Description == other.Description &&
			   EqualityComparer<InputMessageContent>.Default.Equals(this.InputMessageContent, other.InputMessageContent);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1695118391;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(this.ReplyMarkup);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.VideoUrl);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MimeType);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ThumbnailUrl);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
		hashCode = hashCode * -1521134295 + this.VideoWidth.GetHashCode();
		hashCode = hashCode * -1521134295 + this.VideoHeight.GetHashCode();
		hashCode = hashCode * -1521134295 + this.VideoDuration.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Description);
		hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(this.InputMessageContent);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineQueryResultVideo? left, InlineQueryResultVideo? right)
	{
		return EqualityComparer<InlineQueryResultVideo>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineQueryResultVideo? left, InlineQueryResultVideo? right)
	{
		return !(left == right);
	}
}
