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
    /// Refunds a successful payment in <a href="https://t.me/BotNews/90">Telegram Stars</a>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Identifier of the user whose payment will be refunded</param>
    /// <param name="telegramPaymentChargeId">Telegram payment identifier</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool RefundStarPayment(this ITelegramBotClient client, long userId, string telegramPaymentChargeId) =>
        client.RefundStarPaymentAsync(userId, telegramPaymentChargeId).GetAwaiter().GetResult();

    /// <summary>
    /// Refunds a successful payment in <a href="https://t.me/BotNews/90">Telegram Stars</a>. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Identifier of the user whose payment will be refunded</param>
    /// <param name="telegramPaymentChargeId">Telegram payment identifier</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> RefundStarPaymentAsync(this ITelegramBotClient client, long userId, string telegramPaymentChargeId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.TelegramPaymentChargeId, telegramPaymentChargeId ?? throw new ArgumentNullException(nameof(telegramPaymentChargeId)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.RefundStarPayment, args, cancellationToken);
    }
}
