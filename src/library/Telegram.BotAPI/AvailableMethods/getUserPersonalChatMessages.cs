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
    /// Use this method to get the last messages from the personal chat (i.e., the chat currently added to their profile) of a given user. On success, an array of <see cref="Message"/> objects is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier for the target user</param>
    /// <param name="limit">The maximum number of messages to return; 1-20</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Message> GetUserPersonalChatMessages(
        this ITelegramBotClient client,
        long userId,
        int limit
    ) => client.GetUserPersonalChatMessagesAsync(userId, limit).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to get the last messages from the personal chat (i.e., the chat currently added to their profile) of a given user. On success, an array of <see cref="Message"/> objects is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="userId">Unique identifier for the target user</param>
    /// <param name="limit">The maximum number of messages to return; 1-20</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Message>> GetUserPersonalChatMessagesAsync(
        this ITelegramBotClient client,
        long userId,
        int limit,
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
            { PropertyNames.Limit, limit },
        };

        return client.CallMethodAsync<IEnumerable<Message>>(
            MethodNames.GetUserPersonalChatMessages,
            args,
            cancellationToken
        );
    }
}
