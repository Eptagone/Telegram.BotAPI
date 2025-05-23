// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#botcommandscope">scope</a> of bot commands, covering all private chats.
/// </summary>
public class BotCommandScopeAllPrivateChats : BotCommandScope
{
    /// <summary>
    /// Scope type, must be <em>all_private_chats</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "all_private_chats";
}
