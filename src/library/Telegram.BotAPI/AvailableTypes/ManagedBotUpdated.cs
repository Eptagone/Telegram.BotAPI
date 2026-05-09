// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the creation, token update, or owner update of a bot that is managed by the current bot.
/// </summary>
public class ManagedBotUpdated
{
    /// <summary>
    /// User that created the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Information about the bot. Token of the bot can be fetched using the method <a href="https://core.telegram.org/bots/api#getmanagedbottoken">getManagedBotToken</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Bot)]
    public User Bot { get; set; } = null!;
}
