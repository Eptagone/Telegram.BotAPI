// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents a chat photo.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatPhoto : IEquatable<ChatPhoto>
{
	/// <summary>File identifier of small (160x160) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.</summary>
	[JsonPropertyName(PropertyNames.SmallFileId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string SmallFileId { get; set; }
	/// <summary>Unique file identifier of small (160x160) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
	[JsonPropertyName(PropertyNames.SmallFileUniqueId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string SmallFileUniqueId { get; set; }
	/// <summary>File identifier of big (640x640) chat photo. This file_id can be used only for photo download and only for as long as the photo is not changed.</summary>
	[JsonPropertyName(PropertyNames.BigFileId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string BigFileId { get; set; }
	/// <summary>Unique file identifier of big (640x640) chat photo, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
	[JsonPropertyName(PropertyNames.BigFileUniqueId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string BigFileUniqueId { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ChatPhoto);
	}
	/// <inheritdoc/>
	public bool Equals(ChatPhoto? other)
	{
		return other != null &&
			   this.SmallFileId == other.SmallFileId &&
			   this.SmallFileUniqueId == other.SmallFileUniqueId &&
			   this.BigFileId == other.BigFileId &&
			   this.BigFileUniqueId == other.BigFileUniqueId;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 974474930;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.SmallFileId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.SmallFileUniqueId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.BigFileId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.BigFileUniqueId);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ChatPhoto? left, ChatPhoto? right)
	{
		return EqualityComparer<ChatPhoto>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ChatPhoto? left, ChatPhoto? right)
	{
		return !(left == right);
	}

}