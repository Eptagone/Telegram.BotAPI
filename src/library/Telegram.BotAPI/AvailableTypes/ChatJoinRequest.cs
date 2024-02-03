// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a join request sent to a chat.
/// </summary>
public class ChatJoinRequest
{
    /// <summary>
    /// Chat to which the request was sent
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// User that sent the join request
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Identifier of a private chat with the user who sent the join request. This number may have more than 32 significant bits and some programming languages may have difficulty/silent defects in interpreting it. But it has at most 52 significant bits, so a 64-bit integer or double-precision float type are safe for storing this identifier. The bot can use this identifier for 5 minutes to send messages until the join request is processed, assuming no other administrator contacted the user.
    /// </summary>
    [JsonPropertyName(PropertyNames.UserChatId)]
    public long UserChatId { get; set; }

    /// <summary>
    /// Date the request was sent in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// Optional. Bio of the user.
    /// </summary>
    [JsonPropertyName(PropertyNames.Bio)]
    public string? Bio { get; set; }

    /// <summary>
    /// Optional. Chat invite link that was used by the user to send the join request
    /// </summary>
    [JsonPropertyName(PropertyNames.InviteLink)]
    public ChatInviteLink? InviteLink { get; set; }
}
