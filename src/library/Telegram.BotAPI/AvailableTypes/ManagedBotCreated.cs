// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the bot that was created to be managed by the current bot.
/// </summary>
public class ManagedBotCreated
{
    /// <summary>
    /// Information about the bot. The bot's token can be fetched using the method <a href="https://core.telegram.org/bots/api#getmanagedbottoken">getManagedBotToken</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Bot)]
    public User Bot { get; set; } = null!;
}
