// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Chat : ITelegramChat, IEquatable<Chat>
    {
        /// <summary>Unique identifier for this chat.</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Id { get; set; }
        /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        /// <summary>Optional. Title, for supergroups, channels and group chats.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Optional. Username, for private chats, supergroups and channels if available.</summary>
        [JsonPropertyName(PropertyNames.Username)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }
        /// <summary>Optional. First name of the other party in a private chat.</summary>
        [JsonPropertyName(PropertyNames.FirstName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }
        /// <summary>Optional. Last name of the other party in a private chat.</summary>
        [JsonPropertyName(PropertyNames.LastName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }
        /// <summary>Optional. Chat photo. Returned only in getChat..</summary>
        [JsonPropertyName(PropertyNames.Photo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPhoto Photo { get; set; }
        /// <summary>Optional. Bio of the other party in a private chat. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.Bio)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Bio { get; set; }
        /// <summary>Optional. True, if privacy settings of the other party in the private chat allows to use <i>tg://user?id=&lt;user_id&gt;</i> links only in chats with the user. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.HasPrivateForwards)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HasPrivateForwards { get; set; }
        /// <summary>Optional. Description, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Optional. Chat invite link, for supergroups and channel chats. Each administrator in a chat generates their own invite links, so the bot must first generate the link using exportChatInviteLink. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.InviteLink)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InviteLink { get; set; }
        /// <summary>Optional. Pinned message, for supergroups and channel chats. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.PinnedMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Message PinnedMessage { get; set; }
        /// <summary>Optional. Default chat member permissions, for groups and supergroups. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.Permissions)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. For supergroups, the minimum allowed delay between consecutive messages sent by each unpriviledged user. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.SlowModeDelay)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint SlowModeDelay { get; set; }
        /// <summary>Optional. The time after which all messages sent to the chat will be automatically deleted; in seconds. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.MessageAutoDeleteTime)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint MessageAutoDeleteTime { get; set; }
        /// <summary>Optional. True, if messages from the chat can't be forwarded to other chats. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.HasProtectedContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HasProtectedContent { get; set; }
        /// <summary>Optional. For supergroups, name of group sticker set. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.StickerSetName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StickerSetName { get; set; }
        /// <summary>Optional. True, if the bot can change the group sticker set. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.CanSetStickerSet)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanSetStickerSet { get; set; }
        /// <summary>Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats. This identifier may be greater than 32 bits and some programming languages may have difficulty/silent defects in interpreting it. But it is smaller than 52 bits, so a signed 64 bit integer or double-precision float type are safe for storing this identifier. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.LinkedChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long? LinkedChatId { get; set; }
        /// <summary>Optional. For supergroups, the location to which the supergroup is connected. Returned only in getChat.</summary>
        [JsonPropertyName(PropertyNames.Location)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatLocation Location { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Chat);
        }

        public bool Equals(Chat other)
        {
            return other != null &&
                   Id == other.Id &&
                   Type == other.Type &&
                   Title == other.Title &&
                   Username == other.Username &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   EqualityComparer<ChatPhoto>.Default.Equals(Photo, other.Photo) &&
                   Bio == other.Bio &&
                   HasPrivateForwards == other.HasPrivateForwards &&
                   Description == other.Description &&
                   InviteLink == other.InviteLink &&
                   EqualityComparer<Message>.Default.Equals(PinnedMessage, other.PinnedMessage) &&
                   EqualityComparer<ChatPermissions>.Default.Equals(Permissions, other.Permissions) &&
                   SlowModeDelay == other.SlowModeDelay &&
                   MessageAutoDeleteTime == other.MessageAutoDeleteTime &&
                   HasProtectedContent == other.HasProtectedContent &&
                   StickerSetName == other.StickerSetName &&
                   CanSetStickerSet == other.CanSetStickerSet &&
                   LinkedChatId == other.LinkedChatId &&
                   EqualityComparer<ChatLocation>.Default.Equals(Location, other.Location);
        }

        public override int GetHashCode()
        {
            int hashCode = -1929137122;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<ChatPhoto>.Default.GetHashCode(Photo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Bio);
            hashCode = hashCode * -1521134295 + HasPrivateForwards.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InviteLink);
            hashCode = hashCode * -1521134295 + EqualityComparer<Message>.Default.GetHashCode(PinnedMessage);
            hashCode = hashCode * -1521134295 + EqualityComparer<ChatPermissions>.Default.GetHashCode(Permissions);
            hashCode = hashCode * -1521134295 + SlowModeDelay.GetHashCode();
            hashCode = hashCode * -1521134295 + MessageAutoDeleteTime.GetHashCode();
            hashCode = hashCode * -1521134295 + HasProtectedContent.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StickerSetName);
            hashCode = hashCode * -1521134295 + CanSetStickerSet.GetHashCode();
            hashCode = hashCode * -1521134295 + LinkedChatId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<ChatLocation>.Default.GetHashCode(Location);
            return hashCode;
        }

        public static bool operator ==(Chat left, Chat right)
        {
            return EqualityComparer<Chat>.Default.Equals(left, right);
        }

        public static bool operator !=(Chat left, Chat right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
    /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”. Can be either “sender” for a private chat with the inline query sender.</summary>
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
}