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
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendAudio" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendAudio(this ITelegramBotClient client, SendAudioArgs args) =>
        client.SendAudioAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendAudio" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendAudioAsync(this ITelegramBotClient client, SendAudioArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Message>(MethodNames.SendAudio, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendAudio(this ITelegramBotClient client, long chatId, InputFile audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null) =>
        client.SendAudioAsync(chatId, audio, businessConnectionId, messageThreadId, caption, parseMode, captionEntities, duration, performer, title, thumbnail, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendAudioAsync(this ITelegramBotClient client, long chatId, InputFile audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Audio, audio ?? throw new ArgumentNullException(nameof(audio)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
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
        if (duration is not null)
        {
            args.Add(PropertyNames.Duration, duration);
        }
        if (performer is not null)
        {
            args.Add(PropertyNames.Performer, performer);
        }
        if (title is not null)
        {
            args.Add(PropertyNames.Title, title);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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

        return client.CallMethodAsync<Message>(MethodNames.SendAudio, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendAudio(this ITelegramBotClient client, long chatId, string audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null) =>
        client.SendAudioAsync(chatId, audio, businessConnectionId, messageThreadId, caption, parseMode, captionEntities, duration, performer, title, thumbnail, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters, replyMarkup, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendAudioAsync(this ITelegramBotClient client, long chatId, string audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Audio, audio ?? throw new ArgumentNullException(nameof(audio)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
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
        if (duration is not null)
        {
            args.Add(PropertyNames.Duration, duration);
        }
        if (performer is not null)
        {
            args.Add(PropertyNames.Performer, performer);
        }
        if (title is not null)
        {
            args.Add(PropertyNames.Title, title);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<Message>(MethodNames.SendAudio, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendAudio(this ITelegramBotClient client, string chatId, InputFile audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null) =>
        client.SendAudioAsync(chatId, audio, businessConnectionId, messageThreadId, caption, parseMode, captionEntities, duration, performer, title, thumbnail, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendAudioAsync(this ITelegramBotClient client, string chatId, InputFile audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, InputFile? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Audio, audio ?? throw new ArgumentNullException(nameof(audio)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
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
        if (duration is not null)
        {
            args.Add(PropertyNames.Duration, duration);
        }
        if (performer is not null)
        {
            args.Add(PropertyNames.Performer, performer);
        }
        if (title is not null)
        {
            args.Add(PropertyNames.Title, title);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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

        return client.CallMethodAsync<Message>(MethodNames.SendAudio, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendAudio(this ITelegramBotClient client, string chatId, string audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null) =>
        client.SendAudioAsync(chatId, audio, businessConnectionId, messageThreadId, caption, parseMode, captionEntities, duration, performer, title, thumbnail, disableNotification, protectContent, allowPaidBroadcast, messageEffectId, replyParameters, replyMarkup, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send audio files, if you want Telegram clients to display them in the music player. Your audio must be in the .MP3 or .M4A format. On success, the sent <see cref="Message"/> is returned. Bots can currently send audio files of up to 50 MB in size, this limit may be changed in the future.
    /// For sending voice messages, use the <a href="https://core.telegram.org/bots/api#sendvoice">sendVoice</a> method instead.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="audio">Audio file to send. Pass a file_id as String to send an audio file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an audio file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="businessConnectionId">Unique identifier of the business connection on behalf of which the message will be sent</param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="caption">Audio caption, 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the audio caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="duration">Duration of the audio in seconds</param>
    /// <param name="performer">Performer</param>
    /// <param name="title">Track name</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="allowPaidBroadcast">Pass <em>True</em> to allow up to 1000 messages per second, ignoring <a href="https://core.telegram.org/bots/faq#how-can-i-message-all-of-my-bot-39s-subscribers-at-once">broadcasting limits</a> for a fee of 0.1 Telegram Stars per message. The relevant Stars will be withdrawn from the bot's balance</param>
    /// <param name="messageEffectId">Unique identifier of the message effect to be added to the message; for private chats only</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove a reply keyboard or to force a reply from the user</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendAudioAsync(this ITelegramBotClient client, string chatId, string audio, string? businessConnectionId = null, int? messageThreadId = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, int? duration = null, string? performer = null, string? title = null, string? thumbnail = null, bool? disableNotification = null, bool? protectContent = null, bool? allowPaidBroadcast = null, string? messageEffectId = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Audio, audio ?? throw new ArgumentNullException(nameof(audio)) }
        };
        if (businessConnectionId is not null)
        {
            args.Add(PropertyNames.BusinessConnectionId, businessConnectionId);
        }
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
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
        if (duration is not null)
        {
            args.Add(PropertyNames.Duration, duration);
        }
        if (performer is not null)
        {
            args.Add(PropertyNames.Performer, performer);
        }
        if (title is not null)
        {
            args.Add(PropertyNames.Title, title);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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
        if (files is not null)
        {
            foreach (var file in files)
            {
                args.Add(file.Key, file.Value);
            }
        }

        return client.CallMethodAsync<Message>(MethodNames.SendAudio, args, cancellationToken);
    }
}
