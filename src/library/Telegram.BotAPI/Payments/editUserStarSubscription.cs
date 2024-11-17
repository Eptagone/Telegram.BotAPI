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
    /// Allows the bot to cancel or re-enable extension of a subscription paid in Telegram Stars. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Identifier of the user whose subscription will be edited</param>
    /// <param name="telegramPaymentChargeId">Telegram payment identifier for the subscription</param>
    /// <param name="isCanceled">Pass <em>True</em> to cancel extension of the user subscription; the subscription must be active up to the end of the current subscription period. Pass <em>False</em> to allow the user to re-enable a subscription that was previously canceled by the bot.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditUserStarSubscription(this ITelegramBotClient client, long userId, string telegramPaymentChargeId, bool isCanceled) =>
        client.EditUserStarSubscriptionAsync(userId, telegramPaymentChargeId, isCanceled).GetAwaiter().GetResult();

    /// <summary>
    /// Allows the bot to cancel or re-enable extension of a subscription paid in Telegram Stars. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Identifier of the user whose subscription will be edited</param>
    /// <param name="telegramPaymentChargeId">Telegram payment identifier for the subscription</param>
    /// <param name="isCanceled">Pass <em>True</em> to cancel extension of the user subscription; the subscription must be active up to the end of the current subscription period. Pass <em>False</em> to allow the user to re-enable a subscription that was previously canceled by the bot.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditUserStarSubscriptionAsync(this ITelegramBotClient client, long userId, string telegramPaymentChargeId, bool isCanceled, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.TelegramPaymentChargeId, telegramPaymentChargeId ?? throw new ArgumentNullException(nameof(telegramPaymentChargeId)) },
            { PropertyNames.IsCanceled, isCanceled }
        };

        return client.CallMethodAsync<bool>(MethodNames.EditUserStarSubscription, args, cancellationToken);
    }
}
