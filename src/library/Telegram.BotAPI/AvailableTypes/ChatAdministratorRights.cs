// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents the rights of an administrator in a chat.
/// </summary>
public class ChatAdministratorRights
{
    /// <summary>
    /// <em>True</em>, if the user's presence in the chat is hidden
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnonymous)]
    public bool IsAnonymous { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report spam messages and ignore slow mode. Implied by any other administrator privilege.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageChat)]
    public bool CanManageChat { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can delete messages of other users
    /// </summary>
    [JsonPropertyName(PropertyNames.CanDeleteMessages)]
    public bool CanDeleteMessages { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can manage video chats
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageVideoChats)]
    public bool CanManageVideoChats { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can restrict, ban or unban chat members, or access supergroup statistics
    /// </summary>
    [JsonPropertyName(PropertyNames.CanRestrictMembers)]
    public bool CanRestrictMembers { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by the user)
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPromoteMembers)]
    public bool CanPromoteMembers { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to change the chat title, photo and other settings
    /// </summary>
    [JsonPropertyName(PropertyNames.CanChangeInfo)]
    public bool CanChangeInfo { get; set; }

    /// <summary>
    /// <em>True</em>, if the user is allowed to invite new users to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CanInviteUsers)]
    public bool CanInviteUsers { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can post stories to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPostStories)]
    public bool CanPostStories { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access the chat's story archive
    /// </summary>
    [JsonPropertyName(PropertyNames.CanEditStories)]
    public bool CanEditStories { get; set; }

    /// <summary>
    /// <em>True</em>, if the administrator can delete stories posted by other users
    /// </summary>
    [JsonPropertyName(PropertyNames.CanDeleteStories)]
    public bool CanDeleteStories { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the administrator can post messages in the channel, or access channel statistics; for channels only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPostMessages)]
    public bool? CanPostMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the administrator can edit messages of other users and can pin messages; for channels only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanEditMessages)]
    public bool? CanEditMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to pin messages; for groups and supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPinMessages)]
    public bool? CanPinMessages { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the user is allowed to create, rename, close, and reopen forum topics; for supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageTopics)]
    public bool? CanManageTopics { get; set; }
}
