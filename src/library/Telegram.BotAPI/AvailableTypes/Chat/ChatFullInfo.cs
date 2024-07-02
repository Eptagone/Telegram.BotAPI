// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains full information about a chat.
/// </summary>
public class ChatFullInfo : Chat
{
    /// <summary>
    /// Identifier of the accent color for the chat name and backgrounds of the chat photo, reply header, and link preview. See <a href="https://core.telegram.org/bots/api#accent-colors">accent colors</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.AccentColorId)]
    public int AccentColorId { get; set; }

    /// <summary>
    /// The maximum number of reactions that can be set on a message in the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.MaxReactionCount)]
    public int MaxReactionCount { get; set; }

    /// <summary>
    /// Optional. Chat photo
    /// </summary>
    [JsonPropertyName(PropertyNames.Photo)]
    public ChatPhoto? Photo { get; set; }

    /// <summary>
    /// Optional. If non-empty, the list of all <a href="https://telegram.org/blog/topics-in-groups-collectible-usernames#collectible-usernames">active chat usernames</a>; for private chats, supergroups and channels
    /// </summary>
    [JsonPropertyName(PropertyNames.ActiveUsernames)]
    public IEnumerable<string>? ActiveUsernames { get; set; }

    /// <summary>
    /// Optional. For private chats, the date of birth of the user
    /// </summary>
    [JsonPropertyName(PropertyNames.Birthdate)]
    public Birthdate? Birthdate { get; set; }

    /// <summary>
    /// Optional. For private chats with business accounts, the intro of the business
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessIntro)]
    public BusinessIntro? BusinessIntro { get; set; }

    /// <summary>
    /// Optional. For private chats with business accounts, the location of the business
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessLocation)]
    public BusinessLocation? BusinessLocation { get; set; }

    /// <summary>
    /// Optional. For private chats with business accounts, the opening hours of the business
    /// </summary>
    [JsonPropertyName(PropertyNames.BusinessOpeningHours)]
    public BusinessOpeningHours? BusinessOpeningHours { get; set; }

    /// <summary>
    /// Optional. For private chats, the personal channel of the user
    /// </summary>
    [JsonPropertyName(PropertyNames.PersonalChat)]
    public Chat? PersonalChat { get; set; }

    /// <summary>
    /// Optional. List of available reactions allowed in the chat. If omitted, then all <a href="https://core.telegram.org/bots/api#reactiontypeemoji">emoji reactions</a> are allowed.
    /// </summary>
    [JsonPropertyName(PropertyNames.AvailableReactions)]
    public IEnumerable<ReactionType>? AvailableReactions { get; set; }

    /// <summary>
    /// Optional. Custom emoji identifier of the emoji chosen by the chat for the reply header and link preview background
    /// </summary>
    [JsonPropertyName(PropertyNames.BackgroundCustomEmojiId)]
    public string? BackgroundCustomEmojiId { get; set; }

    /// <summary>
    /// Optional. Identifier of the accent color for the chat's profile background. See <a href="https://core.telegram.org/bots/api#profile-accent-colors">profile accent colors</a> for more details.
    /// </summary>
    [JsonPropertyName(PropertyNames.ProfileAccentColorId)]
    public int? ProfileAccentColorId { get; set; }

    /// <summary>
    /// Optional. Custom emoji identifier of the emoji chosen by the chat for its profile background
    /// </summary>
    [JsonPropertyName(PropertyNames.ProfileBackgroundCustomEmojiId)]
    public string? ProfileBackgroundCustomEmojiId { get; set; }

    /// <summary>
    /// Optional. Custom emoji identifier of the emoji status of the chat or the other party in a private chat
    /// </summary>
    [JsonPropertyName(PropertyNames.EmojiStatusCustomEmojiId)]
    public string? EmojiStatusCustomEmojiId { get; set; }

    /// <summary>
    /// Optional. Expiration date of the emoji status of the chat or the other party in a private chat, in Unix time, if any
    /// </summary>
    [JsonPropertyName(PropertyNames.EmojiStatusExpirationDate)]
    public int? EmojiStatusExpirationDate { get; set; }

    /// <summary>
    /// Optional. Bio of the other party in a private chat
    /// </summary>
    [JsonPropertyName(PropertyNames.Bio)]
    public string? Bio { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if privacy settings of the other party in the private chat allows to use <em>tg://user?id=&lt;user_id&gt;</em> links only in chats with the user
    /// </summary>
    [JsonPropertyName(PropertyNames.HasPrivateForwards)]
    public bool? HasPrivateForwards { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the privacy settings of the other party restrict sending voice and video note messages in the private chat
    /// </summary>
    [JsonPropertyName(PropertyNames.HasRestrictedVoiceAndVideoMessages)]
    public bool? HasRestrictedVoiceAndVideoMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if users need to join the supergroup before they can send messages
    /// </summary>
    [JsonPropertyName(PropertyNames.JoinToSendMessages)]
    public bool? JoinToSendMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if all users directly joining the supergroup without using an invite link need to be approved by supergroup administrators
    /// </summary>
    [JsonPropertyName(PropertyNames.JoinByRequest)]
    public bool? JoinByRequest { get; set; }

    /// <summary>
    /// Optional. Description, for groups, supergroups and channel chats
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string? Description { get; set; }

    /// <summary>
    /// Optional. Primary invite link, for groups, supergroups and channel chats
    /// </summary>
    [JsonPropertyName(PropertyNames.InviteLink)]
    public string? InviteLink { get; set; }

    /// <summary>
    /// Optional. The most recent pinned message (by sending date)
    /// </summary>
    [JsonPropertyName(PropertyNames.PinnedMessage)]
    public Message? PinnedMessage { get; set; }

    /// <summary>
    /// Optional. Default chat member permissions, for groups and supergroups
    /// </summary>
    [JsonPropertyName(PropertyNames.Permissions)]
    public ChatPermissions? Permissions { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if paid media messages can be sent or forwarded to the channel chat. The field is available only for channel chats.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSendPaidMedia)]
    public bool? CanSendPaidMedia { get; set; }

    /// <summary>
    /// Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unprivileged user; in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.SlowModeDelay)]
    public int? SlowModeDelay { get; set; }

    /// <summary>
    /// Optional. For supergroups, the minimum number of boosts that a non-administrator user needs to add in order to ignore slow mode and chat permissions
    /// </summary>
    [JsonPropertyName(PropertyNames.UnrestrictBoostCount)]
    public int? UnrestrictBoostCount { get; set; }

    /// <summary>
    /// Optional. The time after which all messages sent to the chat will be automatically deleted; in seconds
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageAutoDeleteTime)]
    public int? MessageAutoDeleteTime { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if aggressive anti-spam checks are enabled in the supergroup. The field is only available to chat administrators.
    /// </summary>
    [JsonPropertyName(PropertyNames.HasAggressiveAntiSpamEnabled)]
    public bool? HasAggressiveAntiSpamEnabled { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if non-administrators can only get the list of bots and administrators in the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.HasHiddenMembers)]
    public bool? HasHiddenMembers { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if messages from the chat can't be forwarded to other chats
    /// </summary>
    [JsonPropertyName(PropertyNames.HasProtectedContent)]
    public bool? HasProtectedContent { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if new chat members will have access to old messages; available only to chat administrators
    /// </summary>
    [JsonPropertyName(PropertyNames.HasVisibleHistory)]
    public bool? HasVisibleHistory { get; set; }

    /// <summary>
    /// Optional. For supergroups, name of the group sticker set
    /// </summary>
    [JsonPropertyName(PropertyNames.StickerSetName)]
    public string? StickerSetName { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the bot can change the group sticker set
    /// </summary>
    [JsonPropertyName(PropertyNames.CanSetStickerSet)]
    public bool? CanSetStickerSet { get; set; }

    /// <summary>
    /// Optional. For supergroups, the name of the group's custom emoji sticker set. Custom emoji from this set can be used by all users and bots in the group.
    /// </summary>
    [JsonPropertyName(PropertyNames.CustomEmojiStickerSetName)]
    public string? CustomEmojiStickerSetName { get; set; }

    /// <summary>
    /// Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats. This identifier may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.LinkedChatId)]
    public long? LinkedChatId { get; set; }

    /// <summary>
    /// Optional. For supergroups, the location to which the supergroup is connected
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public ChatLocation? Location { get; set; }
}
