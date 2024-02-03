// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "EditChatInviteLink" method.
/// </summary>
public class EditChatInviteLinkArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EditChatInviteLinkArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="inviteLink">The invite link to edit</param>
    public EditChatInviteLinkArgs(long chatId, string inviteLink)
    {
        this.ChatId = chatId;
        this.InviteLink = inviteLink ?? throw new ArgumentNullException(nameof(inviteLink));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="EditChatInviteLinkArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="inviteLink">The invite link to edit</param>
    public EditChatInviteLinkArgs(string chatId, string inviteLink)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.InviteLink = inviteLink ?? throw new ArgumentNullException(nameof(inviteLink));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// The invite link to edit
    /// </summary>
    [JsonPropertyName(PropertyNames.InviteLink)]
    public string InviteLink { get; set; }

    /// <summary>
    /// Invite link name; 0-32 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// Point in time (Unix timestamp) when the link will expire
    /// </summary>
    [JsonPropertyName(PropertyNames.ExpireDate)]
    public int? ExpireDate { get; set; }

    /// <summary>
    /// The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999
    /// </summary>
    [JsonPropertyName(PropertyNames.MemberLimit)]
    public int? MemberLimit { get; set; }

    /// <summary>
    /// <em>True</em>, if users joining the chat via the link need to be approved by chat administrators. If <em>True</em>, <em>member_limit</em> can't be specified
    /// </summary>
    [JsonPropertyName(PropertyNames.CreatesJoinRequest)]
    public bool? CreatesJoinRequest { get; set; }
}
