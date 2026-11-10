// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.UpdatingMessages;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class UpdatingMessagesExtensions
{
    /// <summary>
    /// Use this method to edit data of a widget in a message sent by the bot or via the bot (for inline bots). Public data of a shared widget can be changed at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageWidgetData" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditMessageWidgetData(this ITelegramBotClient client, EditMessageWidgetDataArgs args) =>
        client.EditMessageWidgetDataAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit data of a widget in a message sent by the bot or via the bot (for inline bots). Public data of a shared widget can be changed at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "EditMessageWidgetData" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditMessageWidgetDataAsync(this ITelegramBotClient client, EditMessageWidgetDataArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<bool>(MethodNames.EditMessageWidgetData, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit data of a widget in a message sent by the bot or via the bot (for inline bots). Public data of a shared widget can be changed at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>.</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with the widget.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message.</param>
    /// <param name="publicData">New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data. If omitted, then the public data isn't changed.</param>
    /// <param name="chatData">New data of the widget, which is specific to the message, 0-1024 bytes; pass an empty string to remove the data. If omitted, then the data isn't changed.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditMessageWidgetData(this ITelegramBotClient client, long? chatId = null, int? messageId = null, string? inlineMessageId = null, string? publicData = null, string? chatData = null) =>
        client.EditMessageWidgetDataAsync(chatId, messageId, inlineMessageId, publicData, chatData).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit data of a widget in a message sent by the bot or via the bot (for inline bots). Public data of a shared widget can be changed at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>.</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with the widget.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message.</param>
    /// <param name="publicData">New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data. If omitted, then the public data isn't changed.</param>
    /// <param name="chatData">New data of the widget, which is specific to the message, 0-1024 bytes; pass an empty string to remove the data. If omitted, then the data isn't changed.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditMessageWidgetDataAsync(this ITelegramBotClient client, long? chatId = null, int? messageId = null, string? inlineMessageId = null, string? publicData = null, string? chatData = null, CancellationToken cancellationToken = default)
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
        if (messageId is not null)
        {
            args.Add(PropertyNames.MessageId, messageId);
        }
        if (inlineMessageId is not null)
        {
            args.Add(PropertyNames.InlineMessageId, inlineMessageId);
        }
        if (publicData is not null)
        {
            args.Add(PropertyNames.PublicData, publicData);
        }
        if (chatData is not null)
        {
            args.Add(PropertyNames.ChatData, chatData);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditMessageWidgetData, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to edit data of a widget in a message sent by the bot or via the bot (for inline bots). Public data of a shared widget can be changed at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>.</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with the widget.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message.</param>
    /// <param name="publicData">New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data. If omitted, then the public data isn't changed.</param>
    /// <param name="chatData">New data of the widget, which is specific to the message, 0-1024 bytes; pass an empty string to remove the data. If omitted, then the data isn't changed.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool EditMessageWidgetData(this ITelegramBotClient client, string? chatId = null, int? messageId = null, string? inlineMessageId = null, string? publicData = null, string? chatData = null) =>
        client.EditMessageWidgetDataAsync(chatId, messageId, inlineMessageId, publicData, chatData).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to edit data of a widget in a message sent by the bot or via the bot (for inline bots). Public data of a shared widget can be changed at most once per second. On success, <em>True</em> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Required if <em>inline_message_id</em> is not specified. Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em>.</param>
    /// <param name="messageId">Required if <em>inline_message_id</em> is not specified. Identifier of the message with the widget.</param>
    /// <param name="inlineMessageId">Required if <em>chat_id</em> and <em>message_id</em> are not specified. Identifier of the inline message.</param>
    /// <param name="publicData">New public data of the widget, 0-1024 bytes; pass an empty string to remove the public data. If omitted, then the public data isn't changed.</param>
    /// <param name="chatData">New data of the widget, which is specific to the message, 0-1024 bytes; pass an empty string to remove the data. If omitted, then the data isn't changed.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> EditMessageWidgetDataAsync(this ITelegramBotClient client, string? chatId = null, int? messageId = null, string? inlineMessageId = null, string? publicData = null, string? chatData = null, CancellationToken cancellationToken = default)
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
        if (messageId is not null)
        {
            args.Add(PropertyNames.MessageId, messageId);
        }
        if (inlineMessageId is not null)
        {
            args.Add(PropertyNames.InlineMessageId, inlineMessageId);
        }
        if (publicData is not null)
        {
            args.Add(PropertyNames.PublicData, publicData);
        }
        if (chatData is not null)
        {
            args.Add(PropertyNames.ChatData, chatData);
        }

        return client.CallMethodAsync<bool>(MethodNames.EditMessageWidgetData, args, cancellationToken);
    }
}
