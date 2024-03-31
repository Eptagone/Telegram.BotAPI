// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the connection of the bot with a business account.
/// </summary>
public class BusinessConnection
{
    /// <summary>
    /// Unique identifier of the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Business account user that created the business connection
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Identifier of a private chat with the user who created the business connection. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserChatId)]
    public long UserChatId { get; set; }

    /// <summary>
    /// Date the connection was established in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// True, if the bot can act on behalf of the business account in chats that were active in the last 24 hours
    /// </summary>
    [JsonPropertyName(PropertyNames.CanReply)]
    public bool CanReply { get; set; }

    /// <summary>
    /// True, if the connection is active
    /// </summary>
    [JsonPropertyName(PropertyNames.IsEnabled)]
    public bool IsEnabled { get; set; }
}
