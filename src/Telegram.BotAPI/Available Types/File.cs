// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
	/// <summary>This object represents a file ready to be downloaded. The file can be downloaded via the link https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;. It is guaranteed that the link will be valid for at least 1 hour. When the link expires, a new one can be requested by calling getFile.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class File : TelegramFileBase, IEquatable<File>
	{
		/// <summary>Optional. File size, if known.</summary>
		[JsonPropertyName(PropertyNames.FileSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ulong FileSize { get; set; }
		/// <summary>Optional. File path. Use https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt; to get the file.</summary>
		[JsonPropertyName(PropertyNames.FilePath)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string FilePath { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as File);
		}
		/// <inheritdoc/>
		public bool Equals(File? other)
		{
			return other != null &&
				   this.FileId == other.FileId &&
				   this.FileUniqueId == other.FileUniqueId &&
				   this.FileSize == other.FileSize &&
				   this.FilePath == other.FilePath;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -1737632191;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
			hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FilePath);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(File? left, File? right)
		{
			return EqualityComparer<File>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(File? left, File? right)
		{
			return !(left == right);
		}

	}
}
