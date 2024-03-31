// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "DeleteMessages" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessages(this ITelegramBotClient client, DeleteMessagesArgs args) =>
        client.DeleteMessagesAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "DeleteMessages" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessagesAsync(this ITelegramBotClient client, DeleteMessagesArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.DeleteMessages, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessages(this ITelegramBotClient client, long chatId, IEnumerable<int> messageIds) =>
        client.DeleteMessagesAsync(chatId, messageIds).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessagesAsync(this ITelegramBotClient client, long chatId, IEnumerable<int> messageIds, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.DeleteMessages, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteMessages(this ITelegramBotClient client, string chatId, IEnumerable<int> messageIds) =>
        client.DeleteMessagesAsync(chatId, messageIds).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to delete multiple messages simultaneously. If some of the specified messages can't be found, they are skipped. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteMessagesAsync(this ITelegramBotClient client, string chatId, IEnumerable<int> messageIds, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.DeleteMessages, args, cancellationToken);
    }
}
