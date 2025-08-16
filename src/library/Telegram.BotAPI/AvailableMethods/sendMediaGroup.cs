// Copyright (c) 2025 Quetzal Rivera.
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
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of <see cref="Message"/> objects that were sent is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendMediaGroup" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Message> SendMediaGroup(this ITelegramBotClient client, SendMediaGroupArgs args) =>
        client.SendMediaGroupAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of <see cref="Message"/> objects that were sent is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendMediaGroup" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Message>> SendMediaGroupAsync(this ITelegramBotClient client, SendMediaGroupArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of <see cref="Message"/> objects that were sent is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="directMessagesTopicId">Identifier of the direct messages topic to which the messages will be sent; required if the messages are sent to a direct messages chat</param>
    /// <param name="disableNotification">Sends messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Message> SendMediaGroup(this ITelegramBotClient client, long chatId, IEnumerable<InputMedia> media, string? businessConnectionId = null, int? messageThreadId = null, int? directMessagesTopicId = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null) =>
        client.SendMediaGroupAsync(chatId, media, businessConnectionId, messageThreadId, directMessagesTopicId, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of <see cref="Message"/> objects that were sent is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="directMessagesTopicId">Identifier of the direct messages topic to which the messages will be sent; required if the messages are sent to a direct messages chat</param>
    /// <param name="disableNotification">Sends messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Message>> SendMediaGroupAsync(this ITelegramBotClient client, long chatId, IEnumerable<InputMedia> media, string? businessConnectionId = null, int? messageThreadId = null, int? directMessagesTopicId = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Media, media ?? throw new ArgumentNullException(nameof(media)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (directMessagesTopicId is not null)
        {
            args.Add(PropertyNames.DirectMessagesTopicId, directMessagesTopicId);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }
        if (allowPaidBroadcast is not null)
        {
            args.Add(PropertyNames.AllowPaidBroadcast, allowPaidBroadcast);
        }
        if (messageEffectId is not null)
        {
            args.Add(PropertyNames.MessageEffectId, messageEffectId);
        }
        if (replyParameters is not null)
        {
            args.Add(PropertyNames.ReplyParameters, replyParameters);
        }

        return client.CallMethodAsync<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of <see cref="Message"/> objects that were sent is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="directMessagesTopicId">Identifier of the direct messages topic to which the messages will be sent; required if the messages are sent to a direct messages chat</param>
    /// <param name="disableNotification">Sends messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static IEnumerable<Message> SendMediaGroup(this ITelegramBotClient client, string chatId, IEnumerable<InputMedia> media, string? businessConnectionId = null, int? messageThreadId = null, int? directMessagesTopicId = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null) =>
        client.SendMediaGroupAsync(chatId, media, businessConnectionId, messageThreadId, directMessagesTopicId, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of <see cref="Message"/> objects that were sent is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="media">A JSON-serialized array describing messages to be sent, must include 2-10 items</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="directMessagesTopicId">Identifier of the direct messages topic to which the messages will be sent; required if the messages are sent to a direct messages chat</param>
    /// <param name="disableNotification">Sends messages <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<IEnumerable<Message>> SendMediaGroupAsync(this ITelegramBotClient client, string chatId, IEnumerable<InputMedia> media, string? businessConnectionId = null, int? messageThreadId = null, int? directMessagesTopicId = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Media, media ?? throw new ArgumentNullException(nameof(media)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (directMessagesTopicId is not null)
        {
            args.Add(PropertyNames.DirectMessagesTopicId, directMessagesTopicId);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }
        if (allowPaidBroadcast is not null)
        {
            args.Add(PropertyNames.AllowPaidBroadcast, allowPaidBroadcast);
        }
        if (messageEffectId is not null)
        {
            args.Add(PropertyNames.MessageEffectId, messageEffectId);
        }
        if (replyParameters is not null)
        {
            args.Add(PropertyNames.ReplyParameters, replyParameters);
        }

        return client.CallMethodAsync<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken);
    }
}
