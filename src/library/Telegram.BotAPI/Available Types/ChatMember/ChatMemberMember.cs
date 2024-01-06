// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a chat member that has no additional privileges or restrictions.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatMemberMember : ChatMember, IEquatable<ChatMemberMember>
{
	/// <summary>The member's status in the chat, always “member”.</summary>
	[JsonPropertyName(PropertyNames.Status)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Status => ChatMemberStatus.Member;
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ChatMemberMember);
	}
	/// <inheritdoc/>
	public bool Equals(ChatMemberMember? other)
	{
		return other != null &&
			   this.Status == other.Status &&
			   EqualityComparer<User>.Default.Equals(this.User, other.User);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -2144010887;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ChatMemberMember? left, ChatMemberMember? right)
	{
		return EqualityComparer<ChatMemberMember>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ChatMemberMember? left, ChatMemberMember? right)
	{
		return !(left == right);
	}

}
