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
    /// Use this method to send a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>. Currently, in the production environment, widgets can be sent only to private chats, and sent widgets automatically have protected content and therefore can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendWidget" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendWidget(this ITelegramBotClient client, SendWidgetArgs args) =>
        client.SendWidgetAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>. Currently, in the production environment, widgets can be sent only to private chats, and sent widgets automatically have protected content and therefore can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendWidget" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendWidgetAsync(this ITelegramBotClient client, SendWidgetArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Message>(MethodNames.SendWidget, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>. Currently, in the production environment, widgets can be sent only to private chats, and sent widgets automatically have protected content and therefore can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of a forum; for forum supergroups and private chats of bots with forum topic mode enabled only</param>
    /// <param name="width">Width of the widget in logical pixels; omit if the widget must occupy the whole width of the message bubble. The width is clamped by the app to the range from 200 to the maximum width of the message bubble.</param>
    /// <param name="height">Height of the widget in logical pixels; omit if the height of the widget isn't fixed. The height is clamped by the app to the range 50-600.</param>
    /// <param name="publicData">Public data of the widget, 0-1024 bytes, which will be available wherever the widget is shown. If the widget is shared, then all messages with it will have the same public data.</param>
    /// <param name="chatData">Data of the widget, which is specific to the message, 0-1024 bytes</param>
    /// <param name="caption">Widget caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the widget caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="showCaptionAboveMedia">Pass <em>True</em> if the caption must be shown above the widget</param>
    /// <param name="allowQueries">Pass <em>True</em> to allow the widget to send queries to the bot</param>
    /// <param name="isShared">Pass <em>True</em> to create a shared widget, which can be sent again using the method <a href="https://core.telegram.org/bots/api#sendsharedwidget">sendSharedWidget</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance.</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendWidget(this ITelegramBotClient client, long chatId, string html, int? messageThreadId = null, int? width = null, int? height = null, string? publicData = null, string? chatData = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? showCaptionAboveMedia = null, bool? allowQueries = null, bool? isShared = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null) =>
        client.SendWidgetAsync(chatId, html, messageThreadId, width, height, publicData, chatData, caption, parseMode, captionEntities, showCaptionAboveMedia, allowQueries, isShared, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>. Currently, in the production environment, widgets can be sent only to private chats, and sent widgets automatically have protected content and therefore can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of a forum; for forum supergroups and private chats of bots with forum topic mode enabled only</param>
    /// <param name="width">Width of the widget in logical pixels; omit if the widget must occupy the whole width of the message bubble. The width is clamped by the app to the range from 200 to the maximum width of the message bubble.</param>
    /// <param name="height">Height of the widget in logical pixels; omit if the height of the widget isn't fixed. The height is clamped by the app to the range 50-600.</param>
    /// <param name="publicData">Public data of the widget, 0-1024 bytes, which will be available wherever the widget is shown. If the widget is shared, then all messages with it will have the same public data.</param>
    /// <param name="chatData">Data of the widget, which is specific to the message, 0-1024 bytes</param>
    /// <param name="caption">Widget caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the widget caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="showCaptionAboveMedia">Pass <em>True</em> if the caption must be shown above the widget</param>
    /// <param name="allowQueries">Pass <em>True</em> to allow the widget to send queries to the bot</param>
    /// <param name="isShared">Pass <em>True</em> to create a shared widget, which can be sent again using the method <a href="https://core.telegram.org/bots/api#sendsharedwidget">sendSharedWidget</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance.</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendWidgetAsync(this ITelegramBotClient client, long chatId, string html, int? messageThreadId = null, int? width = null, int? height = null, string? publicData = null, string? chatData = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? showCaptionAboveMedia = null, bool? allowQueries = null, bool? isShared = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Html, html ?? throw new ArgumentNullException(nameof(html)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (width is not null)
        {
            args.Add(PropertyNames.Width, width);
        }
        if (height is not null)
        {
            args.Add(PropertyNames.Height, height);
        }
        if (publicData is not null)
        {
            args.Add(PropertyNames.PublicData, publicData);
        }
        if (chatData is not null)
        {
            args.Add(PropertyNames.ChatData, chatData);
        }
        if (caption is not null)
        {
            args.Add(PropertyNames.Caption, caption);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (captionEntities is not null)
        {
            args.Add(PropertyNames.CaptionEntities, captionEntities);
        }
        if (showCaptionAboveMedia is not null)
        {
            args.Add(PropertyNames.ShowCaptionAboveMedia, showCaptionAboveMedia);
        }
        if (allowQueries is not null)
        {
            args.Add(PropertyNames.AllowQueries, allowQueries);
        }
        if (isShared is not null)
        {
            args.Add(PropertyNames.IsShared, isShared);
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
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.SendWidget, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>. Currently, in the production environment, widgets can be sent only to private chats, and sent widgets automatically have protected content and therefore can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of a forum; for forum supergroups and private chats of bots with forum topic mode enabled only</param>
    /// <param name="width">Width of the widget in logical pixels; omit if the widget must occupy the whole width of the message bubble. The width is clamped by the app to the range from 200 to the maximum width of the message bubble.</param>
    /// <param name="height">Height of the widget in logical pixels; omit if the height of the widget isn't fixed. The height is clamped by the app to the range 50-600.</param>
    /// <param name="publicData">Public data of the widget, 0-1024 bytes, which will be available wherever the widget is shown. If the widget is shared, then all messages with it will have the same public data.</param>
    /// <param name="chatData">Data of the widget, which is specific to the message, 0-1024 bytes</param>
    /// <param name="caption">Widget caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the widget caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="showCaptionAboveMedia">Pass <em>True</em> if the caption must be shown above the widget</param>
    /// <param name="allowQueries">Pass <em>True</em> to allow the widget to send queries to the bot</param>
    /// <param name="isShared">Pass <em>True</em> to create a shared widget, which can be sent again using the method <a href="https://core.telegram.org/bots/api#sendsharedwidget">sendSharedWidget</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance.</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendWidget(this ITelegramBotClient client, string chatId, string html, int? messageThreadId = null, int? width = null, int? height = null, string? publicData = null, string? chatData = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? showCaptionAboveMedia = null, bool? allowQueries = null, bool? isShared = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null) =>
        client.SendWidgetAsync(chatId, html, messageThreadId, width, height, publicData, chatData, caption, parseMode, captionEntities, showCaptionAboveMedia, allowQueries, isShared, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send a message with an <a href="https://core.telegram.org/bots/widgets">HTML widget</a>. Currently, in the production environment, widgets can be sent only to private chats, and sent widgets automatically have protected content and therefore can't be forwarded. On success, the sent <see cref="Message"/> is returned.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup in the format <em>@username</em></param>
    /// <param name="html">HTML code of the widget, 1-32768 bytes. The code must not exceed 4096 bytes when compressed by zlib with the maximum compression level.</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of a forum; for forum supergroups and private chats of bots with forum topic mode enabled only</param>
    /// <param name="width">Width of the widget in logical pixels; omit if the widget must occupy the whole width of the message bubble. The width is clamped by the app to the range from 200 to the maximum width of the message bubble.</param>
    /// <param name="height">Height of the widget in logical pixels; omit if the height of the widget isn't fixed. The height is clamped by the app to the range 50-600.</param>
    /// <param name="publicData">Public data of the widget, 0-1024 bytes, which will be available wherever the widget is shown. If the widget is shared, then all messages with it will have the same public data.</param>
    /// <param name="chatData">Data of the widget, which is specific to the message, 0-1024 bytes</param>
    /// <param name="caption">Widget caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the widget caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="showCaptionAboveMedia">Pass <em>True</em> if the caption must be shown above the widget</param>
    /// <param name="allowQueries">Pass <em>True</em> to allow the widget to send queries to the bot</param>
    /// <param name="isShared">Pass <em>True</em> to create a shared widget, which can be sent again using the method <a href="https://core.telegram.org/bots/api#sendsharedwidget">sendSharedWidget</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance.</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendWidgetAsync(this ITelegramBotClient client, string chatId, string html, int? messageThreadId = null, int? width = null, int? height = null, string? publicData = null, string? chatData = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? showCaptionAboveMedia = null, bool? allowQueries = null, bool? isShared = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Html, html ?? throw new ArgumentNullException(nameof(html)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (width is not null)
        {
            args.Add(PropertyNames.Width, width);
        }
        if (height is not null)
        {
            args.Add(PropertyNames.Height, height);
        }
        if (publicData is not null)
        {
            args.Add(PropertyNames.PublicData, publicData);
        }
        if (chatData is not null)
        {
            args.Add(PropertyNames.ChatData, chatData);
        }
        if (caption is not null)
        {
            args.Add(PropertyNames.Caption, caption);
        }
        if (parseMode is not null)
        {
            args.Add(PropertyNames.ParseMode, parseMode);
        }
        if (captionEntities is not null)
        {
            args.Add(PropertyNames.CaptionEntities, captionEntities);
        }
        if (showCaptionAboveMedia is not null)
        {
            args.Add(PropertyNames.ShowCaptionAboveMedia, showCaptionAboveMedia);
        }
        if (allowQueries is not null)
        {
            args.Add(PropertyNames.AllowQueries, allowQueries);
        }
        if (isShared is not null)
        {
            args.Add(PropertyNames.IsShared, isShared);
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
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.SendWidget, args, cancellationToken);
    }
}
