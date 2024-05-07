// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass <em>False</em> for all boolean parameters to demote a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "PromoteChatMember" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool PromoteChatMember(this ITelegramBotClient client, PromoteChatMemberArgs args) =>
        client.PromoteChatMemberAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass <em>False</em> for all boolean parameters to demote a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "PromoteChatMember" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> PromoteChatMemberAsync(this ITelegramBotClient client, PromoteChatMemberArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.PromoteChatMember, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass <em>False</em> for all boolean parameters to demote a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="isAnonymous">Pass <em>True</em> if the administrator's presence in the chat is hidden</param>
    /// <param name="canManageChat">Pass <em>True</em> if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report spam messages and ignore slow mode. Implied by any other administrator privilege.</param>
    /// <param name="canDeleteMessages">Pass <em>True</em> if the administrator can delete messages of other users</param>
    /// <param name="canManageVideoChats">Pass <em>True</em> if the administrator can manage video chats</param>
    /// <param name="canRestrictMembers">Pass <em>True</em> if the administrator can restrict, ban or unban chat members, or access supergroup statistics</param>
    /// <param name="canPromoteMembers">Pass <em>True</em> if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him)</param>
    /// <param name="canChangeInfo">Pass <em>True</em> if the administrator can change chat title, photo and other settings</param>
    /// <param name="canInviteUsers">Pass <em>True</em> if the administrator can invite new users to the chat</param>
    /// <param name="canPostStories">Pass <em>True</em> if the administrator can post stories to the chat</param>
    /// <param name="canEditStories">Pass <em>True</em> if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access the chat's story archive</param>
    /// <param name="canDeleteStories">Pass <em>True</em> if the administrator can delete stories posted by other users</param>
    /// <param name="canPostMessages">Pass <em>True</em> if the administrator can post messages in the channel, or access channel statistics; for channels only</param>
    /// <param name="canEditMessages">Pass <em>True</em> if the administrator can edit messages of other users and can pin messages; for channels only</param>
    /// <param name="canPinMessages">Pass <em>True</em> if the administrator can pin messages; for supergroups only</param>
    /// <param name="canManageTopics">Pass <em>True</em> if the user is allowed to create, rename, close, and reopen forum topics; for supergroups only</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool PromoteChatMember(this ITelegramBotClient client, long chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canDeleteMessages = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canPinMessages = null, bool? canManageTopics = null) =>
        client.PromoteChatMemberAsync(chatId, userId, isAnonymous, canManageChat, canDeleteMessages, canManageVideoChats, canRestrictMembers, canPromoteMembers, canChangeInfo, canInviteUsers, canPostStories, canEditStories, canDeleteStories, canPostMessages, canEditMessages, canPinMessages, canManageTopics).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass <em>False</em> for all boolean parameters to demote a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="isAnonymous">Pass <em>True</em> if the administrator's presence in the chat is hidden</param>
    /// <param name="canManageChat">Pass <em>True</em> if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report spam messages and ignore slow mode. Implied by any other administrator privilege.</param>
    /// <param name="canDeleteMessages">Pass <em>True</em> if the administrator can delete messages of other users</param>
    /// <param name="canManageVideoChats">Pass <em>True</em> if the administrator can manage video chats</param>
    /// <param name="canRestrictMembers">Pass <em>True</em> if the administrator can restrict, ban or unban chat members, or access supergroup statistics</param>
    /// <param name="canPromoteMembers">Pass <em>True</em> if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him)</param>
    /// <param name="canChangeInfo">Pass <em>True</em> if the administrator can change chat title, photo and other settings</param>
    /// <param name="canInviteUsers">Pass <em>True</em> if the administrator can invite new users to the chat</param>
    /// <param name="canPostStories">Pass <em>True</em> if the administrator can post stories to the chat</param>
    /// <param name="canEditStories">Pass <em>True</em> if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access the chat's story archive</param>
    /// <param name="canDeleteStories">Pass <em>True</em> if the administrator can delete stories posted by other users</param>
    /// <param name="canPostMessages">Pass <em>True</em> if the administrator can post messages in the channel, or access channel statistics; for channels only</param>
    /// <param name="canEditMessages">Pass <em>True</em> if the administrator can edit messages of other users and can pin messages; for channels only</param>
    /// <param name="canPinMessages">Pass <em>True</em> if the administrator can pin messages; for supergroups only</param>
    /// <param name="canManageTopics">Pass <em>True</em> if the user is allowed to create, rename, close, and reopen forum topics; for supergroups only</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> PromoteChatMemberAsync(this ITelegramBotClient client, long chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canDeleteMessages = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canPinMessages = null, bool? canManageTopics = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.UserId, userId }
        };
        if (isAnonymous is not null)
        {
            args.Add(PropertyNames.IsAnonymous, isAnonymous);
        }
        if (canManageChat is not null)
        {
            args.Add(PropertyNames.CanManageChat, canManageChat);
        }
        if (canDeleteMessages is not null)
        {
            args.Add(PropertyNames.CanDeleteMessages, canDeleteMessages);
        }
        if (canManageVideoChats is not null)
        {
            args.Add(PropertyNames.CanManageVideoChats, canManageVideoChats);
        }
        if (canRestrictMembers is not null)
        {
            args.Add(PropertyNames.CanRestrictMembers, canRestrictMembers);
        }
        if (canPromoteMembers is not null)
        {
            args.Add(PropertyNames.CanPromoteMembers, canPromoteMembers);
        }
        if (canChangeInfo is not null)
        {
            args.Add(PropertyNames.CanChangeInfo, canChangeInfo);
        }
        if (canInviteUsers is not null)
        {
            args.Add(PropertyNames.CanInviteUsers, canInviteUsers);
        }
        if (canPostStories is not null)
        {
            args.Add(PropertyNames.CanPostStories, canPostStories);
        }
        if (canEditStories is not null)
        {
            args.Add(PropertyNames.CanEditStories, canEditStories);
        }
        if (canDeleteStories is not null)
        {
            args.Add(PropertyNames.CanDeleteStories, canDeleteStories);
        }
        if (canPostMessages is not null)
        {
            args.Add(PropertyNames.CanPostMessages, canPostMessages);
        }
        if (canEditMessages is not null)
        {
            args.Add(PropertyNames.CanEditMessages, canEditMessages);
        }
        if (canPinMessages is not null)
        {
            args.Add(PropertyNames.CanPinMessages, canPinMessages);
        }
        if (canManageTopics is not null)
        {
            args.Add(PropertyNames.CanManageTopics, canManageTopics);
        }

        return client.CallMethodAsync<bool>(MethodNames.PromoteChatMember, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass <em>False</em> for all boolean parameters to demote a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="isAnonymous">Pass <em>True</em> if the administrator's presence in the chat is hidden</param>
    /// <param name="canManageChat">Pass <em>True</em> if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report spam messages and ignore slow mode. Implied by any other administrator privilege.</param>
    /// <param name="canDeleteMessages">Pass <em>True</em> if the administrator can delete messages of other users</param>
    /// <param name="canManageVideoChats">Pass <em>True</em> if the administrator can manage video chats</param>
    /// <param name="canRestrictMembers">Pass <em>True</em> if the administrator can restrict, ban or unban chat members, or access supergroup statistics</param>
    /// <param name="canPromoteMembers">Pass <em>True</em> if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him)</param>
    /// <param name="canChangeInfo">Pass <em>True</em> if the administrator can change chat title, photo and other settings</param>
    /// <param name="canInviteUsers">Pass <em>True</em> if the administrator can invite new users to the chat</param>
    /// <param name="canPostStories">Pass <em>True</em> if the administrator can post stories to the chat</param>
    /// <param name="canEditStories">Pass <em>True</em> if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access the chat's story archive</param>
    /// <param name="canDeleteStories">Pass <em>True</em> if the administrator can delete stories posted by other users</param>
    /// <param name="canPostMessages">Pass <em>True</em> if the administrator can post messages in the channel, or access channel statistics; for channels only</param>
    /// <param name="canEditMessages">Pass <em>True</em> if the administrator can edit messages of other users and can pin messages; for channels only</param>
    /// <param name="canPinMessages">Pass <em>True</em> if the administrator can pin messages; for supergroups only</param>
    /// <param name="canManageTopics">Pass <em>True</em> if the user is allowed to create, rename, close, and reopen forum topics; for supergroups only</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool PromoteChatMember(this ITelegramBotClient client, string chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canDeleteMessages = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canPinMessages = null, bool? canManageTopics = null) =>
        client.PromoteChatMemberAsync(chatId, userId, isAnonymous, canManageChat, canDeleteMessages, canManageVideoChats, canRestrictMembers, canPromoteMembers, canChangeInfo, canInviteUsers, canPostStories, canEditStories, canDeleteStories, canPostMessages, canEditMessages, canPinMessages, canManageTopics).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass <em>False</em> for all boolean parameters to demote a user. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="isAnonymous">Pass <em>True</em> if the administrator's presence in the chat is hidden</param>
    /// <param name="canManageChat">Pass <em>True</em> if the administrator can access the chat event log, get boost list, see hidden supergroup and channel members, report spam messages and ignore slow mode. Implied by any other administrator privilege.</param>
    /// <param name="canDeleteMessages">Pass <em>True</em> if the administrator can delete messages of other users</param>
    /// <param name="canManageVideoChats">Pass <em>True</em> if the administrator can manage video chats</param>
    /// <param name="canRestrictMembers">Pass <em>True</em> if the administrator can restrict, ban or unban chat members, or access supergroup statistics</param>
    /// <param name="canPromoteMembers">Pass <em>True</em> if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him)</param>
    /// <param name="canChangeInfo">Pass <em>True</em> if the administrator can change chat title, photo and other settings</param>
    /// <param name="canInviteUsers">Pass <em>True</em> if the administrator can invite new users to the chat</param>
    /// <param name="canPostStories">Pass <em>True</em> if the administrator can post stories to the chat</param>
    /// <param name="canEditStories">Pass <em>True</em> if the administrator can edit stories posted by other users, post stories to the chat page, pin chat stories, and access the chat's story archive</param>
    /// <param name="canDeleteStories">Pass <em>True</em> if the administrator can delete stories posted by other users</param>
    /// <param name="canPostMessages">Pass <em>True</em> if the administrator can post messages in the channel, or access channel statistics; for channels only</param>
    /// <param name="canEditMessages">Pass <em>True</em> if the administrator can edit messages of other users and can pin messages; for channels only</param>
    /// <param name="canPinMessages">Pass <em>True</em> if the administrator can pin messages; for supergroups only</param>
    /// <param name="canManageTopics">Pass <em>True</em> if the user is allowed to create, rename, close, and reopen forum topics; for supergroups only</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> PromoteChatMemberAsync(this ITelegramBotClient client, string chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canDeleteMessages = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canPinMessages = null, bool? canManageTopics = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.UserId, userId }
        };
        if (isAnonymous is not null)
        {
            args.Add(PropertyNames.IsAnonymous, isAnonymous);
        }
        if (canManageChat is not null)
        {
            args.Add(PropertyNames.CanManageChat, canManageChat);
        }
        if (canDeleteMessages is not null)
        {
            args.Add(PropertyNames.CanDeleteMessages, canDeleteMessages);
        }
        if (canManageVideoChats is not null)
        {
            args.Add(PropertyNames.CanManageVideoChats, canManageVideoChats);
        }
        if (canRestrictMembers is not null)
        {
            args.Add(PropertyNames.CanRestrictMembers, canRestrictMembers);
        }
        if (canPromoteMembers is not null)
        {
            args.Add(PropertyNames.CanPromoteMembers, canPromoteMembers);
        }
        if (canChangeInfo is not null)
        {
            args.Add(PropertyNames.CanChangeInfo, canChangeInfo);
        }
        if (canInviteUsers is not null)
        {
            args.Add(PropertyNames.CanInviteUsers, canInviteUsers);
        }
        if (canPostStories is not null)
        {
            args.Add(PropertyNames.CanPostStories, canPostStories);
        }
        if (canEditStories is not null)
        {
            args.Add(PropertyNames.CanEditStories, canEditStories);
        }
        if (canDeleteStories is not null)
        {
            args.Add(PropertyNames.CanDeleteStories, canDeleteStories);
        }
        if (canPostMessages is not null)
        {
            args.Add(PropertyNames.CanPostMessages, canPostMessages);
        }
        if (canEditMessages is not null)
        {
            args.Add(PropertyNames.CanEditMessages, canEditMessages);
        }
        if (canPinMessages is not null)
        {
            args.Add(PropertyNames.CanPinMessages, canPinMessages);
        }
        if (canManageTopics is not null)
        {
            args.Add(PropertyNames.CanManageTopics, canManageTopics);
        }

        return client.CallMethodAsync<bool>(MethodNames.PromoteChatMember, args, cancellationToken);
    }
}
