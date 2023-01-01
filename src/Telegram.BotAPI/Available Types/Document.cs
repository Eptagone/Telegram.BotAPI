// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a general file (as opposed to photos, voice messages and audio files).</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class Document : TelegramFileBase, IThumbnail<PhotoSize>, IEquatable<Document>
	{
		///<summary>Optional. Document thumbnail as defined by sender.</summary>
		[JsonPropertyName(PropertyNames.Thumb)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public PhotoSize Thumb { get; set; }
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
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as Document);
		}
		/// <inheritdoc/>
		public bool Equals(Document? other)
		{
			return other != null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   EqualityComparer<PhotoSize>.Default.Equals(this.Thumb, other.Thumb) &&
				   this.FileName == other.FileName &&
				   this.MimeType == other.MimeType &&
				   this.FileSize == other.FileSize;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -604365523;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(this.Thumb);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileName);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MimeType);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(Document? left, Document? right)
		{
#pragma warning disable CS8604 // Possible null reference argument.
			return EqualityComparer<Document>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
		}
		/// <inheritdoc/>
		public static bool operator !=(Document? left, Document? right)
		{
			return !(left == right);
		}

	}
}
