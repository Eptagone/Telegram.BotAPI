// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#botcommandscope">scope</a> of bot commands, covering all group and supergroup chats.
/// </summary>
public class BotCommandScopeAllGroupChats : BotCommandScope
{
    /// <summary>
    /// Scope type, must be <em>all_group_chats</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "all_group_chats";
}
