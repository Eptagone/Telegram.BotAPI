// Copyright (c) 2024 Quetzal Rivera.
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
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "StopMessageLiveLocation" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static TResult StopMessageLiveLocation<TResult>(this ITelegramBotClient client, StopMessageLiveLocationArgs args) =>
        client.StopMessageLiveLocationAsync<TResult>(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "StopMessageLiveLocation" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<TResult> StopMessageLiveLocationAsync<TResult>(this ITelegramBotClient client, StopMessageLiveLocationArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<TResult>(MethodNames.StopMessageLiveLocation, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with live location to stop</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message StopMessageLiveLocation(this ITelegramBotClient client, long chatId, int messageId, string? businessConnectionId = null, ReplyMarkup? replyMarkup = null) =>
        client.StopMessageLiveLocationAsync(chatId, messageId, businessConnectionId, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with live location to stop</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> StopMessageLiveLocationAsync(this ITelegramBotClient client, long chatId, int messageId, string? businessConnectionId = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.StopMessageLiveLocation, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with live location to stop</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message StopMessageLiveLocation(this ITelegramBotClient client, string chatId, int messageId, string? businessConnectionId = null, ReplyMarkup? replyMarkup = null) =>
        client.StopMessageLiveLocationAsync(chatId, messageId, businessConnectionId, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with live location to stop</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> StopMessageLiveLocationAsync(this ITelegramBotClient client, string chatId, int messageId, string? businessConnectionId = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.MessageId, messageId }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.StopMessageLiveLocation, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool StopMessageLiveLocation(this ITelegramBotClient client, string inlineMessageId, string? businessConnectionId = null, ReplyMarkup? replyMarkup = null) =>
        client.StopMessageLiveLocationAsync(inlineMessageId, businessConnectionId, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to stop updating a live location message before <em>live_period</em> expires. On success, if the message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="replyMarkup">A JSON-serialized object for a new <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> StopMessageLiveLocationAsync(this ITelegramBotClient client, string inlineMessageId, string? businessConnectionId = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.InlineMessageId, inlineMessageId ?? throw new ArgumentNullException(nameof(inlineMessageId)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<bool>(MethodNames.StopMessageLiveLocation, args, cancellationToken);
    }
}
