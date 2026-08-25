// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.RichMessages;

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to edit an ephemeral text or rich message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditEphemeralMessageText" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditEphemeralMessageText(this ITelegramBotClient client, EditEphemeralMessageTextArgs args) =>
        client.EditEphemeralMessageTextAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit an ephemeral text or rich message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditEphemeralMessageText" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditEphemeralMessageTextAsync(this ITelegramBotClient client, EditEphemeralMessageTextArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.EditEphemeralMessageText, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit an ephemeral text or rich message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entity parsing; required if <em>rich_message</em> isn't specified</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="richMessage">New rich content of the message; required if <em>text</em> isn't specified</param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditEphemeralMessageText(this ITelegramBotClient client, long chatId, long receiverUserId, int ephemeralMessageId, string? text = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, InputRichMessage? richMessage = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null) =>
        client.EditEphemeralMessageTextAsync(chatId, receiverUserId, ephemeralMessageId, text, parseMode, entities, richMessage, linkPreviewOptions, replyMarkup, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit an ephemeral text or rich message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entity parsing; required if <em>rich_message</em> isn't specified</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="richMessage">New rich content of the message; required if <em>text</em> isn't specified</param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditEphemeralMessageTextAsync(this ITelegramBotClient client, long chatId, long receiverUserId, int ephemeralMessageId, string? text = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, InputRichMessage? richMessage = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.ReceiverUserId, receiverUserId },
            { PropertyNames.EphemeralMessageId, ephemeralMessageId }
        };
        if (text is not null)
        {
            args.Add(PropertyNames.Text, text);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (entities is not null)
        {
            args.Add(PropertyNames.Entities, entities);
        }
        if (richMessage is not null)
        {
            args.Add(PropertyNames.RichMessage, richMessage);
        }
        if (linkPreviewOptions is not null)
        {
            args.Add(PropertyNames.LinkPreviewOptions, linkPreviewOptions);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<bool>(MethodNames.EditEphemeralMessageText, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit an ephemeral text or rich message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entity parsing; required if <em>rich_message</em> isn't specified</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="richMessage">New rich content of the message; required if <em>text</em> isn't specified</param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditEphemeralMessageText(this ITelegramBotClient client, string chatId, long receiverUserId, int ephemeralMessageId, string? text = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, InputRichMessage? richMessage = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null) =>
        client.EditEphemeralMessageTextAsync(chatId, receiverUserId, ephemeralMessageId, text, parseMode, entities, richMessage, linkPreviewOptions, replyMarkup, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit an ephemeral text or rich message. Note that it is not guaranteed that the user will receive the message edit event, especially if they are offline. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="receiverUserId">Identifier of the user who received the message</param>
    /// <param name="ephemeralMessageId">Identifier of the ephemeral message to edit</param>
    /// <param name="text">New text of the message, 1-4096 characters after entity parsing; required if <em>rich_message</em> isn't specified</param>
    /// <param name="parseMode">Mode for parsing entities in the message text. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="entities">A JSON-serialized list of special entities that appear in message text, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="richMessage">New rich content of the message; required if <em>text</em> isn't specified</param>
    /// <param name="linkPreviewOptions">Link preview generation options for the message</param>
    /// <param name="replyMarkup">A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a></param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditEphemeralMessageTextAsync(this ITelegramBotClient client, string chatId, long receiverUserId, int ephemeralMessageId, string? text = null, string? parseMode = null, IEnumerable<MessageEntity>? entities = null, InputRichMessage? richMessage = null, LinkPreviewOptions? linkPreviewOptions = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.ReceiverUserId, receiverUserId },
            { PropertyNames.EphemeralMessageId, ephemeralMessageId }
        };
        if (text is not null)
        {
            args.Add(PropertyNames.Text, text);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (entities is not null)
        {
            args.Add(PropertyNames.Entities, entities);
        }
        if (richMessage is not null)
        {
            args.Add(PropertyNames.RichMessage, richMessage);
        }
        if (linkPreviewOptions is not null)
        {
            args.Add(PropertyNames.LinkPreviewOptions, linkPreviewOptions);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<bool>(MethodNames.EditEphemeralMessageText, args, cancellationToken);
    }
}
