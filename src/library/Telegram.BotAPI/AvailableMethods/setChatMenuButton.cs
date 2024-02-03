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
    /// Use this method to change the bot's menu button in a private chat, or the default menu button. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetChatMenuButton" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetChatMenuButton(this ITelegramBotClient client, SetChatMenuButtonArgs args) =>
        client.SetChatMenuButtonAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the bot's menu button in a private chat, or the default menu button. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SetChatMenuButton" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetChatMenuButtonAsync(this ITelegramBotClient client, SetChatMenuButtonArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.SetChatMenuButton, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to change the bot's menu button in a private chat, or the default menu button. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be changed</param>
    /// <param name="menuButton">A JSON-serialized object for the bot's new menu button. Defaults to <see cref="MenuButtonDefault"/></param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SetChatMenuButton(this ITelegramBotClient client, long? chatId = null, MenuButton? menuButton = null) =>
        client.SetChatMenuButtonAsync(chatId, menuButton).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to change the bot's menu button in a private chat, or the default menu button. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be changed</param>
    /// <param name="menuButton">A JSON-serialized object for the bot's new menu button. Defaults to <see cref="MenuButtonDefault"/></param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SetChatMenuButtonAsync(this ITelegramBotClient client, long? chatId = null, MenuButton? menuButton = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
        };
        if (chatId is not null)
        {
            args.Add(PropertyNames.ChatId, chatId);
        }
        if (menuButton is not null)
        {
            args.Add(PropertyNames.MenuButton, menuButton);
        }

        return client.CallMethodAsync<bool>(MethodNames.SetChatMenuButton, args, cancellationToken);
    }
}
