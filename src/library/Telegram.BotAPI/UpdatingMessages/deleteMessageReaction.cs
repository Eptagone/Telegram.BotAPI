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
    /// Use this method to remove a reaction from a message in a group or a supergroup chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="messageId">Identifier of the target message</param>
    /// <param name="userId">Identifier of the user whose reaction will be removed, if the reaction was added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reaction will be removed, if the reaction was added by a chat</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessageReaction(
        this ITelegramBotClient client,
        long chatId,
        int messageId,
        long? userId = null,
        long? actorChatId = null
    ) =>
        client
            .DeleteMessageReactionAsync(chatId, messageId, userId, actorChatId)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Use this method to remove a reaction from a message in a group or a supergroup chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="messageId">Identifier of the target message</param>
    /// <param name="userId">Identifier of the user whose reaction will be removed, if the reaction was added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reaction will be removed, if the reaction was added by a chat</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessageReactionAsync(
        this ITelegramBotClient client,
        long chatId,
        int messageId,
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
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId },
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
            MethodNames.DeleteMessageReaction,
            args,
            cancellationToken
        );
    }

    /// <summary>
    /// Use this method to remove a reaction from a message in a group or a supergroup chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="messageId">Identifier of the target message</param>
    /// <param name="userId">Identifier of the user whose reaction will be removed, if the reaction was added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reaction will be removed, if the reaction was added by a chat</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessageReaction(
        this ITelegramBotClient client,
        string chatId,
        int messageId,
        long? userId = null,
        long? actorChatId = null
    ) =>
        client
            .DeleteMessageReactionAsync(chatId, messageId, userId, actorChatId)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Use this method to remove a reaction from a message in a group or a supergroup chat. The bot must have the 'can_delete_messages' administrator right in the chat. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format <em>@username</em>)</param>
    /// <param name="messageId">Identifier of the target message</param>
    /// <param name="userId">Identifier of the user whose reaction will be removed, if the reaction was added by a user</param>
    /// <param name="actorChatId">Identifier of the chat whose reaction will be removed, if the reaction was added by a chat</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessageReactionAsync(
        this ITelegramBotClient client,
        string chatId,
        int messageId,
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
            { PropertyNames.MessageId, messageId },
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
            MethodNames.DeleteMessageReaction,
            args,
            cancellationToken
        );
    }
}
