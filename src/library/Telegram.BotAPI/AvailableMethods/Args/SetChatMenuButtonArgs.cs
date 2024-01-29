// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "SetChatMenuButton" method.
/// </summary>
public class SetChatMenuButtonArgs
{
    /// <summary>
    /// Unique identifier for the target private chat. If not specified, default bot's menu button will be changed
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public long? ChatId { get; set; }

    /// <summary>
    /// A JSON-serialized object for the bot's new menu button. Defaults to <see cref="MenuButtonDefault"/>
    /// </summary>
    [JsonPropertyName(PropertyNames.MenuButton)]
    public MenuButton? MenuButton { get; set; }
}
