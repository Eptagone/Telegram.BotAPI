// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents the <a href="https://core.telegram.org/bots/api#botcommandscope">scope</a> of bot commands, covering a specific member of a group or supergroup chat.
/// </summary>
public class BotCommandScopeChatMember : BotCommandScope
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommandScopeChatMember"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    public BotCommandScopeChatMember(long chatId, long userId)
    {
        this.ChatId = chatId;
        this.UserId = userId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BotCommandScopeChatMember"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    public BotCommandScopeChatMember(string chatId, long userId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.UserId = userId;
    }

    /// <summary>
    /// Scope type, must be <em>chat_member</em>
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "chat_member";

    /// <summary>
    /// Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier of the target user
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }
}
