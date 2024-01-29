// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents the default <a href="https://core.telegram.org/bots/api#botcommandscope">scope</a> of bot commands. Default commands are used if no commands with a <a href="https://core.telegram.org/bots/api#determining-list-of-commands">narrower scope</a> are specified for the user.
/// </summary>
public class BotCommandScopeDefault : BotCommandScope
{
    /// <summary>
    /// Scope type, must be <em>default</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "default";
}
