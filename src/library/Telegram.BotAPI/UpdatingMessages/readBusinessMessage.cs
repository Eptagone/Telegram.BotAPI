// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Marks incoming message as read on behalf of a business account. Requires the <em>can_read_messages</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which to read the message</param>
    /// <param name="chatId">Unique identifier of the chat in which the message was received. The chat must have been active in the last 24 hours.</param>
    /// <param name="messageId">Unique identifier of the message to mark as read</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool ReadBusinessMessage(this ITelegramBotClient client, string businessConnectionId, long chatId, int messageId) =>
        client.ReadBusinessMessageAsync(businessConnectionId, chatId, messageId).GetAwaiter().GetResult();

    /// <summary>
    /// Marks incoming message as read on behalf of a business account. Requires the <em>can_read_messages</em> business bot right. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which to read the message</param>
    /// <param name="chatId">Unique identifier of the chat in which the message was received. The chat must have been active in the last 24 hours.</param>
    /// <param name="messageId">Unique identifier of the message to mark as read</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> ReadBusinessMessageAsync(this ITelegramBotClient client, string businessConnectionId, long chatId, int messageId, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId }
        };

        return client.CallMethodAsync<bool>(MethodNames.ReadBusinessMessage, args, cancellationToken);
    }
}
