// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Represents a chat member that owns the chat and has all administrator privileges.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatMemberOwner : ChatMember, IEquatable<ChatMemberOwner>
{
	/// <summary>The member's status in the chat, always “creator”.</summary>
	[JsonPropertyName(PropertyNames.Status)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Status => ChatMemberStatus.Creator;
	/// <summary>Custom title for this user.</summary>
	[JsonPropertyName(PropertyNames.CustomTitle)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string CustomTitle { get; set; }
	/// <summary>True, if the user's presence in the chat is hidden.</summary>
	[JsonPropertyName(PropertyNames.IsAnonymous)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool IsAnonymous { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ChatMemberOwner);
	}
	/// <inheritdoc/>
	public bool Equals(ChatMemberOwner? other)
	{
		return other != null &&
			   this.Status == other.Status &&
			   EqualityComparer<User>.Default.Equals(this.User, other.User) &&
			   this.CustomTitle == other.CustomTitle &&
			   this.IsAnonymous == other.IsAnonymous;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -947591761;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Status);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.User);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.CustomTitle);
		hashCode = hashCode * -1521134295 + this.IsAnonymous.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ChatMemberOwner? left, ChatMemberOwner? right)
	{
		return EqualityComparer<ChatMemberOwner>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ChatMemberOwner? left, ChatMemberOwner? right)
	{
		return !(left == right);
	}

}
