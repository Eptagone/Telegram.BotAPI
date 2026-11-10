// Copyright (c) 2026 Quetzal Rivera.
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
    /// Use this method to get information about a unique gift by its name. Returns a <see cref="UniqueGift"/> object on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Unique name of the gift</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static UniqueGift GetUniqueGift(this ITelegramBotClient client, string name) =>
        client.GetUniqueGiftAsync(name).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get information about a unique gift by its name. Returns a <see cref="UniqueGift"/> object on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="name">Unique name of the gift</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<UniqueGift> GetUniqueGiftAsync(this ITelegramBotClient client, string name, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Name, name ?? throw new ArgumentNullException(nameof(name)) }
        };

        return client.CallMethodAsync<UniqueGift>(MethodNames.GetUniqueGift, args, cancellationToken);
    }
}
