// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to edit only the reply markup of an ephemeral message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditEphemeralMessageReplyMarkup" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditEphemeralMessageReplyMarkup(this ITelegramBotClient client, EditEphemeralMessageReplyMarkupArgs args) =>
        client.EditEphemeralMessageReplyMarkupAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit only the reply markup of an ephemeral message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditEphemeralMessageReplyMarkup" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditEphemeralMessageReplyMarkupAsync(this ITelegramBotClient client, EditEphemeralMessageReplyMarkupArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.EditEphemeralMessageReplyMarkup, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit only the reply markup of an ephemeral message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditEphemeralMessageReplyMarkup(this ITelegramBotClient client, long chatId, long receiverUserId, int ephemeralMessageId, ReplyMarkup? replyMarkup = null) =>
        client.EditEphemeralMessageReplyMarkupAsync(chatId, receiverUserId, ephemeralMessageId, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit only the reply markup of an ephemeral message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditEphemeralMessageReplyMarkupAsync(this ITelegramBotClient client, long chatId, long receiverUserId, int ephemeralMessageId, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.ReceiverUserId, receiverUserId },
            { PropertyNames.EphemeralMessageId, ephemeralMessageId }
        };
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditEphemeralMessageReplyMarkup, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit only the reply markup of an ephemeral message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditEphemeralMessageReplyMarkup(this ITelegramBotClient client, string chatId, long receiverUserId, int ephemeralMessageId, ReplyMarkup? replyMarkup = null) =>
        client.EditEphemeralMessageReplyMarkupAsync(chatId, receiverUserId, ephemeralMessageId, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit only the reply markup of an ephemeral message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditEphemeralMessageReplyMarkupAsync(this ITelegramBotClient client, string chatId, long receiverUserId, int ephemeralMessageId, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.ReceiverUserId, receiverUserId },
            { PropertyNames.EphemeralMessageId, ephemeralMessageId }
        };
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditEphemeralMessageReplyMarkup, args, cancellationToken);
    }
}
