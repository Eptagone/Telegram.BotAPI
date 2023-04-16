// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents changes in the status of a chat member.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ChatMemberUpdated : IEquatable<ChatMemberUpdated>
{
	/// <summary>Chat the user belongs to.</summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat Chat { get; set; }
	/// <summary>Performer of the action, which resulted in the change.</summary>
	[JsonPropertyName(PropertyNames.From)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User From { get; set; }
	/// <summary>Date the change was done in Unix time.</summary>
	[JsonPropertyName(PropertyNames.Date)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint Date { get; set; }
	/// <summary>Previous information about the chat member.</summary>
	[JsonPropertyName(PropertyNames.OldChatMember)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatMember OldChatMember { get; set; }
	/// <summary>New information about the chat member.</summary>
	[JsonPropertyName(PropertyNames.NewChatMember)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatMember NewChatMember { get; set; }
	/// <summary>Optional. Chat invite link, which was used by the user to join the chat; for joining by invite link events only.</summary>
	[JsonPropertyName(PropertyNames.InviteLink)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatInviteLink InviteLink { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ChatMemberUpdated);
	}
	/// <inheritdoc/>
	public bool Equals(ChatMemberUpdated? other)
	{
		return other != null &&
			   EqualityComparer<Chat>.Default.Equals(this.Chat, other.Chat) &&
			   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
			   this.Date == other.Date &&
			   EqualityComparer<ChatMember>.Default.Equals(this.OldChatMember, other.OldChatMember) &&
			   EqualityComparer<ChatMember>.Default.Equals(this.NewChatMember, other.NewChatMember) &&
			   EqualityComparer<ChatInviteLink>.Default.Equals(this.InviteLink, other.InviteLink);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1231267048;
		hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(this.Chat);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
		hashCode = hashCode * -1521134295 + this.Date.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<ChatMember>.Default.GetHashCode(this.OldChatMember);
		hashCode = hashCode * -1521134295 + EqualityComparer<ChatMember>.Default.GetHashCode(this.NewChatMember);
		hashCode = hashCode * -1521134295 + EqualityComparer<ChatInviteLink>.Default.GetHashCode(this.InviteLink);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(ChatMemberUpdated? left, ChatMemberUpdated? right)
	{
		return EqualityComparer<ChatMemberUpdated>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ChatMemberUpdated? left, ChatMemberUpdated? right)
	{
		return !(left == right);
	}


}