// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to reply to a received guest message. On success, a <see cref="SentGuestMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerGuestQuery" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static SentGuestMessage AnswerGuestQuery(
        this ITelegramBotClient client,
        AnswerGuestQueryArgs args
    ) => client.AnswerGuestQueryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to reply to a received guest message. On success, a <see cref="SentGuestMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerGuestQuery" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<SentGuestMessage> AnswerGuestQueryAsync(
        this ITelegramBotClient client,
        AnswerGuestQueryArgs args,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<SentGuestMessage>(
            MethodNames.AnswerGuestQuery,
            args,
            cancellationToken
        );
    }

    /// <summary>
    /// Use this method to reply to a received guest message. On success, a <see cref="SentGuestMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="guestQueryId">Unique identifier for the query to be answered</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static SentGuestMessage AnswerGuestQuery(
        this ITelegramBotClient client,
        string guestQueryId,
        InlineQueryResult result
    ) => client.AnswerGuestQueryAsync(guestQueryId, result).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to reply to a received guest message. On success, a <see cref="SentGuestMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="guestQueryId">Unique identifier for the query to be answered</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<SentGuestMessage> AnswerGuestQueryAsync(
        this ITelegramBotClient client,
        string guestQueryId,
        InlineQueryResult result,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            {
                PropertyNames.GuestQueryId,
                guestQueryId ?? throw new ArgumentNullException(nameof(guestQueryId))
            },
            { PropertyNames.Result, result ?? throw new ArgumentNullException(nameof(result)) },
        };

        return client.CallMethodAsync<SentGuestMessage>(
            MethodNames.AnswerGuestQuery,
            args,
            cancellationToken
        );
    }
}
