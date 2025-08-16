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
    /// Changes the profile photo of a managed business account. Requires the <em>can_edit_profile_photo</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetBusinessAccountProfilePhoto" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetBusinessAccountProfilePhoto(this ITelegramBotClient client, SetBusinessAccountProfilePhotoArgs args) =>
        client.SetBusinessAccountProfilePhotoAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Changes the profile photo of a managed business account. Requires the <em>can_edit_profile_photo</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetBusinessAccountProfilePhoto" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetBusinessAccountProfilePhotoAsync(this ITelegramBotClient client, SetBusinessAccountProfilePhotoArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetBusinessAccountProfilePhoto, args, cancellationToken);
    }

    /// <summary>
    /// Changes the profile photo of a managed business account. Requires the <em>can_edit_profile_photo</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="photo">The new profile photo to set</param>
    /// <param name="isPublic">Pass <em>True</em> to set the public photo, which will be visible even if the main photo is hidden by the business account's privacy settings. An account can have only one public photo.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetBusinessAccountProfilePhoto(this ITelegramBotClient client, string businessConnectionId, InputProfilePhoto photo, bool? isPublic = null) =>
        client.SetBusinessAccountProfilePhotoAsync(businessConnectionId, photo, isPublic).GetAwaiter().GetResult();

    /// <summary>
    /// Changes the profile photo of a managed business account. Requires the <em>can_edit_profile_photo</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="photo">The new profile photo to set</param>
    /// <param name="isPublic">Pass <em>True</em> to set the public photo, which will be visible even if the main photo is hidden by the business account's privacy settings. An account can have only one public photo.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetBusinessAccountProfilePhotoAsync(this ITelegramBotClient client, string businessConnectionId, InputProfilePhoto photo, bool? isPublic = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.Photo, photo ?? throw new ArgumentNullException(nameof(photo)) }
        };
        if (isPublic is not null)
        {
            args.Add(PropertyNames.IsPublic, isPublic);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetBusinessAccountProfilePhoto, args, cancellationToken);
    }
}
