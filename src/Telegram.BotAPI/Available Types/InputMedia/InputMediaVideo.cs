// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a video to be sent.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputMediaVideo : InputMedia, IThumbnail<string>, IEquatable<InputMediaVideo?>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InputMediaVideo"/> class.
	/// </summary>
	/// <param name="media">File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</param>
	public InputMediaVideo(string media) : base(media)
	{
	}

	/// <summary>Type of the result, must be video.</summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type => InputMediaType.Video;
	/// <summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
	[JsonPropertyName(PropertyNames.Thumbnail)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Thumbnail { get; set; }
	/// <summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
	[JsonPropertyName(PropertyNames.Caption)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string? Caption { get; set; }
	/// <summary>Optional. Video width.</summary>
	[JsonPropertyName(PropertyNames.Width)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Width { get; set; }
	/// <summary>Optional. Video height.</summary>
	[JsonPropertyName(PropertyNames.Height)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Height { get; set; }
	/// <summary>Optional. Video duration.</summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? Duration { get; set; }
	/// <summary>Optional. Pass True, if the uploaded video is suitable for streaming.</summary>
	[JsonPropertyName(PropertyNames.SupportsStreaming)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? SupportsStreaming { get; set; }
	/// <summary>Optional. Pass True if the video needs to be covered with a spoiler animation.</summary>
	[JsonPropertyName(PropertyNames.HasSpoiler)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasSpoiler { get; set; }

	/// <inheritdoc/>
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as InputMediaVideo);
	}

	/// <inheritdoc/>
	public bool Equals(InputMediaVideo? other)
	{
		return other is not null &&
			   this.Type == other.Type &&
			   this.Media == other.Media &&
			   this.Caption == other.Caption &&
			   EqualityComparer<IEnumerable<MessageEntity>?>.Default.Equals(this.CaptionEntities, other.CaptionEntities) &&
			   this.ParseMode == other.ParseMode &&
			   this.Type == other.Type &&
			   this.Thumbnail == other.Thumbnail &&
			   this.Caption == other.Caption &&
			   this.Width == other.Width &&
			   this.Height == other.Height &&
			   this.Duration == other.Duration &&
			   this.SupportsStreaming == other.SupportsStreaming &&
			   this.HasSpoiler == other.HasSpoiler;
	}

	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1560366449;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Media);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>?>.Default.GetHashCode(this.CaptionEntities);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.ParseMode);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Thumbnail);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Caption);
		hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
		hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
		hashCode = hashCode * -1521134295 + this.SupportsStreaming.GetHashCode();
		hashCode = hashCode * -1521134295 + this.HasSpoiler.GetHashCode();
		return hashCode;
	}

	/// <inheritdoc/>
	public static bool operator ==(InputMediaVideo? left, InputMediaVideo? right)
	{
		return EqualityComparer<InputMediaVideo>.Default.Equals(left!, right!);
	}

	/// <inheritdoc/>
	public static bool operator !=(InputMediaVideo? left, InputMediaVideo? right)
	{
		return !(left == right);
	}
}
