// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents one size of a photo or a file / sticker thumbnail.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class PhotoSize : TelegramFileBase, IEquatable<PhotoSize>
	{
		///<summary>Photo width.</summary>
		[JsonPropertyName(PropertyNames.Width)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Width { get; set; }
		///<summary>Photo height.</summary>
		[JsonPropertyName(PropertyNames.Height)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint Height { get; set; }
		///<summary>Optional. File size.</summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint FileSize { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as PhotoSize);
		}
		/// <inheritdoc/>
		public bool Equals(PhotoSize? other)
		{
			return other != null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.Width == other.Width &&
				   this.Height == other.Height &&
				   this.FileSize == other.FileSize;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 1709852582;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + this.Width.GetHashCode();
			hashCode = hashCode * -1521134295 + this.Height.GetHashCode();
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(PhotoSize? left, PhotoSize? right)
		{
			return EqualityComparer<PhotoSize>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(PhotoSize? left, PhotoSize? right)
		{
			return !(left == right);
		}

	}
}
