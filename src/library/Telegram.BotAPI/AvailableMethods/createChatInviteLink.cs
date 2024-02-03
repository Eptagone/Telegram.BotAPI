// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "CreateChatInviteLink" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink CreateChatInviteLink(this ITelegramBotClient client, CreateChatInviteLinkArgs args) =>
        client.CreateChatInviteLinkAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "CreateChatInviteLink" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> CreateChatInviteLinkAsync(this ITelegramBotClient client, CreateChatInviteLinkArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.CreateChatInviteLink, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire</param>
    /// <param name="memberLimit">The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999</param>
    /// <param name="createsJoinRequest"><em>True</em>, if users joining the chat via the link need to be approved by chat administrators. If <em>True</em>, <em>member_limit</em> can't be specified</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink CreateChatInviteLink(this ITelegramBotClient client, long chatId, string? name = null, int? expireDate = null, int? memberLimit = null, bool? createsJoinRequest = null) =>
        client.CreateChatInviteLinkAsync(chatId, name, expireDate, memberLimit, createsJoinRequest).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire</param>
    /// <param name="memberLimit">The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999</param>
    /// <param name="createsJoinRequest"><em>True</em>, if users joining the chat via the link need to be approved by chat administrators. If <em>True</em>, <em>member_limit</em> can't be specified</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> CreateChatInviteLinkAsync(this ITelegramBotClient client, long chatId, string? name = null, int? expireDate = null, int? memberLimit = null, bool? createsJoinRequest = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId }
        };
        if (name is not null)
        {
            args.Add(PropertyNames.Name, name);
        }
        if (expireDate is not null)
        {
            args.Add(PropertyNames.ExpireDate, expireDate);
        }
        if (memberLimit is not null)
        {
            args.Add(PropertyNames.MemberLimit, memberLimit);
        }
        if (createsJoinRequest is not null)
        {
            args.Add(PropertyNames.CreatesJoinRequest, createsJoinRequest);
        }

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.CreateChatInviteLink, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire</param>
    /// <param name="memberLimit">The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999</param>
    /// <param name="createsJoinRequest"><em>True</em>, if users joining the chat via the link need to be approved by chat administrators. If <em>True</em>, <em>member_limit</em> can't be specified</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink CreateChatInviteLink(this ITelegramBotClient client, string chatId, string? name = null, int? expireDate = null, int? memberLimit = null, bool? createsJoinRequest = null) =>
        client.CreateChatInviteLinkAsync(chatId, name, expireDate, memberLimit, createsJoinRequest).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create an additional invite link for a chat. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. The link can be revoked using the method <a href="https://core.telegram.org/bots/api#revokechatinvitelink">revokeChatInviteLink</a>. Returns the new invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="name">Invite link name; 0-32 characters</param>
    /// <param name="expireDate">Point in time (Unix timestamp) when the link will expire</param>
    /// <param name="memberLimit">The maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999</param>
    /// <param name="createsJoinRequest"><em>True</em>, if users joining the chat via the link need to be approved by chat administrators. If <em>True</em>, <em>member_limit</em> can't be specified</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> CreateChatInviteLinkAsync(this ITelegramBotClient client, string chatId, string? name = null, int? expireDate = null, int? memberLimit = null, bool? createsJoinRequest = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) }
        };
        if (name is not null)
        {
            args.Add(PropertyNames.Name, name);
        }
        if (expireDate is not null)
        {
            args.Add(PropertyNames.ExpireDate, expireDate);
        }
        if (memberLimit is not null)
        {
            args.Add(PropertyNames.MemberLimit, memberLimit);
        }
        if (createsJoinRequest is not null)
        {
            args.Add(PropertyNames.CreatesJoinRequest, createsJoinRequest);
        }

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.CreateChatInviteLink, args, cancellationToken);
    }
}
