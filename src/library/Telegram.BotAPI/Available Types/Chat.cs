// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a chat.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class Chat : ITelegramChat
{
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
	/// Optional. List of available reactions allowed in the chat. If omitted, then all emoji reactions are allowed. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.AvailableReactions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<ReactionType>? AvailableReactions { get; set; }
	/// <summary>
	/// Optional. Identifier of the accent color for the chat name and backgrounds of the chat photo, reply header, and link preview. <a href="https://core.telegram.org/bots/api#accent-colors">See accent colors</a> for more details. Returned only in getChat. Always returned in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.AccentColorId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? AccentColorId { get; set; }
	/// <summary>
	/// Optional. Custom emoji identifier of emoji chosen by the chat for the reply header and link preview background. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.BackgroundCustomEmojiId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? BackgroundCustomEmojiId { get; set; }
	/// <summary>
	/// Optional. Identifier of the accent color for the chat's profile background. <a href="https://core.telegram.org/bots/api#profile-accent-colors">See profile accent colors</a> for more details. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.ProfileAccentColorId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int? ProfileAccentColorId { get; set; }
	/// <summary>
	/// Optional. Custom emoji identifier of the emoji chosen by the chat for its profile background. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.ProfileBackgroundCustomEmojiId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ProfileBackgroundCustomEmojiId { get; set; }
	/// <summary>
	/// Optional. Custom emoji identifier of the emoji status of the chat or the other party in a private chat. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.EmojiStatusCustomEmojiId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? EmojiStatusCustomEmojiId { get; set; }
	/// <summary>
	/// Optional. Expiration date of the emoji status of the chat or the other party in a private chat, in Unix time, if any. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.EmojiStatusExpirationDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? EmojiStatusExpirationDate { get; set; }
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
	/// Optional. True, if new chat members will have access to old messages; available only to chat administrators. Returned only in getChat.
	/// </summary>
	[JsonPropertyName(PropertyNames.HasVisibleHistory)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? HasVisibleHistory { get; set; }
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
}
