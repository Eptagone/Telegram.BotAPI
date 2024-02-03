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
    /// Use this method to send answers to an inline query. On success, <em>True</em> is returned.<br />No more than <strong>50</strong> results per query are allowed.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerInlineQuery" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerInlineQuery(this ITelegramBotClient client, AnswerInlineQueryArgs args) =>
        client.AnswerInlineQueryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send answers to an inline query. On success, <em>True</em> is returned.<br />No more than <strong>50</strong> results per query are allowed.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerInlineQuery" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerInlineQueryAsync(this ITelegramBotClient client, AnswerInlineQueryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerInlineQuery, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send answers to an inline query. On success, <em>True</em> is returned.<br />No more than <strong>50</strong> results per query are allowed.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineQueryId">Unique identifier for the answered query</param>
    /// <param name="results">A JSON-serialized array of results for the inline query</param>
    /// <param name="cacheTime">The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.</param>
    /// <param name="isPersonal">Pass <em>True</em> if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.</param>
    /// <param name="nextOffset">Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don't support pagination. Offset length can't exceed 64 bytes.</param>
    /// <param name="button">A JSON-serialized object describing a button to be shown above inline query results</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerInlineQuery(this ITelegramBotClient client, string inlineQueryId, IEnumerable<InlineQueryResult> results, int? cacheTime = null, bool? isPersonal = null, string? nextOffset = null, InlineQueryResultsButton? button = null) =>
        client.AnswerInlineQueryAsync(inlineQueryId, results, cacheTime, isPersonal, nextOffset, button).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send answers to an inline query. On success, <em>True</em> is returned.<br />No more than <strong>50</strong> results per query are allowed.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineQueryId">Unique identifier for the answered query</param>
    /// <param name="results">A JSON-serialized array of results for the inline query</param>
    /// <param name="cacheTime">The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.</param>
    /// <param name="isPersonal">Pass <em>True</em> if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.</param>
    /// <param name="nextOffset">Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don't support pagination. Offset length can't exceed 64 bytes.</param>
    /// <param name="button">A JSON-serialized object describing a button to be shown above inline query results</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerInlineQueryAsync(this ITelegramBotClient client, string inlineQueryId, IEnumerable<InlineQueryResult> results, int? cacheTime = null, bool? isPersonal = null, string? nextOffset = null, InlineQueryResultsButton? button = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.InlineQueryId, inlineQueryId ?? throw new ArgumentNullException(nameof(inlineQueryId)) },
            { PropertyNames.Results, results ?? throw new ArgumentNullException(nameof(results)) }
        };
        if (cacheTime is not null)
        {
            args.Add(PropertyNames.CacheTime, cacheTime);
        }
        if (isPersonal is not null)
        {
            args.Add(PropertyNames.IsPersonal, isPersonal);
        }
        if (nextOffset is not null)
        {
            args.Add(PropertyNames.NextOffset, nextOffset);
        }
        if (button is not null)
        {
            args.Add(PropertyNames.Button, button);
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerInlineQuery, args, cancellationToken);
    }
}
