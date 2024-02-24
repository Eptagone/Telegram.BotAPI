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
    /// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a <see cref="UserChatBoosts"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the chat or username of the channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static UserChatBoosts GetUserChatBoosts(this ITelegramBotClient client, long chatId, long userId) =>
        client.GetUserChatBoostsAsync(chatId, userId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a <see cref="UserChatBoosts"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the chat or username of the channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<UserChatBoosts> GetUserChatBoostsAsync(this ITelegramBotClient client, long chatId, long userId, CancellationToken cancellationToken = default)
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

        return client.CallMethodAsync<UserChatBoosts>(MethodNames.GetUserChatBoosts, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a <see cref="UserChatBoosts"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the chat or username of the channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static UserChatBoosts GetUserChatBoosts(this ITelegramBotClient client, string chatId, long userId) =>
        client.GetUserChatBoostsAsync(chatId, userId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the list of boosts added to a chat by a user. Requires administrator rights in the chat. Returns a <see cref="UserChatBoosts"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the chat or username of the channel (in the format <em>@channelusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<UserChatBoosts> GetUserChatBoostsAsync(this ITelegramBotClient client, string chatId, long userId, CancellationToken cancellationToken = default)
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

        return client.CallMethodAsync<UserChatBoosts>(MethodNames.GetUserChatBoosts, args, cancellationToken);
    }
}
