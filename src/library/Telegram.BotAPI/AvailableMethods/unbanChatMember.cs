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
    /// Use this method to unban a previously banned user in a supergroup or channel. The user will <strong>not</strong> return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be <strong>removed</strong> from the chat. If you don't want this, use the parameter <em>only_if_banned</em>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="onlyIfBanned">Do nothing if the user is not banned</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool UnbanChatMember(this ITelegramBotClient client, long chatId, long userId, bool? onlyIfBanned = null) =>
        client.UnbanChatMemberAsync(chatId, userId, onlyIfBanned).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to unban a previously banned user in a supergroup or channel. The user will <strong>not</strong> return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be <strong>removed</strong> from the chat. If you don't want this, use the parameter <em>only_if_banned</em>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="onlyIfBanned">Do nothing if the user is not banned</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> UnbanChatMemberAsync(this ITelegramBotClient client, long chatId, long userId, bool? onlyIfBanned = null, CancellationToken cancellationToken = default)
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
        if (onlyIfBanned is not null)
        {
            args.Add(PropertyNames.OnlyIfBanned, onlyIfBanned);
        }

        return client.CallMethodAsync<bool>(MethodNames.UnbanChatMember, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to unban a previously banned user in a supergroup or channel. The user will <strong>not</strong> return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be <strong>removed</strong> from the chat. If you don't want this, use the parameter <em>only_if_banned</em>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="onlyIfBanned">Do nothing if the user is not banned</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool UnbanChatMember(this ITelegramBotClient client, string chatId, long userId, bool? onlyIfBanned = null) =>
        client.UnbanChatMemberAsync(chatId, userId, onlyIfBanned).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to unban a previously banned user in a supergroup or channel. The user will <strong>not</strong> return to the group or channel automatically, but will be able to join via link, etc. The bot must be an administrator for this to work. By default, this method guarantees that after the call the user is not a member of the chat, but will be able to join it. So if the user is a member of the chat they will also be <strong>removed</strong> from the chat. If you don't want this, use the parameter <em>only_if_banned</em>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target group or username of the target supergroup or channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="onlyIfBanned">Do nothing if the user is not banned</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> UnbanChatMemberAsync(this ITelegramBotClient client, string chatId, long userId, bool? onlyIfBanned = null, CancellationToken cancellationToken = default)
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
        if (onlyIfBanned is not null)
        {
            args.Add(PropertyNames.OnlyIfBanned, onlyIfBanned);
        }

        return client.CallMethodAsync<bool>(MethodNames.UnbanChatMember, args, cancellationToken);
    }
}
