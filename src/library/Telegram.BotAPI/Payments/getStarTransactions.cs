// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class PaymentsExtensions
{
    /// <summary>
    /// Returns the bot's Telegram Star transactions in chronological order. On success, returns a <see cref="StarTransactions"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="offset">Number of transactions to skip in the response</param>
    /// <param name="limit">The maximum number of transactions to be retrieved. Values between 1-100 are accepted. Defaults to 100.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static StarTransactions GetStarTransactions(this ITelegramBotClient client, int? offset = null, int? limit = null) =>
        client.GetStarTransactionsAsync(offset, limit).GetAwaiter().GetResult();

    /// <summary>
    /// Returns the bot's Telegram Star transactions in chronological order. On success, returns a <see cref="StarTransactions"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="offset">Number of transactions to skip in the response</param>
    /// <param name="limit">The maximum number of transactions to be retrieved. Values between 1-100 are accepted. Defaults to 100.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<StarTransactions> GetStarTransactionsAsync(this ITelegramBotClient client, int? offset = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (offset is not null)
        {
            args.Add(PropertyNames.Offset, offset);
        }
        if (limit is not null)
        {
            args.Add(PropertyNames.Limit, limit);
        }

        return client.CallMethodAsync<StarTransactions>(MethodNames.GetStarTransactions, args, cancellationToken);
    }
}
