// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class PaymentsExtensions
{
    /// <summary>
    /// If you sent an invoice requesting a shipping address and the parameter <em>is_flexible</em> was specified, the Bot API will send an <see cref="Update"/> with a <em>shipping_query</em> field to the bot. Use this method to reply to shipping queries. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerShippingQuery" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerShippingQuery(this ITelegramBotClient client, AnswerShippingQueryArgs args) =>
        client.AnswerShippingQueryAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// If you sent an invoice requesting a shipping address and the parameter <em>is_flexible</em> was specified, the Bot API will send an <see cref="Update"/> with a <em>shipping_query</em> field to the bot. Use this method to reply to shipping queries. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "AnswerShippingQuery" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerShippingQueryAsync(this ITelegramBotClient client, AnswerShippingQueryArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerShippingQuery, args, cancellationToken);
    }

    /// <summary>
    /// If you sent an invoice requesting a shipping address and the parameter <em>is_flexible</em> was specified, the Bot API will send an <see cref="Update"/> with a <em>shipping_query</em> field to the bot. Use this method to reply to shipping queries. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="shippingQueryId">Unique identifier for the query to be answered</param>
    /// <param name="ok">Pass <em>True</em> if delivery to the specified address is possible and <em>False</em> if there are any problems (for example, if delivery to the specified address is not possible)</param>
    /// <param name="shippingOptions">Required if <em>ok</em> is <em>True</em>. A JSON-serialized array of available shipping options.</param>
    /// <param name="errorMessage">Required if <em>ok</em> is <em>False</em>. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerShippingQuery(this ITelegramBotClient client, string shippingQueryId, bool ok, IEnumerable<ShippingOption>? shippingOptions = null, string? errorMessage = null) =>
        client.AnswerShippingQueryAsync(shippingQueryId, ok, shippingOptions, errorMessage).GetAwaiter().GetResult();

    /// <summary>
    /// If you sent an invoice requesting a shipping address and the parameter <em>is_flexible</em> was specified, the Bot API will send an <see cref="Update"/> with a <em>shipping_query</em> field to the bot. Use this method to reply to shipping queries. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="shippingQueryId">Unique identifier for the query to be answered</param>
    /// <param name="ok">Pass <em>True</em> if delivery to the specified address is possible and <em>False</em> if there are any problems (for example, if delivery to the specified address is not possible)</param>
    /// <param name="shippingOptions">Required if <em>ok</em> is <em>True</em>. A JSON-serialized array of available shipping options.</param>
    /// <param name="errorMessage">Required if <em>ok</em> is <em>False</em>. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerShippingQueryAsync(this ITelegramBotClient client, string shippingQueryId, bool ok, IEnumerable<ShippingOption>? shippingOptions = null, string? errorMessage = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ShippingQueryId, shippingQueryId ?? throw new ArgumentNullException(nameof(shippingQueryId)) },
            { PropertyNames.Ok, ok }
        };
        if (shippingOptions is not null)
        {
            args.Add(PropertyNames.ShippingOptions, shippingOptions);
        }
        if (errorMessage is not null)
        {
            args.Add(PropertyNames.ErrorMessage, errorMessage);
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerShippingQuery, args, cancellationToken);
    }
}
