// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a video file.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class Video : TelegramFileBase, IThumbnail<PhotoSize>, IEquatable<Video>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Video"/> class.
		/// </summary>
		public Video()
		{
			this.Thumb = null!;
			this.FileName = null!;
			this.MimeType = null!;
		}

		///<summary>Video width as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Width)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Width { get; set; }
		///<summary>Video height as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Height)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Height { get; set; }
		///<summary>Duration of the video in seconds as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Duration { get; set; }
		///<summary>Optional. Video thumbnail.</summary>
		[JsonPropertyName(PropertyNames.Thumb)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize Thumb { get; set; }
		///<summary>Optional. Original filename as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.FileName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FileName { get; set; }
		///<summary>Optional. Mime type of a file as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.MimeType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string MimeType { get; set; }
		///<summary>Optional. File size.</summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ulong FileSize { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Video);
		}
		/// <inheritdoc/>
		public bool Equals(Video? other)
		{
			return other != null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.Width == other.Width &&
				   this.Height == other.Height &&
				   this.Duration == other.Duration &&
				   EqualityComparer<PhotoSize>.Default.Equals(this.Thumb, other.Thumb) &&
				   this.FileName == other.FileName &&
				   this.MimeType == other.MimeType &&
				   this.FileSize == other.FileSize;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -313957149;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(this.Thumb);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MimeType);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(Video? left, Video? right)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			return EqualityComparer<Video>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
		}
		/// <inheritdoc/>
		public static bool operator !=(Video? left, Video? right)
		{
			return !(left == right);
		}

	}
}
