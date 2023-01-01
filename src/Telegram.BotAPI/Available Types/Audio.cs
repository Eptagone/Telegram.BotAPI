// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents an audio file to be treated as music by the Telegram clients.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class Audio : TelegramFileBase, IThumbnail<PhotoSize>, IEquatable<Audio>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Audio"/> class.
		/// </summary>
		public Audio()
		{
			this.Performer = null!;
			this.Title = null!;
			this.FileName = null!;
			this.MimeType = null!;
			this.Thumb = null!;
		}

		///<summary>Duration of the audio in seconds as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Duration)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Duration { get; set; }
		///<summary>Optional. Performer of the audio as defined by sender or by audio tags.</summary>
		[JsonPropertyName(PropertyNames.Performer)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Performer { get; set; }
		///<summary>Optional. Title of the audio as defined by sender or by audio tags.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Title { get; set; }
		///<summary>Optional. Original filename as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.FileName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FileName { get; set; }
		///<summary>Optional. MIME type of the file as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.MimeType)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string MimeType { get; set; }
		///<summary>Optional. File size.</summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ulong FileSize { get; set; }
		///<summary>Optional. Thumbnail of the album cover to which the music file belongs.</summary>
		[JsonPropertyName(PropertyNames.Thumb)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize Thumb { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Audio);
		}
		/// <inheritdoc/>
		public bool Equals(Audio? other)
		{
			return other != null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.Duration == other.Duration &&
				   this.Performer == other.Performer &&
				   this.Title == other.Title &&
				   this.FileName == other.FileName &&
				   this.MimeType == other.MimeType &&
				   this.FileSize == other.FileSize &&
				   EqualityComparer<PhotoSize>.Default.Equals(this.Thumb, other.Thumb);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1371790424;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Performer);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MimeType);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(this.Thumb);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(Audio? left, Audio? right)
		{
			return EqualityComparer<Audio>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(Audio? left, Audio? right)
		{
			return !(left == right);
		}

	}
}
