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
    /// Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an <see cref="Update"/> with the field <em>pre_checkout_query</em>. Use this method to respond to such pre-checkout queries. On success, <em>True</em> is returned. <strong>Note:</strong> The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="preCheckoutQueryId">Unique identifier for the query to be answered</param>
    /// <param name="ok">Specify <em>True</em> if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use <em>False</em> if there are any problems.</param>
    /// <param name="errorMessage">Required if <em>ok</em> is <em>False</em>. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool AnswerPreCheckoutQuery(this ITelegramBotClient client, string preCheckoutQueryId, bool ok, string? errorMessage = null) =>
        client.AnswerPreCheckoutQueryAsync(preCheckoutQueryId, ok, errorMessage).GetAwaiter().GetResult();

    /// <summary>
    /// Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an <see cref="Update"/> with the field <em>pre_checkout_query</em>. Use this method to respond to such pre-checkout queries. On success, <em>True</em> is returned. <strong>Note:</strong> The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="preCheckoutQueryId">Unique identifier for the query to be answered</param>
    /// <param name="ok">Specify <em>True</em> if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use <em>False</em> if there are any problems.</param>
    /// <param name="errorMessage">Required if <em>ok</em> is <em>False</em>. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> AnswerPreCheckoutQueryAsync(this ITelegramBotClient client, string preCheckoutQueryId, bool ok, string? errorMessage = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.PreCheckoutQueryId, preCheckoutQueryId ?? throw new ArgumentNullException(nameof(preCheckoutQueryId)) },
            { PropertyNames.Ok, ok }
        };
        if (errorMessage is not null)
        {
            args.Add(PropertyNames.ErrorMessage, errorMessage);
        }

        return client.CallMethodAsync<bool>(MethodNames.AnswerPreCheckoutQuery, args, cancellationToken);
    }
}
