// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>
	/// This object represents a <a href="https://telegram.org/blog/video-messages-and-telescope">video message </a> (available in Telegram apps as of <a href="https://telegram.org/blog/video-messages-and-telescope">v.4.0</a>).
	/// </summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class VideoNote : TelegramFileBase, IThumbnail<PhotoSize>, IEquatable<VideoNote?>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="VideoNote"/>.
		/// </summary>
		public VideoNote()
		{
			this.Thumbnail = null!;
		}

		/// <summary>Video width and height (diameter of the video message) as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Length)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Length { get; set; }
		/// <summary>Duration of the video in seconds as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Duration { get; set; }
		/// <summary>Optional. Video thumbnail.</summary>
		[JsonPropertyName(PropertyNames.Thumbnail)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize? Thumbnail { get; set; }
		/// <summary>Optional. File size.</summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ulong? FileSize { get; set; }

		/// <inheritdoc />
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as VideoNote);
		}

		/// <inheritdoc />
		public bool Equals(VideoNote? other)
		{
			return other is not null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.Length == other.Length &&
				   this.Duration == other.Duration &&
				   EqualityComparer<PhotoSize?>.Default.Equals(this.Thumbnail, other.Thumbnail) &&
				   this.FileSize == other.FileSize;
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			int hashCode = -219946490;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + this.Length.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize?>.Default.GetHashCode(this.Thumbnail);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			return hashCode;
		}

		/// <inheritdoc />
		public static bool operator ==(VideoNote? left, VideoNote? right)
		{
			return EqualityComparer<VideoNote>.Default.Equals(left!, right!);
		}

		/// <inheritdoc />
		public static bool operator !=(VideoNote? left, VideoNote? right)
		{
			return !(left == right);
		}
	}
}
