// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to edit a checklist on behalf of a connected business account. On success, the edited <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageChecklist" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message EditMessageChecklist(this ITelegramBotClient client, EditMessageChecklistArgs args) =>
        client.EditMessageChecklistAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit a checklist on behalf of a connected business account. On success, the edited <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageChecklist" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> EditMessageChecklistAsync(this ITelegramBotClient client, EditMessageChecklistArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Message>(MethodNames.EditMessageChecklist, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit a checklist on behalf of a connected business account. On success, the edited <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="chatId">Unique identifier for the target chat</param>
    /// <param name="messageId">Unique identifier for the target message</param>
    /// <param name="checklist">A JSON-serialized object for the new checklist</param>
    /// <param name="replyMarkup">A JSON-serialized object for the new inline keyboard for the message</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message EditMessageChecklist(this ITelegramBotClient client, string businessConnectionId, long chatId, int messageId, InputChecklist checklist, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageChecklistAsync(businessConnectionId, chatId, messageId, checklist, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit a checklist on behalf of a connected business account. On success, the edited <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="chatId">Unique identifier for the target chat</param>
    /// <param name="messageId">Unique identifier for the target message</param>
    /// <param name="checklist">A JSON-serialized object for the new checklist</param>
    /// <param name="replyMarkup">A JSON-serialized object for the new inline keyboard for the message</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> EditMessageChecklistAsync(this ITelegramBotClient client, string businessConnectionId, long chatId, int messageId, InputChecklist checklist, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.BusinessConnectionId, businessConnectionId ?? throw new ArgumentNullException(nameof(businessConnectionId)) },
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId },
            { PropertyNames.Checklist, checklist ?? throw new ArgumentNullException(nameof(checklist)) }
        };
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.EditMessageChecklist, args, cancellationToken);
    }
}
