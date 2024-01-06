// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents a voice note.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class Voice : TelegramFileBase, IEquatable<Voice>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Voice"/> class.
	/// </summary>
	public Voice()
	{
		this.MimeType = null!;
	}

	/// <summary>Duration of the audio in seconds as defined by sender.</summary>
	[JsonPropertyName(PropertyNames.Duration)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint Duration { get; set; }
	/// <summary>Optional. MIME type of the file as defined by sender.</summary>
	[JsonPropertyName(PropertyNames.MimeType)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string MimeType { get; set; }
	/// <summary>Optional. File size.</summary>
	[JsonPropertyName(PropertyNames.FileSize)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ulong FileSize { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as Voice);
	}
	/// <inheritdoc/>
	public bool Equals(Voice? other)
	{
		return other != null &&
			   this.FileId == other.FileId &&
			   this.FileUniqueId == other.FileUniqueId &&
			   this.Duration == other.Duration &&
			   this.MimeType == other.MimeType &&
			   this.FileSize == other.FileSize;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 2020017407;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.FileUniqueId);
		hashCode = hashCode * -1521134295 + this.Duration.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.MimeType);
		hashCode = hashCode * -1521134295 + this.FileSize.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(Voice? left, Voice? right)
	{
		return EqualityComparer<Voice>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(Voice? left, Voice? right)
	{
		return !(left == right);
	}

}
