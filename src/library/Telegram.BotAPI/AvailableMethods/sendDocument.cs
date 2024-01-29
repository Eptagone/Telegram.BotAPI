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
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendDocument" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendDocument(this ITelegramBotClient client, SendDocumentArgs args)
        => client.SendDocumentAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "SendDocument" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendDocumentAsync(this ITelegramBotClient client, SendDocumentArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendDocument(this ITelegramBotClient client, long chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
        => client.SendDocumentAsync(chatId, document, messageThreadId, thumbnail, caption, parseMode, captionEntities, disableContentTypeDetection, disableNotification, protectContent, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendDocumentAsync(this ITelegramBotClient client, long chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Document, document ?? throw new ArgumentNullException(nameof(document)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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
        if (disableContentTypeDetection is not null)
        {
            args.Add(PropertyNames.DisableContentTypeDetection, disableContentTypeDetection);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }
        if (replyParameters is not null)
        {
            args.Add(PropertyNames.ReplyParameters, replyParameters);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendDocument(this ITelegramBotClient client, long chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null)
        => client.SendDocumentAsync(chatId, document, messageThreadId, thumbnail, caption, parseMode, captionEntities, disableContentTypeDetection, disableNotification, protectContent, replyParameters, replyMarkup, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendDocumentAsync(this ITelegramBotClient client, long chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId },
            { PropertyNames.Document, document ?? throw new ArgumentNullException(nameof(document)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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
        if (disableContentTypeDetection is not null)
        {
            args.Add(PropertyNames.DisableContentTypeDetection, disableContentTypeDetection);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
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

        return client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendDocument(this ITelegramBotClient client, string chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null)
        => client.SendDocumentAsync(chatId, document, messageThreadId, thumbnail, caption, parseMode, captionEntities, disableContentTypeDetection, disableNotification, protectContent, replyParameters, replyMarkup).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendDocumentAsync(this ITelegramBotClient client, string chatId, InputFile document, int? messageThreadId = null, InputFile? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Document, document ?? throw new ArgumentNullException(nameof(document)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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
        if (disableContentTypeDetection is not null)
        {
            args.Add(PropertyNames.DisableContentTypeDetection, disableContentTypeDetection);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
        }
        if (replyParameters is not null)
        {
            args.Add(PropertyNames.ReplyParameters, replyParameters);
        }
        if (replyMarkup is not null)
        {
            args.Add(PropertyNames.ReplyMarkup, replyMarkup);
        }

        return client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <param name="files">The files to upload.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Message SendDocument(this ITelegramBotClient client, string chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null)
        => client.SendDocumentAsync(chatId, document, messageThreadId, thumbnail, caption, parseMode, captionEntities, disableContentTypeDetection, disableNotification, protectContent, replyParameters, replyMarkup, files).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to send general files. On success, the sent <see cref="Message"/> is returned. Bots can currently send files of any type of up to 50 MB in size, this limit may be changed in the future.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <code>@channelusername</code>)</param>
    /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only</param>
    /// <param name="thumbnail">Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;. <a href="https://core.telegram.org/bots/api#sending-files">More information on Sending Files »</a></param>
    /// <param name="caption">Document caption (may also be used when resending documents by <em>file_id</em>), 0-1024 characters after entities parsing</param>
    /// <param name="parseMode">Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</param>
    /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of <em>parse_mode</em></param>
    /// <param name="disableContentTypeDetection">Disables automatic server-side content type detection for files uploaded using multipart/form-data</param>
    /// <param name="disableNotification">Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
    /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving</param>
    /// <param name="replyParameters">Description of the message to reply to</param>
    /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>, <a href="https://core.telegram.org/bots/features#keyboards">custom reply keyboard</a>, instructions to remove reply keyboard or to force a reply from the user.</param>
    /// <param name="files">The files to upload.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<Message> SendDocumentAsync(this ITelegramBotClient client, string chatId, string document, int? messageThreadId = null, string? thumbnail = null, string? caption = null, string? parseMode = null, IEnumerable<MessageEntity>? captionEntities = null, bool? disableContentTypeDetection = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, ReplyMarkup? replyMarkup = null, IDictionary<string, InputFile>? files = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.ChatId, chatId ?? throw new ArgumentNullException(nameof(chatId)) },
            { PropertyNames.Document, document ?? throw new ArgumentNullException(nameof(document)) }
        };
        if (messageThreadId is not null)
        {
            args.Add(PropertyNames.MessageThreadId, messageThreadId);
        }
        if (thumbnail is not null)
        {
            args.Add(PropertyNames.Thumbnail, thumbnail);
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
        if (disableContentTypeDetection is not null)
        {
            args.Add(PropertyNames.DisableContentTypeDetection, disableContentTypeDetection);
        }
        if (disableNotification is not null)
        {
            args.Add(PropertyNames.DisableNotification, disableNotification);
        }
        if (protectContent is not null)
        {
            args.Add(PropertyNames.ProtectContent, protectContent);
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

        return client.CallMethodAsync<Message>(MethodNames.SendDocument, args, cancellationToken);
    }
}
