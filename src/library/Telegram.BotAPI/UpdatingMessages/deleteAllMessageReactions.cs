// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to remove up to 10000 recent reactions in a group or a supergroup chat added by a given user or chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="userId">Identifier of the user whose reactions will be removed, if the reactions were added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reactions will be removed, if the reactions were added by a chat</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteAllMessageReactions(
        this ITelegramBotClient client,
        long chatId,
        long? userId = null,
        long? actorChatId = null
    ) =>
        client.DeleteAllMessageReactionsAsync(chatId, userId, actorChatId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to remove up to 10000 recent reactions in a group or a supergroup chat added by a given user or chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="userId">Identifier of the user whose reactions will be removed, if the reactions were added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reactions will be removed, if the reactions were added by a chat</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteAllMessageReactionsAsync(
        this ITelegramBotClient client,
        long chatId,
        long? userId = null,
        long? actorChatId = null,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>() { { PropertyNames.ChatId, chatId } };
        if (userId is not null)
        {
            args.Add(PropertyNames.UserId, userId);
        }
        if (actorChatId is not null)
        {
            args.Add(PropertyNames.ActorChatId, actorChatId);
        }

        return client.CallMethodAsync<bool>(
            MethodNames.DeleteAllMessageReactions,
            args,
            cancellationToken
        );
    }

    /// <summary>
    /// Use this method to remove up to 10000 recent reactions in a group or a supergroup chat added by a given user or chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="userId">Identifier of the user whose reactions will be removed, if the reactions were added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reactions will be removed, if the reactions were added by a chat</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteAllMessageReactions(
        this ITelegramBotClient client,
        string chatId,
        long? userId = null,
        long? actorChatId = null
    ) =>
        client.DeleteAllMessageReactionsAsync(chatId, userId, actorChatId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to remove up to 10000 recent reactions in a group or a supergroup chat added by a given user or chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="userId">Identifier of the user whose reactions will be removed, if the reactions were added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reactions will be removed, if the reactions were added by a chat</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteAllMessageReactionsAsync(
        this ITelegramBotClient client,
        string chatId,
        long? userId = null,
        long? actorChatId = null,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
        };
        if (userId is not null)
        {
            args.Add(PropertyNames.UserId, userId);
        }
        if (actorChatId is not null)
        {
            args.Add(PropertyNames.ActorChatId, actorChatId);
        }

        return client.CallMethodAsync<bool>(
            MethodNames.DeleteAllMessageReactions,
            args,
            cancellationToken
        );
    }
}
