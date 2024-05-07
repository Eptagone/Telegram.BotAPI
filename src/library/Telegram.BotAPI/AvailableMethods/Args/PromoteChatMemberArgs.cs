// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Represents the arguments of the "PromoteChatMember" method.
/// </summary>
public class PromoteChatMemberArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PromoteChatMemberArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    public PromoteChatMemberArgs(long chatId, long userId)
    {
        this.ChatId = chatId;
        this.UserId = userId;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="PromoteChatMemberArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    public PromoteChatMemberArgs(string chatId, long userId)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.UserId = userId;
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier of the target user
    /// </summary>
    [JsonPropertyName(PropertyNames.UserId)]
    public long UserId { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator's presence in the chat is hidden
    /// </summary>
    [JsonPropertyName(PropertyNames.IsAnonymous)]
    public bool? IsAnonymous { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report spam messages and ignore slow mode. Implied by any other administrator privilege.
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageChat)]
    public bool? CanManageChat { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can delete messages of other users
    /// </summary>
    [JsonPropertyName(PropertyNames.CanDeleteMessages)]
    public bool? CanDeleteMessages { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can manage video chats
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageVideoChats)]
    public bool? CanManageVideoChats { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can restrict, ban or unban chat members, or access supergroup statistics
    /// </summary>
    [JsonPropertyName(PropertyNames.CanRestrictMembers)]
    public bool? CanRestrictMembers { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him)
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPromoteMembers)]
    public bool? CanPromoteMembers { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can change chat title, photo and other settings
    /// </summary>
    [JsonPropertyName(PropertyNames.CanChangeInfo)]
    public bool? CanChangeInfo { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can invite new users to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CanInviteUsers)]
    public bool? CanInviteUsers { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can post stories to the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPostStories)]
    public bool? CanPostStories { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access the chat's story archive
    /// </summary>
    [JsonPropertyName(PropertyNames.CanEditStories)]
    public bool? CanEditStories { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can delete stories posted by other users
    /// </summary>
    [JsonPropertyName(PropertyNames.CanDeleteStories)]
    public bool? CanDeleteStories { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can post messages in the channel, or access channel statistics; for channels only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPostMessages)]
    public bool? CanPostMessages { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can edit messages of other users and can pin messages; for channels only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanEditMessages)]
    public bool? CanEditMessages { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the administrator can pin messages; for supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanPinMessages)]
    public bool? CanPinMessages { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the user is allowed to create, rename, close, and reopen forum topics; for supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.CanManageTopics)]
    public bool? CanManageTopics { get; set; }
}
