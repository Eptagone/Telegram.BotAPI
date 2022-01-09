// Copyright (c) 2022 Quetzal Rivera.
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
        /// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only group in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message enumerable.</returns>
        public static IEnumerable<Message> SendMediaGroup(this BotClient bot, SendMediaGroupArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<IEnumerable<Message>>(MethodNames.SendMediaGroup, args);
        }
        /// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only group in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message enumerable.</returns>
        public static async Task<IEnumerable<Message>> SendMediaGroupAsync(this BotClient bot, SendMediaGroupArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
        /// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the messages are a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static IEnumerable<Message> SendMediaGroup(this BotClient api, long chatId, IEnumerable<InputMedia> media, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendMediaGroupArgs(chatId, media)
            {
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply
            };
            return api.RPC<IEnumerable<Message>>(MethodNames.SendMediaGroup, args);
        }

        /// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
        /// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the messages are a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static IEnumerable<Message> SendMediaGroup(this BotClient api, string chatId, IEnumerable<InputMedia> media, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendMediaGroupArgs(chatId, media)
            {
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply
            };
            return api.RPC<IEnumerable<Message>>(MethodNames.SendMediaGroup, args);
        }

        /// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
        /// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the messages are a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<IEnumerable<Message>> SendMediaGroupAsync(this BotClient api, long chatId, IEnumerable<InputMedia> media, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendMediaGroupArgs(chatId, media)
            {
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply
            };
            return await api.RPCA<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send a group of photos, videos, documents or audios as an album. Documents and audio files can be only grouped in an album with messages of the same type. On success, an array of Messages that were sent is returned.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
        /// <param name="disableNotification">Sends messages silently. Users will receive a notification with no sound.</param>
        /// <param name="protectContent">Protects the contents of the sent messages from forwarding and saving.</param>
        /// <param name="replyToMessageId">If the messages are a reply, ID of the original message.</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<IEnumerable<Message>> SendMediaGroupAsync(this BotClient api, string chatId, IEnumerable<InputMedia> media, [Optional] bool? disableNotification, [Optional] bool? protectContent, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SendMediaGroupArgs(chatId, media)
            {
                DisableNotification = disableNotification,
                ProtectContent = protectContent,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply
            };
            return await api.RPCA<IEnumerable<Message>>(MethodNames.SendMediaGroup, args, cancellationToken).ConfigureAwait(false);
        }
    }
}