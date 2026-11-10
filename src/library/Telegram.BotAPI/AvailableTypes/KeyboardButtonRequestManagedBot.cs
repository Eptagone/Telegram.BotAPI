// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object defines the parameters for the creation of a managed bot. Information about the created bot will be shared with the bot using the update <em>managed_bot</em> and a <see cref="Message"/> with the field <em>managed_bot_created</em>.
/// </summary>
public class KeyboardButtonRequestManagedBot
{
    /// <summary>
    /// Signed 32-bit identifier of the request. Must be unique within the message.
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestId)]
    public int RequestId { get; set; }

    /// <summary>
    /// Optional. Suggested name for the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedName)]
    public string? SuggestedName { get; set; }

    /// <summary>
    /// Optional. Suggested username for the bot. The username must end with “bot”. If the user creating the bot has a Telegram Premium subscription, then the username can also end with “agent”, “ai”, “app”, “game”, or “gay”; in this case, the username will be assigned to the bot as a secondary username, and a regular username ending with “bot” will be assigned to the bot automatically.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedUsername)]
    public string? SuggestedUsername { get; set; }
}
