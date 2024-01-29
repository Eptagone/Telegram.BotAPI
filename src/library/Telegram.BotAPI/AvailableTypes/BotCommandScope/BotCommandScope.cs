// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents the scope to which bot commands are applied. Currently, the following 7 scopes are supported:
/// <list type="bullet">
/// <item><description><see cref="BotCommandScopeDefault"/></description></item>
/// <item><description><see cref="BotCommandScopeAllPrivateChats"/></description></item>
/// <item><description><see cref="BotCommandScopeAllGroupChats"/></description></item>
/// <item><description><see cref="BotCommandScopeAllChatAdministrators"/></description></item>
/// <item><description><see cref="BotCommandScopeChat"/></description></item>
/// <item><description><see cref="BotCommandScopeChatAdministrators"/></description></item>
/// <item><description><see cref="BotCommandScopeChatMember"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(BotCommandScopeConverter))]
public abstract class BotCommandScope
{
    /// <summary>
    /// Scope type
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
