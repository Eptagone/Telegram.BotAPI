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
    /// Stores a keyboard button that can be used by a user within a Mini App. Returns a <see cref="PreparedKeyboardButton"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SavePreparedKeyboardButton" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static PreparedKeyboardButton SavePreparedKeyboardButton(
        this ITelegramBotClient client,
        SavePreparedKeyboardButtonArgs args
    ) => client.SavePreparedKeyboardButtonAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Stores a keyboard button that can be used by a user within a Mini App. Returns a <see cref="PreparedKeyboardButton"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SavePreparedKeyboardButton" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<PreparedKeyboardButton> SavePreparedKeyboardButtonAsync(
        this ITelegramBotClient client,
        SavePreparedKeyboardButtonArgs args,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<PreparedKeyboardButton>(
            MethodNames.SavePreparedKeyboardButton,
            args,
            cancellationToken
        );
    }

    /// <summary>
    /// Stores a keyboard button that can be used by a user within a Mini App. Returns a <see cref="PreparedKeyboardButton"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user that can use the button</param>
    /// <param name="button">A JSON-serialized object describing the button to be saved. The button must be of the type <em>request_users</em>, <em>request_chat</em>, or <em>request_managed_bot</em></param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static PreparedKeyboardButton SavePreparedKeyboardButton(
        this ITelegramBotClient client,
        long userId,
        KeyboardButton button
    ) => client.SavePreparedKeyboardButtonAsync(userId, button).GetAwaiter().GetResult();

    /// <summary>
    /// Stores a keyboard button that can be used by a user within a Mini App. Returns a <see cref="PreparedKeyboardButton"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier of the target user that can use the button</param>
    /// <param name="button">A JSON-serialized object describing the button to be saved. The button must be of the type <em>request_users</em>, <em>request_chat</em>, or <em>request_managed_bot</em></param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<PreparedKeyboardButton> SavePreparedKeyboardButtonAsync(
        this ITelegramBotClient client,
        long userId,
        KeyboardButton button,
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
            { PropertyNames.Button, button ?? throw new ArgumentNullException(nameof(button)) },
        };

        return client.CallMethodAsync<PreparedKeyboardButton>(
            MethodNames.SavePreparedKeyboardButton,
            args,
            cancellationToken
        );
    }
}
