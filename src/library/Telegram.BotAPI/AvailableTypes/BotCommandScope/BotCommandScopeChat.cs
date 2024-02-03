// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#botcommandscope">scope</a> of bot commands, covering a specific chat.
/// </summary>
public class BotCommandScopeChat : BotCommandScope
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommandScopeChat"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    public BotCommandScopeChat(long chatId)
    {
        this.ChatId = chatId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommandScopeChat"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    public BotCommandScopeChat(string chatId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
    }

    /// <summary>
    /// Scope type, must be <em>chat</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "chat";

    /// <summary>
    /// Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }
}
