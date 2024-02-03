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
    /// Use this method to get the current value of the bot's menu button in a private chat, or the default menu button. Returns <see cref="MenuButton"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be returned</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static MenuButton GetChatMenuButton(this ITelegramBotClient client, long? chatId = null) =>
        client.GetChatMenuButtonAsync(chatId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the current value of the bot's menu button in a private chat, or the default menu button. Returns <see cref="MenuButton"/> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target private chat. If not specified, default bot's menu button will be returned</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<MenuButton> GetChatMenuButtonAsync(this ITelegramBotClient client, long? chatId = null, CancellationToken cancellationToken = default)
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

        return client.CallMethodAsync<MenuButton>(MethodNames.GetChatMenuButton, args, cancellationToken);
    }
}
