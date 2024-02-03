// Copyright (c) 2024 Quetzal Rivera.
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
    /// Use this method to get a list of profile pictures for a user. Returns a <see cref="UserProfilePhotos"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
    /// <param name="limit">Limits the number of photos to be retrieved. Values between 1-100 are accepted. Defaults to 100.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static UserProfilePhotos GetUserProfilePhotos(this ITelegramBotClient client, long userId, int? offset = null, int? limit = null) =>
        client.GetUserProfilePhotosAsync(userId, offset, limit).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get a list of profile pictures for a user. Returns a <see cref="UserProfilePhotos"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user</param>
    /// <param name="offset">Sequential number of the first photo to be returned. By default, all photos are returned.</param>
    /// <param name="limit">Limits the number of photos to be retrieved. Values between 1-100 are accepted. Defaults to 100.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<UserProfilePhotos> GetUserProfilePhotosAsync(this ITelegramBotClient client, long userId, int? offset = null, int? limit = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId }
        };
        if (offset is not null)
        {
            args.Add(PropertyNames.Offset, offset);
        }
        if (limit is not null)
        {
            args.Add(PropertyNames.Limit, limit);
        }

        return client.CallMethodAsync<UserProfilePhotos>(MethodNames.GetUserProfilePhotos, args, cancellationToken);
    }
}
