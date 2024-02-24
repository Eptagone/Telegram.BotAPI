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
    /// Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the revoked invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier of the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="inviteLink">The invite link to revoke</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink RevokeChatInviteLink(this ITelegramBotClient client, long chatId, string inviteLink) =>
        client.RevokeChatInviteLinkAsync(chatId, inviteLink).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the revoked invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier of the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="inviteLink">The invite link to revoke</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> RevokeChatInviteLinkAsync(this ITelegramBotClient client, long chatId, string inviteLink, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.InviteLink, inviteLink ?? throw new ArgumentNullException(nameof(inviteLink)) }
        };

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.RevokeChatInviteLink, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the revoked invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier of the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="inviteLink">The invite link to revoke</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatInviteLink RevokeChatInviteLink(this ITelegramBotClient client, string chatId, string inviteLink) =>
        client.RevokeChatInviteLinkAsync(chatId, inviteLink).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to revoke an invite link created by the bot. If the primary link is revoked, a new link is automatically generated. The bot must be an administrator in the chat for this to work and must have the appropriate administrator rights. Returns the revoked invite link as <see cref="ChatInviteLink"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier of the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="inviteLink">The invite link to revoke</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatInviteLink> RevokeChatInviteLinkAsync(this ITelegramBotClient client, string chatId, string inviteLink, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.InviteLink, inviteLink ?? throw new ArgumentNullException(nameof(inviteLink)) }
        };

        return client.CallMethodAsync<ChatInviteLink>(MethodNames.RevokeChatInviteLink, args, cancellationToken);
    }
}
