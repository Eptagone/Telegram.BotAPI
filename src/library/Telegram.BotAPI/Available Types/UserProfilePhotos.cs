// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represent a user's profile pictures.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class UserProfilePhotos : IEquatable<UserProfilePhotos>
{
	/// <summary>Total number of profile pictures the target user has.</summary>
	[JsonPropertyName(PropertyNames.TotalCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint TotalCount { get; set; }
	/// <summary>Requested profile pictures (in up to 4 sizes each).</summary>
	[JsonPropertyName(PropertyNames.Photos)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public PhotoSize[][] Photos { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as UserProfilePhotos);
	}
	/// <inheritdoc/>
	public bool Equals(UserProfilePhotos? other)
	{
		return other != null &&
			   this.TotalCount == other.TotalCount &&
			   EqualityComparer<PhotoSize[][]>.Default.Equals(this.Photos, other.Photos);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -391454100;
		hashCode = hashCode * -1521134295 + this.TotalCount.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize[][]>.Default.GetHashCode(this.Photos);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(UserProfilePhotos? left, UserProfilePhotos? right)
	{
		return EqualityComparer<UserProfilePhotos>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(UserProfilePhotos? left, UserProfilePhotos? right)
	{
		return !(left == right);
	}

}
