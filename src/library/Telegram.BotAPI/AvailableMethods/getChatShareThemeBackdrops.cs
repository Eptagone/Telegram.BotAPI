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
    /// Use this method to get the list of backdrops, which can be used as the background of a theme of the screen for sharing a link to a user or a chat. Requires no parameters. Returns a <see cref="ChatShareThemeBackdrops"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static ChatShareThemeBackdrops GetChatShareThemeBackdrops(this ITelegramBotClient client) =>
        client.GetChatShareThemeBackdropsAsync().GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the list of backdrops, which can be used as the background of a theme of the screen for sharing a link to a user or a chat. Requires no parameters. Returns a <see cref="ChatShareThemeBackdrops"/> object.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<ChatShareThemeBackdrops> GetChatShareThemeBackdropsAsync(this ITelegramBotClient client, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<ChatShareThemeBackdrops>(MethodNames.GetChatShareThemeBackdrops, cancellationToken: cancellationToken);
    }
}
