// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a menu button, which opens the bot's list of commands.
/// </summary>
public class MenuButtonCommands : MenuButton
{
    /// <summary>
    /// Type of the button, must be <em>commands</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "commands";
}
