// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class InlineModeExtensions
{
    /// <summary>
    /// Use this method to set the result of an interaction with a <a href="https://core.telegram.org/bots/webapps">Web App</a> and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a <see cref="SentWebAppMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerWebAppQuery" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static SentWebAppMessage AnswerWebAppQuery(this ITelegramBotClient client, AnswerWebAppQueryArgs args) =>
        client.AnswerWebAppQueryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the result of an interaction with a <a href="https://core.telegram.org/bots/webapps">Web App</a> and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a <see cref="SentWebAppMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerWebAppQuery" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<SentWebAppMessage> AnswerWebAppQueryAsync(this ITelegramBotClient client, AnswerWebAppQueryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<SentWebAppMessage>(MethodNames.AnswerWebAppQuery, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to set the result of an interaction with a <a href="https://core.telegram.org/bots/webapps">Web App</a> and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a <see cref="SentWebAppMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="webAppQueryId">Unique identifier for the query to be answered</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static SentWebAppMessage AnswerWebAppQuery(this ITelegramBotClient client, string webAppQueryId, InlineQueryResult result) =>
        client.AnswerWebAppQueryAsync(webAppQueryId, result).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to set the result of an interaction with a <a href="https://core.telegram.org/bots/webapps">Web App</a> and send a corresponding message on behalf of the user to the chat from which the query originated. On success, a <see cref="SentWebAppMessage"/> object is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="webAppQueryId">Unique identifier for the query to be answered</param>
    /// <param name="result">A JSON-serialized object describing the message to be sent</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<SentWebAppMessage> AnswerWebAppQueryAsync(this ITelegramBotClient client, string webAppQueryId, InlineQueryResult result, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.WebAppQueryId, webAppQueryId ?? throw new ArgumentNullException(nameof(webAppQueryId)) },
            { PropertyNames.Result, result ?? throw new ArgumentNullException(nameof(result)) }
        };

        return client.CallMethodAsync<SentWebAppMessage>(MethodNames.AnswerWebAppQuery, args, cancellationToken);
    }
}
