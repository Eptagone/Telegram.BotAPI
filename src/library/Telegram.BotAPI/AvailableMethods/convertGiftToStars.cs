// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Converts a given regular gift to Telegram Stars. Requires the <em>can_convert_gifts_to_stars</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be converted to Telegram Stars</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool ConvertGiftToStars(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId) =>
        client.ConvertGiftToStarsAsync(businessConnectionId, ownedGiftId).GetAwaiter().GetResult();

    /// <summary>
    /// Converts a given regular gift to Telegram Stars. Requires the <em>can_convert_gifts_to_stars</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="ownedGiftId">Unique identifier of the regular gift that should be converted to Telegram Stars</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> ConvertGiftToStarsAsync(this ITelegramBotClient client, string businessConnectionId, string ownedGiftId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.OwnedGiftId, ownedGiftId ?? throw new ArgumentNullException(nameof(ownedGiftId)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.ConvertGiftToStars, args, cancellationToken);
    }
}
