// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents an invite link for a chat.
/// </summary>
public class ChatInviteLink
{
    /// <summary>
    /// The invite link. If the link was created by another chat administrator, then the second part of the link will be replaced with “…”.
    /// </summary>
    [JsonPropertyName(PropertyNames.InviteLink)]
    public string InviteLink { get; set; } = null!;

    /// <summary>
    /// Creator of the link
    /// </summary>
    [JsonPropertyName(PropertyNames.Creator)]
    public User Creator { get; set; } = null!;

    /// <summary>
    /// <em>True</em>, if users joining the chat via the link need to be approved by chat administrators
    /// </summary>
    [JsonPropertyName(PropertyNames.CreatesJoinRequest)]
    public bool CreatesJoinRequest { get; set; }

    /// <summary>
    /// <em>True</em>, if the link is primary
    /// </summary>
    [JsonPropertyName(PropertyNames.IsPrimary)]
    public bool IsPrimary { get; set; }

    /// <summary>
    /// <em>True</em>, if the link is revoked
    /// </summary>
    [JsonPropertyName(PropertyNames.IsRevoked)]
    public bool IsRevoked { get; set; }

    /// <summary>
    /// Optional. Invite link name
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// Optional. Point in time (Unix timestamp) when the link will expire or has been expired
    /// </summary>
    [JsonPropertyName(PropertyNames.ExpireDate)]
    public int? ExpireDate { get; set; }

    /// <summary>
    /// Optional. The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999
    /// </summary>
    [JsonPropertyName(PropertyNames.MemberLimit)]
    public int? MemberLimit { get; set; }

    /// <summary>
    /// Optional. Number of pending join requests created using this link
    /// </summary>
    [JsonPropertyName(PropertyNames.PendingJoinRequestCount)]
    public int? PendingJoinRequestCount { get; set; }
}
