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
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "ForwardMessage" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message ForwardMessage(this ITelegramBotClient client, ForwardMessageArgs args) =>
        client.ForwardMessageAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "ForwardMessage" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> ForwardMessageAsync(this ITelegramBotClient client, ForwardMessageArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Message>(MethodNames.ForwardMessage, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message ForwardMessage(this ITelegramBotClient client, long chatId, long fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessageAsync(chatId, fromChatId, messageId, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> ForwardMessageAsync(this ITelegramBotClient client, long chatId, long fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.FromChatId, fromChatId },
            { PropertyNames.MessageId, messageId }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }

        return client.CallMethodAsync<Message>(MethodNames.ForwardMessage, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message ForwardMessage(this ITelegramBotClient client, long chatId, string fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessageAsync(chatId, fromChatId, messageId, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> ForwardMessageAsync(this ITelegramBotClient client, long chatId, string fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.FromChatId, fromChatId ?? throw new ArgumentNullException(nameof(fromChatId)) },
            { PropertyNames.MessageId, messageId }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }

        return client.CallMethodAsync<Message>(MethodNames.ForwardMessage, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message ForwardMessage(this ITelegramBotClient client, string chatId, long fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessageAsync(chatId, fromChatId, messageId, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> ForwardMessageAsync(this ITelegramBotClient client, string chatId, long fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.FromChatId, fromChatId },
            { PropertyNames.MessageId, messageId }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }

        return client.CallMethodAsync<Message>(MethodNames.ForwardMessage, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message ForwardMessage(this ITelegramBotClient client, string chatId, string fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessageAsync(chatId, fromChatId, messageId, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward messages of any kind. Service messages and messages with protected content can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageId">Message identifier in the chat specified in <em>from_chat_id</em></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded message from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> ForwardMessageAsync(this ITelegramBotClient client, string chatId, string fromChatId, int messageId, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.FromChatId, fromChatId ?? throw new ArgumentNullException(nameof(fromChatId)) },
            { PropertyNames.MessageId, messageId }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }

        return client.CallMethodAsync<Message>(MethodNames.ForwardMessage, args, cancellationToken);
    }
}
