// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Returns the gifts received and owned by a managed business account. Requires the <em>can_view_gifts_and_stars</em> business bot right. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetBusinessAccountGifts" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static OwnedGifts GetBusinessAccountGifts(this ITelegramBotClient client, GetBusinessAccountGiftsArgs args) =>
        client.GetBusinessAccountGiftsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Returns the gifts received and owned by a managed business account. Requires the <em>can_view_gifts_and_stars</em> business bot right. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "GetBusinessAccountGifts" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<OwnedGifts> GetBusinessAccountGiftsAsync(this ITelegramBotClient client, GetBusinessAccountGiftsArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<OwnedGifts>(MethodNames.GetBusinessAccountGifts, args, cancellationToken);
    }

    /// <summary>
    /// Returns the gifts received and owned by a managed business account. Requires the <em>can_view_gifts_and_stars</em> business bot right. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="excludeUnsaved">Pass True to exclude gifts that aren't saved to the account's profile page</param>
    /// <param name="excludeSaved">Pass True to exclude gifts that are saved to the account's profile page</param>
    /// <param name="excludeUnlimited">Pass True to exclude gifts that can be purchased an unlimited number of times</param>
    /// <param name="excludeLimited">Pass True to exclude gifts that can be purchased a limited number of times</param>
    /// <param name="excludeUnique">Pass True to exclude unique gifts</param>
    /// <param name="sortByPrice">Pass True to sort results by gift price instead of send date. Sorting is applied before pagination.</param>
    /// <param name="offset">Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results</param>
    /// <param name="limit">The maximum number of gifts to be returned; 1-100. Defaults to 100</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static OwnedGifts GetBusinessAccountGifts(this ITelegramBotClient client, string businessConnectionId, bool? excludeUnsaved = null, bool? excludeSaved = null, bool? excludeUnlimited = null, bool? excludeLimited = null, bool? excludeUnique = null, bool? sortByPrice = null, string? offset = null, int? limit = null) =>
        client.GetBusinessAccountGiftsAsync(businessConnectionId, excludeUnsaved, excludeSaved, excludeUnlimited, excludeLimited, excludeUnique, sortByPrice, offset, limit).GetAwaiter().GetResult();

    /// <summary>
    /// Returns the gifts received and owned by a managed business account. Requires the <em>can_view_gifts_and_stars</em> business bot right. Returns <see cref="OwnedGifts"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="excludeUnsaved">Pass True to exclude gifts that aren't saved to the account's profile page</param>
    /// <param name="excludeSaved">Pass True to exclude gifts that are saved to the account's profile page</param>
    /// <param name="excludeUnlimited">Pass True to exclude gifts that can be purchased an unlimited number of times</param>
    /// <param name="excludeLimited">Pass True to exclude gifts that can be purchased a limited number of times</param>
    /// <param name="excludeUnique">Pass True to exclude unique gifts</param>
    /// <param name="sortByPrice">Pass True to sort results by gift price instead of send date. Sorting is applied before pagination.</param>
    /// <param name="offset">Offset of the first entry to return as received from the previous request; use empty string to get the first chunk of results</param>
    /// <param name="limit">The maximum number of gifts to be returned; 1-100. Defaults to 100</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<OwnedGifts> GetBusinessAccountGiftsAsync(this ITelegramBotClient client, string businessConnectionId, bool? excludeUnsaved = null, bool? excludeSaved = null, bool? excludeUnlimited = null, bool? excludeLimited = null, bool? excludeUnique = null, bool? sortByPrice = null, string? offset = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) }
        };
        if (excludeUnsaved is not null)
        {
            args.Add(PropertyNames.ExcludeUnsaved, excludeUnsaved);
        }
        if (excludeSaved is not null)
        {
            args.Add(PropertyNames.ExcludeSaved, excludeSaved);
        }
        if (excludeUnlimited is not null)
        {
            args.Add(PropertyNames.ExcludeUnlimited, excludeUnlimited);
        }
        if (excludeLimited is not null)
        {
            args.Add(PropertyNames.ExcludeLimited, excludeLimited);
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

        return client.CallMethodAsync<OwnedGifts>(MethodNames.GetBusinessAccountGifts, args, cancellationToken);
    }
}
