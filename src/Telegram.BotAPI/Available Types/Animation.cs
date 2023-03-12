// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents an animation file (GIF or H.264/MPEG-4 AVC video without sound).</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class Animation : TelegramFileBase, IThumbnail<PhotoSize>, IEquatable<Animation?>
	{
		/// <summary>Video width as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Width)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Width { get; set; }
		/// <summary>Video height as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Height)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Height { get; set; }
		/// <summary>Duration of the video in seconds as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint? Duration { get; set; }
		/// <summary>Optional. Animation thumbnail as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Thumbnail)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize? Thumbnail { get; set; }
		/// <summary>Optional. Original animation filename as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.FileName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? FileName { get; set; }
		/// <summary>Optional. MIME type of the file as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.MimeType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string? MimeType { get; set; }
		/// <summary>Optional. File size.</summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ulong? FileSize { get; set; }

		/// <inheritdoc />
		public override bool Equals(object? obj)
		{
			return this.Equals(obj as Animation);
		}

		/// <inheritdoc />
		public bool Equals(Animation? other)
		{
			return other is not null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.Width == other.Width &&
				   this.Height == other.Height &&
				   this.Duration == other.Duration &&
				   EqualityComparer<PhotoSize?>.Default.Equals(this.Thumbnail, other.Thumbnail) &&
				   this.FileName == other.FileName &&
				   this.MimeType == other.MimeType &&
				   this.FileSize == other.FileSize;
		}

		/// <inheritdoc />
		public override int GetHashCode()
		{
			int hashCode = -694909017;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize?>.Default.GetHashCode(this.Thumbnail);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.FileName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.MimeType);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			return hashCode;
		}

		/// <inheritdoc />
		public static bool operator ==(Animation? left, Animation? right)
		{
			return EqualityComparer<Animation>.Default.Equals(left!, right!);
		}

		/// <inheritdoc />
		public static bool operator !=(Animation? left, Animation? right)
		{
			return !(left == right);
		}
	}
}
