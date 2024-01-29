// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the bot's menu button in a private chat. It should be one of
/// If a menu button other than <see cref="MenuButtonDefault"/> is set for a private chat, then it is applied in the chat. Otherwise the default menu button is applied. By default, the menu button opens the list of bot commands.
/// <list type="bullet">
/// <item><description><see cref="MenuButtonCommands"/></description></item>
/// <item><description><see cref="MenuButtonWebApp"/></description></item>
/// <item><description><see cref="MenuButtonDefault"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(MenuButtonConverter))]
public abstract class MenuButton
{
    /// <summary>
    /// Type of the button
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
