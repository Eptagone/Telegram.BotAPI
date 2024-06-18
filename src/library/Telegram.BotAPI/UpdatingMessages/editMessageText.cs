// Copyright (c) 2024 Quetzal Rivera.
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
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageText" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static TResult EditMessageText<TResult>(this ITelegramBotClient client, EditMessageTextArgs args) =>
        client.EditMessageTextAsync<TResult>(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageText" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<TResult> EditMessageTextAsync<TResult>(this ITelegramBotClient client, EditMessageTextArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<TResult>(MethodNames.EditMessageText, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message EditMessageText(this ITelegramBotClient client, long chatId, int messageId, string text, string? businessConnectionId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageTextAsync(chatId, messageId, text, businessConnectionId, parseMode, entities, linkPreviewOptions, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> EditMessageTextAsync(this ITelegramBotClient client, long chatId, int messageId, string text, string? businessConnectionId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.MessageId, messageId },
            { PropertyNames.Text, text ?? throw new ArgumentNullException(nameof(text)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (entities is not null)
        {
            args.Add(PropertyNames.Entities, entities);
        }
        if (linkPreviewOptions is not null)
        {
            args.Add(PropertyNames.LinkPreviewOptions, linkPreviewOptions);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.EditMessageText, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message EditMessageText(this ITelegramBotClient client, string chatId, int messageId, string text, string? businessConnectionId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageTextAsync(chatId, messageId, text, businessConnectionId, parseMode, entities, linkPreviewOptions, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> EditMessageTextAsync(this ITelegramBotClient client, string chatId, int messageId, string text, string? businessConnectionId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.MessageId, messageId },
            { PropertyNames.Text, text ?? throw new ArgumentNullException(nameof(text)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (entities is not null)
        {
            args.Add(PropertyNames.Entities, entities);
        }
        if (linkPreviewOptions is not null)
        {
            args.Add(PropertyNames.LinkPreviewOptions, linkPreviewOptions);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.EditMessageText, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditMessageText(this ITelegramBotClient client, string inlineMessageId, string text, string? businessConnectionId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null) =>
        client.EditMessageTextAsync(inlineMessageId, text, businessConnectionId, parseMode, entities, linkPreviewOptions, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit text and <a href="https://core.telegram.org/bots/api#games">game</a> messages. On success, if the edited message is not an inline message, the edited <see cref="Message"/> is returned, otherwise <em>True</em> is returned. Note that business messages that were not sent by the bot and do not contain an inline keyboard can only be edited within <strong>48 hours</strong> from the time they were sent.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message</param>
    /// <param name="text">New text of the message, 1-4096 characters after entities parsing</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message to be edited was sent</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditMessageTextAsync(this ITelegramBotClient client, string inlineMessageId, string text, string? businessConnectionId = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.InlineMessageId, inlineMessageId ?? throw new ArgumentNullException(nameof(inlineMessageId)) },
            { PropertyNames.Text, text ?? throw new ArgumentNullException(nameof(text)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (entities is not null)
        {
            args.Add(PropertyNames.Entities, entities);
        }
        if (linkPreviewOptions is not null)
        {
            args.Add(PropertyNames.LinkPreviewOptions, linkPreviewOptions);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditMessageText, args, cancellationToken);
    }
}
