// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods;

public static partial class AvailableMethodsExtensions
{
	/// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool PromoteChatMember(this ITelegramBotClient bot, PromoteChatMemberArgs args)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		return bot.CallMethod<bool>(MethodNames.PromoteChatMember, args);
	}

	/// <summary>Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate admin rights. Pass False for all boolean parameters to demote a user. Returns True on success.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> PromoteChatMemberAsync(this ITelegramBotClient bot, PromoteChatMemberArgs args, CancellationToken cancellationToken = default)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args == default)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<bool>(MethodNames.PromoteChatMember, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass False for all boolean parameters to demote a user. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="isAnonymous">Pass True if the administrator's presence in the chat is hidden.</param>
	/// <param name="canManageChat">Pass True if the administrator can access the chat event log, chat statistics, boost list in channels, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege.</param>
	/// <param name="canPostMessages">Pass True if the administrator can post messages in the channel; channels only.</param>
	/// <param name="canEditMessages">Pass True if the administrator can edit messages of other users and can pin messages; channels only.</param>
	/// <param name="canDeleteMessages">Pass True if the administrator can delete messages of other users.</param>
	/// <param name="canPostStories">Pass True if the administrator can post stories in the channel; channels only.</param>
	/// <param name="canEditStories">Pass True if the administrator can edit stories posted by other users; channels only.</param>
	/// <param name="canDeleteStories">Pass True if the administrator can delete stories posted by other users; channels only.</param>
	/// <param name="canManageVideoChats">Pass True if the administrator can manage video chats.</param>
	/// <param name="canRestrictMembers">Pass True if the administrator can restrict, ban or unban chat members.</param>
	/// <param name="canPromoteMembers">Pass True if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
	/// <param name="canChangeInfo">Pass True if the administrator can change chat title, photo and other settings.</param>
	/// <param name="canInviteUsers">Pass True if the administrator can invite new users to the chat.</param>
	/// <param name="canPinMessages">Pass True if the administrator can pin messages, supergroups only.</param>
	/// <param name="canManageTopics">Pass True if the user is allowed to create, rename, close, and reopen forum topics, supergroups only.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool PromoteChatMember(this ITelegramBotClient api, long chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canDeleteMessages = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPinMessages = null, bool? canManageTopics = null)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		if (isAnonymous is not null)
		{
			json.WriteBoolean(PropertyNames.IsAnonymous, (bool)isAnonymous);
		}
		if (canManageChat is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageChat, (bool)canManageChat);
		}
		if (canPostMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostMessages, (bool)canPostMessages);
		}
		if (canEditMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditMessages, (bool)canEditMessages);
		}
		if (canDeleteMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteMessages, (bool)canDeleteMessages);
		}
		if (canPostStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostStories, (bool)canPostStories);
		}
		if (canEditStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditStories, (bool)canEditStories);
		}
		if (canDeleteStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteStories, (bool)canDeleteStories);
		}
		if (canManageVideoChats is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageVideoChats, (bool)canManageVideoChats);
		}
		if (canRestrictMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanRestrictMembers, (bool)canRestrictMembers);
		}
		if (canPromoteMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanPromoteMembers, (bool)canPromoteMembers);
		}
		if (canChangeInfo is not null)
		{
			json.WriteBoolean(PropertyNames.CanChangeInfo, (bool)canChangeInfo);
		}
		if (canInviteUsers is not null)
		{
			json.WriteBoolean(PropertyNames.CanInviteUsers, (bool)canInviteUsers);
		}
		if (canPinMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPinMessages, (bool)canPinMessages);
		}
		if (canManageTopics is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageTopics, (bool)canManageTopics);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.PromoteChatMember, stream);
	}

	/// <summary>
	/// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass False for all boolean parameters to demote a user. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="isAnonymous">Pass True if the administrator's presence in the chat is hidden.</param>
	/// <param name="canManageChat">Pass True if the administrator can access the chat event log, chat statistics, boost list in channels, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege.</param>
	/// <param name="canPostMessages">Pass True if the administrator can post messages in the channel; channels only.</param>
	/// <param name="canEditMessages">Pass True if the administrator can edit messages of other users and can pin messages; channels only.</param>
	/// <param name="canDeleteMessages">Pass True if the administrator can delete messages of other users.</param>
	/// <param name="canPostStories">Pass True if the administrator can post stories in the channel; channels only.</param>
	/// <param name="canEditStories">Pass True if the administrator can edit stories posted by other users; channels only.</param>
	/// <param name="canDeleteStories">Pass True if the administrator can delete stories posted by other users; channels only.</param>
	/// <param name="canManageVideoChats">Pass True if the administrator can manage video chats.</param>
	/// <param name="canRestrictMembers">Pass True if the administrator can restrict, ban or unban chat members.</param>
	/// <param name="canPromoteMembers">Pass True if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
	/// <param name="canChangeInfo">Pass True if the administrator can change chat title, photo and other settings.</param>
	/// <param name="canInviteUsers">Pass True if the administrator can invite new users to the chat.</param>
	/// <param name="canPinMessages">Pass True if the administrator can pin messages, supergroups only.</param>
	/// <param name="canManageTopics">Pass True if the user is allowed to create, rename, close, and reopen forum topics, supergroups only.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool PromoteChatMember(this ITelegramBotClient api, string chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canDeleteMessages = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPinMessages = null, bool? canManageTopics = null)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		if (isAnonymous is not null)
		{
			json.WriteBoolean(PropertyNames.IsAnonymous, (bool)isAnonymous);
		}
		if (canManageChat is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageChat, (bool)canManageChat);
		}
		if (canPostMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostMessages, (bool)canPostMessages);
		}
		if (canEditMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditMessages, (bool)canEditMessages);
		}
		if (canDeleteMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteMessages, (bool)canDeleteMessages);
		}
		if (canPostStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostStories, (bool)canPostStories);
		}
		if (canEditStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditStories, (bool)canEditStories);
		}
		if (canDeleteStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteStories, (bool)canDeleteStories);
		}
		if (canManageVideoChats is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageVideoChats, (bool)canManageVideoChats);
		}
		if (canRestrictMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanRestrictMembers, (bool)canRestrictMembers);
		}
		if (canPromoteMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanPromoteMembers, (bool)canPromoteMembers);
		}
		if (canChangeInfo is not null)
		{
			json.WriteBoolean(PropertyNames.CanChangeInfo, (bool)canChangeInfo);
		}
		if (canInviteUsers is not null)
		{
			json.WriteBoolean(PropertyNames.CanInviteUsers, (bool)canInviteUsers);
		}
		if (canPinMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPinMessages, (bool)canPinMessages);
		}
		if (canManageTopics is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageTopics, (bool)canManageTopics);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return api.CallMethod<bool>(MethodNames.PromoteChatMember, stream);
	}

	/// <summary>
	/// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass False for all boolean parameters to demote a user. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="isAnonymous">Pass True if the administrator's presence in the chat is hidden.</param>
	/// <param name="canManageChat">Pass True if the administrator can access the chat event log, chat statistics, boost list in channels, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege.</param>
	/// <param name="canPostMessages">Pass True if the administrator can post messages in the channel; channels only.</param>
	/// <param name="canEditMessages">Pass True if the administrator can edit messages of other users and can pin messages; channels only.</param>
	/// <param name="canDeleteMessages">Pass True if the administrator can delete messages of other users.</param>
	/// <param name="canPostStories">Pass True if the administrator can post stories in the channel; channels only.</param>
	/// <param name="canEditStories">Pass True if the administrator can edit stories posted by other users; channels only.</param>
	/// <param name="canDeleteStories">Pass True if the administrator can delete stories posted by other users; channels only.</param>
	/// <param name="canManageVideoChats">Pass True if the administrator can manage video chats.</param>
	/// <param name="canRestrictMembers">Pass True if the administrator can restrict, ban or unban chat members.</param>
	/// <param name="canPromoteMembers">Pass True if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
	/// <param name="canChangeInfo">Pass True if the administrator can change chat title, photo and other settings.</param>
	/// <param name="canInviteUsers">Pass True if the administrator can invite new users to the chat.</param>
	/// <param name="canPinMessages">Pass True if the administrator can pin messages, supergroups only.</param>
	/// <param name="canManageTopics">Pass True if the user is allowed to create, rename, close, and reopen forum topics, supergroups only.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> PromoteChatMemberAsync(this ITelegramBotClient api, long chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canDeleteMessages = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPinMessages = null, bool? canManageTopics = null, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteNumber(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		if (isAnonymous is not null)
		{
			json.WriteBoolean(PropertyNames.IsAnonymous, (bool)isAnonymous);
		}
		if (canManageChat is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageChat, (bool)canManageChat);
		}
		if (canPostMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostMessages, (bool)canPostMessages);
		}
		if (canEditMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditMessages, (bool)canEditMessages);
		}
		if (canDeleteMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteMessages, (bool)canDeleteMessages);
		}
		if (canPostStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostStories, (bool)canPostStories);
		}
		if (canEditStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditStories, (bool)canEditStories);
		}
		if (canDeleteStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteStories, (bool)canDeleteStories);
		}
		if (canManageVideoChats is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageVideoChats, (bool)canManageVideoChats);
		}
		if (canRestrictMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanRestrictMembers, (bool)canRestrictMembers);
		}
		if (canPromoteMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanPromoteMembers, (bool)canPromoteMembers);
		}
		if (canChangeInfo is not null)
		{
			json.WriteBoolean(PropertyNames.CanChangeInfo, (bool)canChangeInfo);
		}
		if (canInviteUsers is not null)
		{
			json.WriteBoolean(PropertyNames.CanInviteUsers, (bool)canInviteUsers);
		}
		if (canPinMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPinMessages, (bool)canPinMessages);
		}
		if (canManageTopics is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageTopics, (bool)canManageTopics);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.PromoteChatMember, stream, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to promote or demote a user in a supergroup or a channel. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Pass False for all boolean parameters to demote a user. Returns True on success.
	/// </summary>
	/// <param name="api">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="userId">Unique identifier of the target user.</param>
	/// <param name="isAnonymous">Pass True if the administrator's presence in the chat is hidden.</param>
	/// <param name="canManageChat">Pass True if the administrator can access the chat event log, chat statistics, boost list in channels, message statistics in channels, see channel members, see anonymous administrators in supergroups and ignore slow mode. Implied by any other administrator privilege.</param>
	/// <param name="canPostMessages">Pass True if the administrator can post messages in the channel; channels only.</param>
	/// <param name="canEditMessages">Pass True if the administrator can edit messages of other users and can pin messages; channels only.</param>
	/// <param name="canDeleteMessages">Pass True if the administrator can delete messages of other users.</param>
	/// <param name="canPostStories">Pass True if the administrator can post stories in the channel; channels only.</param>
	/// <param name="canEditStories">Pass True if the administrator can edit stories posted by other users; channels only.</param>
	/// <param name="canDeleteStories">Pass True if the administrator can delete stories posted by other users; channels only.</param>
	/// <param name="canManageVideoChats">Pass True if the administrator can manage video chats.</param>
	/// <param name="canRestrictMembers">Pass True if the administrator can restrict, ban or unban chat members.</param>
	/// <param name="canPromoteMembers">Pass True if the administrator can add new administrators with a subset of their own privileges or demote administrators that they have promoted, directly or indirectly (promoted by administrators that were appointed by him).</param>
	/// <param name="canChangeInfo">Pass True if the administrator can change chat title, photo and other settings.</param>
	/// <param name="canInviteUsers">Pass True if the administrator can invite new users to the chat.</param>
	/// <param name="canPinMessages">Pass True if the administrator can pin messages, supergroups only.</param>
	/// <param name="canManageTopics">Pass True if the user is allowed to create, rename, close, and reopen forum topics, supergroups only.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> PromoteChatMemberAsync(this ITelegramBotClient api, string chatId, long userId, bool? isAnonymous = null, bool? canManageChat = null, bool? canPostMessages = null, bool? canEditMessages = null, bool? canDeleteMessages = null, bool? canPostStories = null, bool? canEditStories = null, bool? canDeleteStories = null, bool? canManageVideoChats = null, bool? canRestrictMembers = null, bool? canPromoteMembers = null, bool? canChangeInfo = null, bool? canInviteUsers = null, bool? canPinMessages = null, bool? canManageTopics = null, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
		json.WriteStartObject();
		json.WriteString(PropertyNames.ChatId, chatId);
		json.WriteNumber(PropertyNames.UserId, userId);
		if (isAnonymous is not null)
		{
			json.WriteBoolean(PropertyNames.IsAnonymous, (bool)isAnonymous);
		}
		if (canManageChat is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageChat, (bool)canManageChat);
		}
		if (canPostMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostMessages, (bool)canPostMessages);
		}
		if (canEditMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditMessages, (bool)canEditMessages);
		}
		if (canDeleteMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteMessages, (bool)canDeleteMessages);
		}
		if (canPostStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanPostStories, (bool)canPostStories);
		}
		if (canEditStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanEditStories, (bool)canEditStories);
		}
		if (canDeleteStories is not null)
		{
			json.WriteBoolean(PropertyNames.CanDeleteStories, (bool)canDeleteStories);
		}
		if (canManageVideoChats is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageVideoChats, (bool)canManageVideoChats);
		}
		if (canRestrictMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanRestrictMembers, (bool)canRestrictMembers);
		}
		if (canPromoteMembers is not null)
		{
			json.WriteBoolean(PropertyNames.CanPromoteMembers, (bool)canPromoteMembers);
		}
		if (canChangeInfo is not null)
		{
			json.WriteBoolean(PropertyNames.CanChangeInfo, (bool)canChangeInfo);
		}
		if (canInviteUsers is not null)
		{
			json.WriteBoolean(PropertyNames.CanInviteUsers, (bool)canInviteUsers);
		}
		if (canPinMessages is not null)
		{
			json.WriteBoolean(PropertyNames.CanPinMessages, (bool)canPinMessages);
		}
		if (canManageTopics is not null)
		{
			json.WriteBoolean(PropertyNames.CanManageTopics, (bool)canManageTopics);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await api.CallMethodAsync<bool>(MethodNames.PromoteChatMember, stream, cancellationToken).ConfigureAwait(false);
	}
}
