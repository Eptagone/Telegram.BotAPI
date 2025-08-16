// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Returns the amount of Telegram Stars owned by a managed business account. Requires the <em>can_view_gifts_and_stars</em> business bot right. Returns <see cref="StarAmount"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static StarAmount GetBusinessAccountStarBalance(this ITelegramBotClient client, string businessConnectionId) =>
        client.GetBusinessAccountStarBalanceAsync(businessConnectionId).GetAwaiter().GetResult();

    /// <summary>
    /// Returns the amount of Telegram Stars owned by a managed business account. Requires the <em>can_view_gifts_and_stars</em> business bot right. Returns <see cref="StarAmount"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<StarAmount> GetBusinessAccountStarBalanceAsync(this ITelegramBotClient client, string businessConnectionId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) }
        };

        return client.CallMethodAsync<StarAmount>(MethodNames.GetBusinessAccountStarBalance, args, cancellationToken);
    }
}
