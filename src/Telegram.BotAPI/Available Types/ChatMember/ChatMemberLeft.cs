// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a chat member that isn't currently a member of the chat, but may join it themselves.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatMemberLeft : ChatMember, IEquatable<ChatMemberLeft>
{
	/// <summary>The member's status in the chat, always “left”.</summary>
	[JsonPropertyName(PropertyNames.Status)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Status => ChatMemberStatus.Left;
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ChatMemberLeft);
	}
	/// <inheritdoc/>
	public bool Equals(ChatMemberLeft? other)
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
	public static bool operator ==(ChatMemberLeft? left, ChatMemberLeft? right)
	{
		return EqualityComparer<ChatMemberLeft>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ChatMemberLeft? left, ChatMemberLeft? right)
	{
		return !(left == right);
	}

}
