// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a chat member that was banned in the chat and can't return to the chat or view chat messages.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatMemberBanned : ChatMember, IEquatable<ChatMemberBanned>
{
	/// <summary>The member's status in the chat, always “kicked”.</summary>
	[JsonPropertyName(PropertyNames.Status)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Status => ChatMemberStatus.Kicked;
	/// <summary>Date when restrictions will be lifted for this user; unix time.</summary>
	[JsonPropertyName(PropertyNames.UntilDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint UntilDate { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ChatMemberBanned);
	}
	/// <inheritdoc/>
	public bool Equals(ChatMemberBanned? other)
	{
		return other != null &&
			   this.Status == other.Status &&
			   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
			   this.UntilDate == other.UntilDate;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -811308180;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
		hashCode = hashCode * -1521134295 + this.UntilDate.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ChatMemberBanned? left, ChatMemberBanned? right)
	{
		return EqualityComparer<ChatMemberBanned>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ChatMemberBanned? left, ChatMemberBanned? right)
	{
		return !(left == right);
	}

}
