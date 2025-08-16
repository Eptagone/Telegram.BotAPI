// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Delete messages on behalf of a business account. Requires the <em>can_delete_sent_messages</em> business bot right to delete messages sent by the bot itself, or the <em>can_delete_all_messages</em> business bot right to delete any message. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "DeleteBusinessMessages" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteBusinessMessages(this ITelegramBotClient client, DeleteBusinessMessagesArgs args) =>
        client.DeleteBusinessMessagesAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Delete messages on behalf of a business account. Requires the <em>can_delete_sent_messages</em> business bot right to delete messages sent by the bot itself, or the <em>can_delete_all_messages</em> business bot right to delete any message. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "DeleteBusinessMessages" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteBusinessMessagesAsync(this ITelegramBotClient client, DeleteBusinessMessagesArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.DeleteBusinessMessages, args, cancellationToken);
    }

    /// <summary>
    /// Delete messages on behalf of a business account. Requires the <em>can_delete_sent_messages</em> business bot right to delete messages sent by the bot itself, or the <em>can_delete_all_messages</em> business bot right to delete any message. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which to delete the messages</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. All messages must be from the same chat. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool DeleteBusinessMessages(this ITelegramBotClient client, string businessConnectionId, IEnumerable<int> messageIds) =>
        client.DeleteBusinessMessagesAsync(businessConnectionId, messageIds).GetAwaiter().GetResult();

    /// <summary>
    /// Delete messages on behalf of a business account. Requires the <em>can_delete_sent_messages</em> business bot right to delete messages sent by the bot itself, or the <em>can_delete_all_messages</em> business bot right to delete any message. Returns <em>True</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which to delete the messages</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages to delete. All messages must be from the same chat. See <a href="https://core.telegram.org/bots/api#deletemessage">deleteMessage</a> for limitations on which messages can be deleted</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> DeleteBusinessMessagesAsync(this ITelegramBotClient client, string businessConnectionId, IEnumerable<int> messageIds, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
        };

        return client.CallMethodAsync<bool>(MethodNames.DeleteBusinessMessages, args, cancellationToken);
    }
}
