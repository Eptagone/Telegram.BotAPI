// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableMethods;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class AvailableMethodsExtensions
{
    /// <summary>
    /// Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns <em>True</em> on success.
    /// We only recommend using this method when a response from the bot will take a <strong>noticeable</strong> amount of time to arrive.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: <em>typing</em> for <a href="https://core.telegram.org/bots/api#sendmessage">text messages</a>, <em>upload_photo</em> for <a href="https://core.telegram.org/bots/api#sendphoto">photos</a>, <em>record_video</em> or <em>upload_video</em> for <a href="https://core.telegram.org/bots/api#sendvideo">videos</a>, <em>record_voice</em> or <em>upload_voice</em> for <a href="https://core.telegram.org/bots/api#sendvoice">voice notes</a>, <em>upload_document</em> for <a href="https://core.telegram.org/bots/api#senddocument">general files</a>, <em>choose_sticker</em> for <a href="https://core.telegram.org/bots/api#sendsticker">stickers</a>, <em>find_location</em> for <a href="https://core.telegram.org/bots/api#sendlocation">location data</a>, <em>record_video_note</em> or <em>upload_video_note</em> for <a href="https://core.telegram.org/bots/api#sendvideonote">video notes</a>.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the action will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread; for supergroups only</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendChatAction(this ITelegramBotClient client, long chatId, string action, string? businessConnectionId = null, int? messageThreadId = null) =>
        client.SendChatActionAsync(chatId, action, businessConnectionId, messageThreadId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns <em>True</em> on success.
    /// We only recommend using this method when a response from the bot will take a <strong>noticeable</strong> amount of time to arrive.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: <em>typing</em> for <a href="https://core.telegram.org/bots/api#sendmessage">text messages</a>, <em>upload_photo</em> for <a href="https://core.telegram.org/bots/api#sendphoto">photos</a>, <em>record_video</em> or <em>upload_video</em> for <a href="https://core.telegram.org/bots/api#sendvideo">videos</a>, <em>record_voice</em> or <em>upload_voice</em> for <a href="https://core.telegram.org/bots/api#sendvoice">voice notes</a>, <em>upload_document</em> for <a href="https://core.telegram.org/bots/api#senddocument">general files</a>, <em>choose_sticker</em> for <a href="https://core.telegram.org/bots/api#sendsticker">stickers</a>, <em>find_location</em> for <a href="https://core.telegram.org/bots/api#sendlocation">location data</a>, <em>record_video_note</em> or <em>upload_video_note</em> for <a href="https://core.telegram.org/bots/api#sendvideonote">video notes</a>.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the action will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread; for supergroups only</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendChatActionAsync(this ITelegramBotClient client, long chatId, string action, string? businessConnectionId = null, int? messageThreadId = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Action, action ?? throw new ArgumentNullException(nameof(action)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }

        return client.CallMethodAsync<bool>(MethodNames.SendChatAction, args, cancellationToken);
    }

    /// <summary>
    /// Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns <em>True</em> on success.
    /// We only recommend using this method when a response from the bot will take a <strong>noticeable</strong> amount of time to arrive.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: <em>typing</em> for <a href="https://core.telegram.org/bots/api#sendmessage">text messages</a>, <em>upload_photo</em> for <a href="https://core.telegram.org/bots/api#sendphoto">photos</a>, <em>record_video</em> or <em>upload_video</em> for <a href="https://core.telegram.org/bots/api#sendvideo">videos</a>, <em>record_voice</em> or <em>upload_voice</em> for <a href="https://core.telegram.org/bots/api#sendvoice">voice notes</a>, <em>upload_document</em> for <a href="https://core.telegram.org/bots/api#senddocument">general files</a>, <em>choose_sticker</em> for <a href="https://core.telegram.org/bots/api#sendsticker">stickers</a>, <em>find_location</em> for <a href="https://core.telegram.org/bots/api#sendlocation">location data</a>, <em>record_video_note</em> or <em>upload_video_note</em> for <a href="https://core.telegram.org/bots/api#sendvideonote">video notes</a>.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the action will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread; for supergroups only</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static bool SendChatAction(this ITelegramBotClient client, string chatId, string action, string? businessConnectionId = null, int? messageThreadId = null) =>
        client.SendChatActionAsync(chatId, action, businessConnectionId, messageThreadId).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method when you need to tell the user that something is happening on the bot's side. The status is set for 5 seconds or less (when a message arrives from your bot, Telegram clients clear its typing status). Returns <em>True</em> on success.
    /// We only recommend using this method when a response from the bot will take a <strong>noticeable</strong> amount of time to arrive.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="action">Type of action to broadcast. Choose one, depending on what the user is about to receive: <em>typing</em> for <a href="https://core.telegram.org/bots/api#sendmessage">text messages</a>, <em>upload_photo</em> for <a href="https://core.telegram.org/bots/api#sendphoto">photos</a>, <em>record_video</em> or <em>upload_video</em> for <a href="https://core.telegram.org/bots/api#sendvideo">videos</a>, <em>record_voice</em> or <em>upload_voice</em> for <a href="https://core.telegram.org/bots/api#sendvoice">voice notes</a>, <em>upload_document</em> for <a href="https://core.telegram.org/bots/api#senddocument">general files</a>, <em>choose_sticker</em> for <a href="https://core.telegram.org/bots/api#sendsticker">stickers</a>, <em>find_location</em> for <a href="https://core.telegram.org/bots/api#sendlocation">location data</a>, <em>record_video_note</em> or <em>upload_video_note</em> for <a href="https://core.telegram.org/bots/api#sendvideonote">video notes</a>.</param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the action will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread; for supergroups only</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<bool> SendChatActionAsync(this ITelegramBotClient client, string chatId, string action, string? businessConnectionId = null, int? messageThreadId = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Action, action ?? throw new ArgumentNullException(nameof(action)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }

        return client.CallMethodAsync<bool>(MethodNames.SendChatAction, args, cancellationToken);
    }
}
