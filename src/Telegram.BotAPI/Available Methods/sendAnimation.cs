// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, SendAnimationArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return args.UseMultipart() ? bot.RPCF<Message>(MethodNames.SendAnimation, args) : bot.RPC<Message>(MethodNames.SendAnimation, args);
        }
        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, string chatId, string animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, long chatId, string animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, string chatId, InputFile animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendAnimation(this BotClient bot, long chatId, InputFile animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            return bot.SendAnimation(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            });
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, SendAnimationArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await (args.UseMultipart() ? bot.RPCAF<Message>(MethodNames.SendAnimation, args, cancellationToken: cancellationToken).ConfigureAwait(false) : bot.RPCA<Message>(MethodNames.SendAnimation, args, cancellationToken: cancellationToken).ConfigureAwait(false));
        }
        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, string chatId, string animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="attachFiles">Attached files.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, long chatId, string animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] string thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] List<AttachFile> attachFiles, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
                AttachFiles = attachFiles
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, string chatId, InputFile animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send animation files (GIF or H.264/MPEG-4 AVC video without sound). On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        /// <param name="duration">Optional. Duration of sent animation in seconds.</param>
        /// <param name="width">Optional. Animation width.</param>
        /// <param name="height">Optional. Animation height.</param>
        /// <param name="thumb">Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></param>
        /// <param name="caption">Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</param>
        /// <param name="parseMode">Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</param>
        /// <param name="captionEntities">List of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Optional. Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">Optional. If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Optional. Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user. <see cref="InlineKeyboardMarkup"/> or <see cref="ReplyKeyboardMarkup"/> or <see cref="ReplyKeyboardRemove"/> or <see cref="ForceReply"/></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendAnimationAsync(this BotClient bot, long chatId, InputFile animation, [Optional] uint? duration, [Optional] uint? width, [Optional] uint? height, [Optional] InputFile thumb, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            return await bot.SendAnimationAsync(new SendAnimationArgs
            {
                ChatId = chatId,
                Animation = animation,
                Duration = duration,
                Width = width,
                Height = height,
                Thumb = thumb,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup,
            }, cancellationToken).ConfigureAwait(false);
        }
    }
}
