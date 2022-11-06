// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendSticker(this BotClient bot, SendStickerArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<Message>(MethodNames.SendSticker, args);
        }
        
        /// <summary>Use this method to send static .WEBP or animated .TGS stickers. On success, the sent Message is returned..</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendStickerAsync(this BotClient bot, SendStickerArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<Message>(MethodNames.SendSticker, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
		/// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
		/// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
		/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
		/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
		/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
		/// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
		/// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
		/// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static Message SendSticker(this BotClient api, long chatId, InputFile sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendSticker, args);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendSticker(this BotClient api, long chatId, string sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendSticker, args);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendSticker(this BotClient api, string chatId, InputFile sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendSticker, args);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendSticker(this BotClient api, string chatId, string sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return api.RPCF<Message>(MethodNames.SendSticker, args);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendStickerAsync(this BotClient api, long chatId, InputFile sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendSticker, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendStickerAsync(this BotClient api, long chatId, string sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendSticker, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendStickerAsync(this BotClient api, string chatId, InputFile sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendSticker, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send static .WEBP, animated .TGS, or video .WEBM stickers. On success, the sent Message is returned.
        /// </summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="sticker">Sticker to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a .WEBP file from the Internet, or upload a new one using multipart/form-data. More information on Sending Files ┬╗.</param>
        /// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendStickerAsync(this BotClient api, string chatId, string sticker, [Optional] int? messageThreadId, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup? replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendStickerArgs(chatId, sticker)
            {
                MessageThreadId = messageThreadId,
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await api.RPCAF<Message>(MethodNames.SendSticker, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
