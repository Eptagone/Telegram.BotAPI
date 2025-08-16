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
    /// Changes the privacy settings pertaining to incoming gifts in a managed business account. Requires the <em>can_change_gift_settings</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetBusinessAccountGiftSettings" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetBusinessAccountGiftSettings(this ITelegramBotClient client, SetBusinessAccountGiftSettingsArgs args) =>
        client.SetBusinessAccountGiftSettingsAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Changes the privacy settings pertaining to incoming gifts in a managed business account. Requires the <em>can_change_gift_settings</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetBusinessAccountGiftSettings" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetBusinessAccountGiftSettingsAsync(this ITelegramBotClient client, SetBusinessAccountGiftSettingsArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetBusinessAccountGiftSettings, args, cancellationToken);
    }

    /// <summary>
    /// Changes the privacy settings pertaining to incoming gifts in a managed business account. Requires the <em>can_change_gift_settings</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="showGiftButton">Pass <em>True</em>, if a button for sending a gift to the user or by the business account must always be shown in the input field</param>
    /// <param name="acceptedGiftTypes">Types of gifts accepted by the business account</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetBusinessAccountGiftSettings(this ITelegramBotClient client, string businessConnectionId, bool showGiftButton, AcceptedGiftTypes acceptedGiftTypes) =>
        client.SetBusinessAccountGiftSettingsAsync(businessConnectionId, showGiftButton, acceptedGiftTypes).GetAwaiter().GetResult();

    /// <summary>
    /// Changes the privacy settings pertaining to incoming gifts in a managed business account. Requires the <em>can_change_gift_settings</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection</param>
    /// <param name="showGiftButton">Pass <em>True</em>, if a button for sending a gift to the user or by the business account must always be shown in the input field</param>
    /// <param name="acceptedGiftTypes">Types of gifts accepted by the business account</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetBusinessAccountGiftSettingsAsync(this ITelegramBotClient client, string businessConnectionId, bool showGiftButton, AcceptedGiftTypes acceptedGiftTypes, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.ShowGiftButton, showGiftButton },
            { PropertyNames.AcceptedGiftTypes, acceptedGiftTypes ?? throw new ArgumentNullException(nameof(acceptedGiftTypes)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.SetBusinessAccountGiftSettings, args, cancellationToken);
    }
}
