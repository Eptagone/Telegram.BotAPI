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
    /// Returns the gifts owned and hosted by a user. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetUserGifts" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static OwnedGifts GetUserGifts(this ITelegramBotClient client, GetUserGiftsArgs args) =>
        client.GetUserGiftsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Returns the gifts owned and hosted by a user. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetUserGifts" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<OwnedGifts> GetUserGiftsAsync(this ITelegramBotClient client, GetUserGiftsArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<OwnedGifts>(MethodNames.GetUserGifts, args, cancellationToken);
    }

    /// <summary>
    /// Returns the gifts owned and hosted by a user. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the user</param>
    /// <param name="excludeUnlimited">Pass <em>True</em> to exclude gifts that can be purchased an unlimited number of times</param>
    /// <param name="excludeLimitedUpgradable">Pass <em>True</em> to exclude gifts that can be purchased a limited number of times and can be upgraded to unique</param>
    /// <param name="excludeLimitedNonUpgradable">Pass <em>True</em> to exclude gifts that can be purchased a limited number of times and can't be upgraded to unique</param>
    /// <param name="excludeFromBlockchain">Pass <em>True</em> to exclude gifts that were assigned from the TON blockchain and can't be resold or transferred in Telegram</param>
    /// <param name="excludeUnique">Pass <em>True</em> to exclude unique gifts</param>
    /// <param name="sortByPrice">Pass <em>True</em> to sort results by gift price instead of send date. Sorting is applied before pagination.</param>
    /// <param name="offset">Offset of the first entry to return as received from the previous request; use an empty string to get the first chunk of results</param>
    /// <param name="limit">The maximum number of gifts to be returned; 1-100. Defaults to 100</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static OwnedGifts GetUserGifts(this ITelegramBotClient client, long userId, bool? excludeUnlimited = null, bool? excludeLimitedUpgradable = null, bool? excludeLimitedNonUpgradable = null, bool? excludeFromBlockchain = null, bool? excludeUnique = null, bool? sortByPrice = null, string? offset = null, int? limit = null) =>
        client.GetUserGiftsAsync(userId, excludeUnlimited, excludeLimitedUpgradable, excludeLimitedNonUpgradable, excludeFromBlockchain, excludeUnique, sortByPrice, offset, limit).GetAwaiter().GetResult();

    /// <summary>
    /// Returns the gifts owned and hosted by a user. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the user</param>
    /// <param name="excludeUnlimited">Pass <em>True</em> to exclude gifts that can be purchased an unlimited number of times</param>
    /// <param name="excludeLimitedUpgradable">Pass <em>True</em> to exclude gifts that can be purchased a limited number of times and can be upgraded to unique</param>
    /// <param name="excludeLimitedNonUpgradable">Pass <em>True</em> to exclude gifts that can be purchased a limited number of times and can't be upgraded to unique</param>
    /// <param name="excludeFromBlockchain">Pass <em>True</em> to exclude gifts that were assigned from the TON blockchain and can't be resold or transferred in Telegram</param>
    /// <param name="excludeUnique">Pass <em>True</em> to exclude unique gifts</param>
    /// <param name="sortByPrice">Pass <em>True</em> to sort results by gift price instead of send date. Sorting is applied before pagination.</param>
    /// <param name="offset">Offset of the first entry to return as received from the previous request; use an empty string to get the first chunk of results</param>
    /// <param name="limit">The maximum number of gifts to be returned; 1-100. Defaults to 100</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<OwnedGifts> GetUserGiftsAsync(this ITelegramBotClient client, long userId, bool? excludeUnlimited = null, bool? excludeLimitedUpgradable = null, bool? excludeLimitedNonUpgradable = null, bool? excludeFromBlockchain = null, bool? excludeUnique = null, bool? sortByPrice = null, string? offset = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId }
        };
        if (excludeUnlimited is not null)
        {
            args.Add(PropertyNames.ExcludeUnlimited, excludeUnlimited);
        }
        if (excludeLimitedUpgradable is not null)
        {
            args.Add(PropertyNames.ExcludeLimitedUpgradable, excludeLimitedUpgradable);
        }
        if (excludeLimitedNonUpgradable is not null)
        {
            args.Add(PropertyNames.ExcludeLimitedNonUpgradable, excludeLimitedNonUpgradable);
        }
        if (excludeFromBlockchain is not null)
        {
            args.Add(PropertyNames.ExcludeFromBlockchain, excludeFromBlockchain);
        }
        if (excludeUnique is not null)
        {
            args.Add(PropertyNames.ExcludeUnique, excludeUnique);
        }
        if (sortByPrice is not null)
        {
            args.Add(PropertyNames.SortByPrice, sortByPrice);
        }
        if (offset is not null)
        {
            args.Add(PropertyNames.Offset, offset);
        }
        if (limit is not null)
        {
            args.Add(PropertyNames.Limit, limit);
        }

        return client.CallMethodAsync<OwnedGifts>(MethodNames.GetUserGifts, args, cancellationToken);
    }
}
