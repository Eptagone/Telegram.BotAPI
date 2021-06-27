// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object contains information about one member of a chat. Currently, the following 6 types of chat members are supported: <br /><br />
    /// • <see cref="ChatMemberOwner"/><br />
    /// • <see cref="ChatMemberAdministrator"/><br />
    /// • <see cref="ChatMemberMember"/><br />
    /// • <see cref="ChatMemberRestricted"/><br />
    /// • <see cref="ChatMemberLeft"/><br />
    /// • <see cref="ChatMemberBanned"/><br />
    /// </summary>
    public interface IChatMember
    {
        /// <summary>The member's status in the chat.</summary>
        public string Status { get; }
        /// <summary>Information about the user.</summary>
        public User User { get; }
    }
}
