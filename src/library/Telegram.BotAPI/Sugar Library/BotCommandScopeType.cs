// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Available types of <see cref="BotCommandScope"/>.
/// </summary>
public static class BotCommandScopeType
{
    /// <summary>
    /// All chat administrators. Represents the scope of bot commands, covering all group and supergroup chat administrators.
    /// </summary>
    public const string AllChatAdministrators = "all_chat_administrators";

    /// <summary>
    /// All group chats. Represents the scope of bot commands, covering all group and supergroup chats.
    /// </summary>
    public const string AllGroupChats = "all_group_chats";

    /// <summary>
    /// All private chats. Represents the scope of bot commands, covering all private chats.
    /// </summary>
    public const string AllPrivateChats = "all_private_chats";

    /// <summary>
    /// Chat. Represents the scope of bot commands, covering a specific chat.
    /// </summary>
    public const string Chat = PropertyNames.Chat;

    /// <summary>
    /// Chat administrators. Represents the scope of bot commands, covering all administrators of a specific group or supergroup chat.
    /// </summary>
    public const string ChatAdministrators = "chat_administrators";

    /// <summary>
    /// Chat member. Represents the scope of bot commands, covering a specific member of a group or supergroup chat.
    /// </summary>
    public const string ChatMember = PropertyNames.ChatMember;

    /// <summary>
    /// Default. Represents the default scope of bot commands. Default commands are used if no commands with a <a href="https://core.telegram.org/bots/api#determining-list-of-commands">narrower scope</a> are specified for the user.
    /// </summary>
    public const string Default = "default";
}
