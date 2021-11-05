// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Defines the basic properties of a Telegram chat.</summary>
    public interface ITelegramChat
    {
        /// <summary>Unique identifier for this chat.</summary>
        public long Id { get; set; }
        /// <summary>Type of chat, can be either “private”, “group”, “supergroup” or “channel”.</summary>
        public string Type { get; set; }
        /// <summary>Title, for supergroups, channels and group chats.</summary>
        public string Title { get; set; }
        /// <summary>Username, for private chats, supergroups and channels if available.</summary>
        public string Username { get; set; }
        /// <summary>Description, for supergroups and channel chats.</summary>
        public string Description { get; set; }
        /// <summary>Optional. Chat invite link, for supergroups and channel chats.</summary>
        public string InviteLink { get; set; }
        /// <summary>Optional. Unique identifier for the linked chat, i.e. the discussion group identifier for a channel and vice versa; for supergroups and channel chats.</summary>
        public long? LinkedChatId { get; set; }
    }
}
