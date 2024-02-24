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
    /// Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetChatAdministratorCustomTitle(this ITelegramBotClient client, long chatId, long userId, string customTitle) =>
        client.SetChatAdministratorCustomTitleAsync(chatId, userId, customTitle).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetChatAdministratorCustomTitleAsync(this ITelegramBotClient client, long chatId, long userId, string customTitle, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.UserId, userId },
            { PropertyNames.CustomTitle, customTitle ?? throw new ArgumentNullException(nameof(customTitle)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.SetChatAdministratorCustomTitle, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetChatAdministratorCustomTitle(this ITelegramBotClient client, string chatId, long userId, string customTitle) =>
        client.SetChatAdministratorCustomTitleAsync(chatId, userId, customTitle).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@supergroupusername</em>)</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetChatAdministratorCustomTitleAsync(this ITelegramBotClient client, string chatId, long userId, string customTitle, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.UserId, userId },
            { PropertyNames.CustomTitle, customTitle ?? throw new ArgumentNullException(nameof(customTitle)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.SetChatAdministratorCustomTitle, args, cancellationToken);
    }
}
