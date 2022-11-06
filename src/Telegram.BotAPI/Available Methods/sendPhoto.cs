// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendPhoto(this BotClient bot, SendPhotoArgs args)
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<Message>(MethodNames.SendPhoto, args);
        }

        /// <summary>Use this method to send photos. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendPhotoAsync(this BotClient bot, SendPhotoArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendPhoto(this BotClient api, long chatId, InputFile photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendPhoto, args);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendPhoto(this BotClient api, long chatId, string photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendPhoto, args);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendPhoto(this BotClient api, string chatId, InputFile photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendPhoto, args);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendPhoto(this BotClient api, string chatId, string photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendPhoto, args);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendPhotoAsync(this BotClient api, long chatId, InputFile photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendPhotoAsync(this BotClient api, long chatId, string photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendPhotoAsync(this BotClient api, string chatId, InputFile photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send photos. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="photo">Photo to send. Pass a file_id as String to send a photo that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a photo from the Internet, or upload a new photo using multipart/form-data. The photo must be at most 10 MB in size. The photo's width and height must not exceed 10000 in total. Width and height ratio must be at most 20. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="caption">Photo caption (may also be used when resending photos by file_id), 0-1024 characters after entities parsing.</param>
        /// <param name="parseMode">Mode for parsing entities in the photo caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the caption, which can be specified instead of parse_mode.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendPhotoAsync(this BotClient api, string chatId, string photo, [Optional] int? messageThreadId, [Optional] string? caption, [Optional] string? parseMode, [Optional] IEnumerable<MessageEntity>? captionEntities, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendPhotoArgs(chatId, photo)
            {
                MessageThreadId = messageThreadId,
                Caption = caption,
                ParseMode = parseMode,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendPhoto, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
