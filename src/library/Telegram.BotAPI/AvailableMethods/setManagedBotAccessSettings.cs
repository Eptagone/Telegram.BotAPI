// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method to change the access settings of a managed bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetManagedBotAccessSettings" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetManagedBotAccessSettings(
        this ITelegramBotClient client,
        SetManagedBotAccessSettingsArgs args
    ) => client.SetManagedBotAccessSettingsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the access settings of a managed bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetManagedBotAccessSettings" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetManagedBotAccessSettingsAsync(
        this ITelegramBotClient client,
        SetManagedBotAccessSettingsArgs args,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(
            MethodNames.SetManagedBotAccessSettings,
            args,
            cancellationToken
        );
    }

    /// <summary>
    /// Use this method to change the access settings of a managed bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of the managed bot whose access settings will be changed</param>
    /// <param name="isAccessRestricted">Pass <em>True</em>, if only selected users can access the bot. The bot's owner can always access it.</param>
    /// <param name="addedUserIds">A JSON-serialized list of up to 10 identifiers of users who will have access to the bot in addition to its owner. Ignored if <em>is_access_restricted</em> is false.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetManagedBotAccessSettings(
        this ITelegramBotClient client,
        long userId,
        bool isAccessRestricted,
        IEnumerable<int>? addedUserIds = null
    ) =>
        client
            .SetManagedBotAccessSettingsAsync(userId, isAccessRestricted, addedUserIds)
            .GetAwaiter()
            .GetResult();

    /// <summary>
    /// Use this method to change the access settings of a managed bot. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">User identifier of the managed bot whose access settings will be changed</param>
    /// <param name="isAccessRestricted">Pass <em>True</em>, if only selected users can access the bot. The bot's owner can always access it.</param>
    /// <param name="addedUserIds">A JSON-serialized list of up to 10 identifiers of users who will have access to the bot in addition to its owner. Ignored if <em>is_access_restricted</em> is false.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetManagedBotAccessSettingsAsync(
        this ITelegramBotClient client,
        long userId,
        bool isAccessRestricted,
        IEnumerable<int>? addedUserIds = null,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.UserId, userId },
            { PropertyNames.IsAccessRestricted, isAccessRestricted },
        };
        if (addedUserIds is not null)
        {
            args.Add(PropertyNames.AddedUserIds, addedUserIds);
        }

        return client.CallMethodAsync<bool>(
            MethodNames.SetManagedBotAccessSettings,
            args,
            cancellationToken
        );
    }
}
