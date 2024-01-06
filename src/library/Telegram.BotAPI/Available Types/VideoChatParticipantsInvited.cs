// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents a service message about new members invited to a video chat.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class VideoChatParticipantsInvited : IEquatable<VideoChatParticipantsInvited>
{
	/// <summary>Optional. New members that were invited to the video chat.</summary>
	[JsonPropertyName(PropertyNames.Users)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User[] Users { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as VideoChatParticipantsInvited);
	}
	/// <inheritdoc/>
	public bool Equals(VideoChatParticipantsInvited? other)
	{
		return other != null &&
			   EqualityComparer<User[]>.Default.Equals(this.Users, other.Users);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return 471895467 + EqualityComparer<User[]>.Default.GetHashCode(this.Users);
	}
	/// <inheritdoc/>
	public static bool operator ==(VideoChatParticipantsInvited? left, VideoChatParticipantsInvited? right)
	{
		return EqualityComparer<VideoChatParticipantsInvited>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(VideoChatParticipantsInvited? left, VideoChatParticipantsInvited? right)
	{
		return !(left == right);
	}


}
