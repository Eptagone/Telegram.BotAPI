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
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "ForwardMessages" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<MessageId> ForwardMessages(this ITelegramBotClient client, ForwardMessagesArgs args) =>
        client.ForwardMessagesAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "ForwardMessages" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<MessageId>> ForwardMessagesAsync(this ITelegramBotClient client, ForwardMessagesArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<IEnumerable<MessageId>>(MethodNames.ForwardMessages, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<MessageId> ForwardMessages(this ITelegramBotClient client, long chatId, long fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessagesAsync(chatId, fromChatId, messageIds, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<MessageId>> ForwardMessagesAsync(this ITelegramBotClient client, long chatId, long fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.FromChatId, fromChatId },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
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

        return client.CallMethodAsync<IEnumerable<MessageId>>(MethodNames.ForwardMessages, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<MessageId> ForwardMessages(this ITelegramBotClient client, long chatId, string fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessagesAsync(chatId, fromChatId, messageIds, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<MessageId>> ForwardMessagesAsync(this ITelegramBotClient client, long chatId, string fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.FromChatId, fromChatId ?? throw new ArgumentNullException(nameof(fromChatId)) },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
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

        return client.CallMethodAsync<IEnumerable<MessageId>>(MethodNames.ForwardMessages, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<MessageId> ForwardMessages(this ITelegramBotClient client, string chatId, long fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessagesAsync(chatId, fromChatId, messageIds, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<MessageId>> ForwardMessagesAsync(this ITelegramBotClient client, string chatId, long fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.FromChatId, fromChatId },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
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

        return client.CallMethodAsync<IEnumerable<MessageId>>(MethodNames.ForwardMessages, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<MessageId> ForwardMessages(this ITelegramBotClient client, string chatId, string fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null) =>
        client.ForwardMessagesAsync(chatId, fromChatId, messageIds, messageThreadId, disableNotification, protectContent).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to forward multiple messages of any kind. If some of the specified messages can't be found or forwarded, they are skipped. Service messages and messages with protected content can't be forwarded. Album grouping is kept for forwarded messages. On success, an array of <see cref="MessageId"/> of the sent messages is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="fromChatId">Unique identifier for the chat where the original messages were sent (or channel username in the format <em>@channelusername</em>)</param>
    /// <param name="messageIds">A JSON-serialized list of 1-100 identifiers of messages in the chat <em>from_chat_id</em> to forward. The identifiers must be specified in a strictly increasing order.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="disableNotification">Sends the messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the forwarded messages from forwarding and saving</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<MessageId>> ForwardMessagesAsync(this ITelegramBotClient client, string chatId, string fromChatId, IEnumerable<int> messageIds, int? messageThreadId = null, bool? disableNotification = null, bool? protectContent = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.FromChatId, fromChatId ?? throw new ArgumentNullException(nameof(fromChatId)) },
            { PropertyNames.MessageIds, messageIds ?? throw new ArgumentNullException(nameof(messageIds)) }
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

        return client.CallMethodAsync<IEnumerable<MessageId>>(MethodNames.ForwardMessages, args, cancellationToken);
    }
}
