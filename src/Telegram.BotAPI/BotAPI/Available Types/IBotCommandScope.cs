// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents the scope to which bot commands are applied. Currently, the following 7 scopes are supported: <br /><br />
    /// • <see cref="BotCommandScopeDefault"/><br />
    /// • <see cref="BotCommandScopeAllPrivateChats"/><br />
    /// • <see cref="BotCommandScopeAllGroupChats"/><br />
    /// • <see cref="BotCommandScopeAllChatAdministrators"/><br />
    /// • <see cref="BotCommandScopeChat"/><br />
    /// • <see cref="BotCommandScopeChatAdministrators"/><br />
    /// • <see cref="BotCommandScopeChatMember"/><br />
    /// </summary>
    public interface IBotCommandScope
    {
        /// <summary>Scope type</summary>
        public string Type { get; }
    }
}
