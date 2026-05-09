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
    /// Use this method to get a list of administrators in a chat. Returns an Array of <see cref="ChatMember"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup or channel in the format <em>@username</em></param>
    /// <param name="returnBots">Pass <em>True</em> to additionally receive all bots that are administrators of the chat. By default, bots other than the current bot are omitted.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<ChatMember> GetChatAdministrators(
        this ITelegramBotClient client,
        long chatId,
        bool? returnBots = null
    ) => client.GetChatAdministratorsAsync(chatId, returnBots).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get a list of administrators in a chat. Returns an Array of <see cref="ChatMember"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup or channel in the format <em>@username</em></param>
    /// <param name="returnBots">Pass <em>True</em> to additionally receive all bots that are administrators of the chat. By default, bots other than the current bot are omitted.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<ChatMember>> GetChatAdministratorsAsync(
        this ITelegramBotClient client,
        long chatId,
        bool? returnBots = null,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>() { { PropertyNames.ChatId, chatId } };
        if (returnBots is not null)
        {
            args.Add(PropertyNames.ReturnBots, returnBots);
        }

        return client.CallMethodAsync<IEnumerable<ChatMember>>(
            MethodNames.GetChatAdministrators,
            args,
            cancellationToken
        );
    }

    /// <summary>
    /// Use this method to get a list of administrators in a chat. Returns an Array of <see cref="ChatMember"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup or channel in the format <em>@username</em></param>
    /// <param name="returnBots">Pass <em>True</em> to additionally receive all bots that are administrators of the chat. By default, bots other than the current bot are omitted.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<ChatMember> GetChatAdministrators(
        this ITelegramBotClient client,
        string chatId,
        bool? returnBots = null
    ) => client.GetChatAdministratorsAsync(chatId, returnBots).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get a list of administrators in a chat. Returns an Array of <see cref="ChatMember"/> objects.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup or channel in the format <em>@username</em></param>
    /// <param name="returnBots">Pass <em>True</em> to additionally receive all bots that are administrators of the chat. By default, bots other than the current bot are omitted.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<ChatMember>> GetChatAdministratorsAsync(
        this ITelegramBotClient client,
        string chatId,
        bool? returnBots = null,
        CancellationToken cancellationToken = default
    )
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
        };
        if (returnBots is not null)
        {
            args.Add(PropertyNames.ReturnBots, returnBots);
        }

        return client.CallMethodAsync<IEnumerable<ChatMember>>(
            MethodNames.GetChatAdministrators,
            args,
            cancellationToken
        );
    }
}
