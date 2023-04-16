// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a chat.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class Chat : ITelegramChat, IEquatable<Chat?>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Chat"/> class.
	/// </summary>
	public Chat()
	{
		this.Type = null!;
	}

	/// <summary>
	/// Unique identifier for this chat. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a signed 64-bit integer or double-precision float type are safe for storing this identifier.
	/// </summary>
	[JsonPropertyName(PropertyNames.Id)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long Id { get; set; }
	/// <summary>
	/// Type of chat, can be either “private”, “group”, “supergroup” or “channel”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Type { get; set; }
	/// <summary>
	/// Optional. Title, for supergroups, channels and group chats
	/// </summary>
	[JsonPropertyName(PropertyNames.Title)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Title { get; set; }
	/// <summary>
	/// Optional. Username, for private chats, supergroups and channels if available
	/// </summary>
	[JsonPropertyName(PropertyNames.Username)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Username { get; set; }
	/// <summary>
	/// Optional. First name of the other party in a private chat
	/// </summary>
	[JsonPropertyName(PropertyNames.FirstName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? FirstName { get; set; }
	/// <summary>
	/// Optional. Last name of the other party in a private chat
	/// </summary>
	[JsonPropertyName(PropertyNames.LastName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? LastName { get; set; }
	/// <summary>
	/// Optional. True, if the supergroup chat is a forum (has topics enabled)
	/// </summary>
	[JsonPropertyName(PropertyNames.IsForum)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsForum { get; set; }
	/// <summary>
	/// Optional. Chat photo. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.Photo)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatPhoto? Photo { get; set; }
	/// <summary>
	/// Optional. If non-empty, the list of all active chat usernames; for private chats, supergroups and channels. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.ActiveUsernames)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<string>? ActiveUsernames { get; set; }
	/// <summary>
	/// Optional. Custom emoji identifier of emoji status of the other party in a private chat. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.EmojiStatusCustomEmojiId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? EmojiStatusCustomEmojiId { get; set; }
	/// <summary>
	/// Optional. Bio of the other party in a private chat. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.Bio)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Bio { get; set; }
	/// <summary>
	/// Optional. True, if privacy settings of the other party in the private chat allows to use tg://user?id=&lt;user_id&gt; links only in chats with the user. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.HasPrivateForwards)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasPrivateForwards { get; set; }
	/// <summary>
	/// Optional. True, if the privacy settings of the other party restrict sending voice and video note messages in the private chat. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.HasRestrictedVoiceAndVideoMessages)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasRestrictedVoiceAndVideoMessages { get; set; }
	/// <summary>
	/// Optional. True, if users need to join the supergroup before they can send messages. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.JoinToSendMessages)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? JoinToSendMessages { get; set; }
	/// <summary>
	/// Optional. True, if all users directly joining the supergroup need to be approved by supergroup administrators. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.JoinByRequest)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? JoinByRequest { get; set; }
	/// <summary>
	/// Optional. Description, for groups, supergroups and channel chats. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.Description)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Description { get; set; }
	/// <summary>
	/// Optional. Primary invite link, for groups, supergroups and channel chats. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.InviteLink)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? InviteLink { get; set; }
	/// <summary>
	/// Optional. The most recent pinned message (by sending date). Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.PinnedMessage)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? PinnedMessage { get; set; }
	/// <summary>
	/// Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.Permissions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatPermissions? Permissions { get; set; }
	/// <summary>
	/// Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unpriviledged user; in seconds. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.SlowModeDelay)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? SlowModeDelay { get; set; }
	/// <summary>
	/// Optional. The time after which all messages sent to the chat will be automatically deleted; in seconds. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageAutoDeleteTime)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? MessageAutoDeleteTime { get; set; }
	/// <summary>
	/// Optional. True, if aggressive anti-spam checks are enabled in the supergroup. The field is only available to chat administrators. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.HasAggressiveAntiSpamEnabled)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasAggressiveAntiSpamEnabled { get; set; }
	/// <summary>
	/// Optional. True, if non-administrators can only get the list of bots and administrators in the chat. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.HasHiddenMembers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasHiddenMembers { get; set; }
	/// <summary>
	/// Optional. True, if messages from the chat can't be forwarded to other chats. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.HasProtectedContent)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasProtectedContent { get; set; }
	/// <summary>
	/// Optional. For supergroups, name of group sticker set. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.StickerSetName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? StickerSetName { get; set; }
	/// <summary>
	/// Optional. True, if the bot can change the group sticker set. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.CanSetStickerSet)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? CanSetStickerSet { get; set; }
	/// <summary>
	/// Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats. This identifier may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.LinkedChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long? LinkedChatId { get; set; }
	/// <summary>
	/// Optional. For supergroups, the location to which the supergroup is connected. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.Location)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatLocation? Location { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as Chat);
	}
	/// <inheritdoc/>
	public bool Equals(Chat? other)
	{
		return other is not null &&
			   this.Id == other.Id &&
			   this.Type == other.Type &&
			   this.Title == other.Title &&
			   this.Username == other.Username &&
			   this.FirstName == other.FirstName &&
			   this.LastName == other.LastName &&
			   this.IsForum == other.IsForum &&
			   EqualityComparer<ChatPhoto?>.Default.Equals(this.Photo, other.Photo) &&
			   EqualityComparer<IEnumerable<string>?>.Default.Equals(this.ActiveUsernames, other.ActiveUsernames) &&
			   this.EmojiStatusCustomEmojiId == other.EmojiStatusCustomEmojiId &&
			   this.Bio == other.Bio &&
			   this.HasPrivateForwards == other.HasPrivateForwards &&
			   this.HasRestrictedVoiceAndVideoMessages == other.HasRestrictedVoiceAndVideoMessages &&
			   this.JoinToSendMessages == other.JoinToSendMessages &&
			   this.JoinByRequest == other.JoinByRequest &&
			   this.Description == other.Description &&
			   this.InviteLink == other.InviteLink &&
			   EqualityComparer<Message?>.Default.Equals(this.PinnedMessage, other.PinnedMessage) &&
			   EqualityComparer<ChatPermissions?>.Default.Equals(this.Permissions, other.Permissions) &&
			   this.SlowModeDelay == other.SlowModeDelay &&
			   this.MessageAutoDeleteTime == other.MessageAutoDeleteTime &&
			   this.HasAggressiveAntiSpamEnabled == other.HasAggressiveAntiSpamEnabled &&
			   this.HasHiddenMembers == other.HasHiddenMembers &&
			   this.HasProtectedContent == other.HasProtectedContent &&
			   this.StickerSetName == other.StickerSetName &&
			   this.CanSetStickerSet == other.CanSetStickerSet &&
			   this.LinkedChatId == other.LinkedChatId &&
			   EqualityComparer<ChatLocation?>.Default.Equals(this.Location, other.Location);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1692087815;
		hashCode = hashCode * -1521134295 + this.Id.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Type);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Title);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Username);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.FirstName);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.LastName);
		hashCode = hashCode * -1521134295 + this.IsForum.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<ChatPhoto?>.Default.GetHashCode(this.Photo);
		hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<string>?>.Default.GetHashCode(this.ActiveUsernames);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.EmojiStatusCustomEmojiId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Bio);
		hashCode = hashCode * -1521134295 + this.HasPrivateForwards.GetHashCode();
		hashCode = hashCode * -1521134295 + this.HasRestrictedVoiceAndVideoMessages.GetHashCode();
		hashCode = hashCode * -1521134295 + this.JoinToSendMessages.GetHashCode();
		hashCode = hashCode * -1521134295 + this.JoinByRequest.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Description);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.InviteLink);
		hashCode = hashCode * -1521134295 + EqualityComparer<Message?>.Default.GetHashCode(this.PinnedMessage);
		hashCode = hashCode * -1521134295 + EqualityComparer<ChatPermissions?>.Default.GetHashCode(this.Permissions);
		hashCode = hashCode * -1521134295 + this.SlowModeDelay.GetHashCode();
		hashCode = hashCode * -1521134295 + this.MessageAutoDeleteTime.GetHashCode();
		hashCode = hashCode * -1521134295 + this.HasAggressiveAntiSpamEnabled.GetHashCode();
		hashCode = hashCode * -1521134295 + this.HasHiddenMembers.GetHashCode();
		hashCode = hashCode * -1521134295 + this.HasProtectedContent.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.StickerSetName);
		hashCode = hashCode * -1521134295 + this.CanSetStickerSet.GetHashCode();
		hashCode = hashCode * -1521134295 + this.LinkedChatId.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<ChatLocation?>.Default.GetHashCode(this.Location);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(Chat? left, Chat? right)
	{
		return EqualityComparer<Chat>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(Chat? left, Chat? right)
	{
		return !(left == right);
	}

}

/// <summary>
/// Type of chat, can be either “private”, “group”, “supergroup” or “channel”. Can be either “sender” for a private chat with the inline query sender.
/// </summary>
public static class ChatType
{
	/// <summary>Private chat with the inline query sender</summary>
	public const string Sender = "sender";
	/// <summary>Private chat</summary>
	public const string Private = "private";
	/// <summary>Group chat</summary>
	public const string Group = "group";
	/// <summary>Supergroup chat</summary>
	public const string Supergroup = "supergroup";
	/// <summary>Channel chat</summary>
	public const string Channel = "channel";
}
