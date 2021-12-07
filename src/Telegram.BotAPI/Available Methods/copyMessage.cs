// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>Available Methods</summary>
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static MessageID CopyMessage(
            this BotClient bot,
            CopyMessageArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<MessageID>(MethodNames.CopyMessage, args);
        }

        /// <summary>Use this method to forward messages of any kind. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<MessageID> CopyMessageAsync(
            this BotClient bot,
            CopyMessageArgs args,
            [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<MessageID>(MethodNames.CopyMessage, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static MessageID CopyMessage(this BotClient bot, long chatId, long fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return bot.CopyMessage(args);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static MessageID CopyMessage(this BotClient bot, long chatId, string fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return bot.CopyMessage(args);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static MessageID CopyMessage(this BotClient bot, string chatId, long fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return bot.CopyMessage(args);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static MessageID CopyMessage(this BotClient bot, string chatId, string fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return bot.CopyMessage(args);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static async Task<MessageID> CopyMessageAsync(this BotClient bot, long chatId, long fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await bot.CopyMessageAsync(args, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static async Task<MessageID> CopyMessageAsync(this BotClient bot, long chatId, string fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await bot.CopyMessageAsync(args, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static async Task<MessageID> CopyMessageAsync(this BotClient bot, string chatId, long fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await bot.CopyMessageAsync(args, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to copy messages of any kind. Service messages and invoice messages can't be copied. The method is analogous to the method forwardMessage, but the copied message doesn't have a link to the original message. Returns the MessageId of the sent message on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="fromChatId">Unique identifier for the chat where the original message was sent (or channel username in the format @channelusername)</param>
        /// <param name="messageId">Message identifier in the chat specified in from_chat_id</param>
        /// <param name="caption">New caption for media, 0-1024 characters after entities parsing. If not specified, the original caption is kept</param>
        /// <param name="parseMode">Mode for parsing entities in the new caption. See formatting options for more details.</param>
        /// <param name="captionEntities">A JSON-serialized list of special entities that appear in the new caption, which can be specified instead of parse_mode</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>

        public static async Task<MessageID> CopyMessageAsync(this BotClient bot, string chatId, string fromChatId, int messageId, [Optional] string caption, [Optional] string parseMode, [Optional] MessageEntity[] captionEntities, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var args = new CopyMessageArgs
            {
                ChatId = chatId,
                FromChatId = fromChatId,
                MessageId = messageId,
                CaptionEntities = captionEntities,
                DisableNotification = disableNotification,
                ReplyToMessageId = replyToMessageId,
                AllowSendingWithoutReply = allowSendingWithoutReply,
                ReplyMarkup = replyMarkup
            };
            return await bot.CopyMessageAsync(args, cancellationToken).ConfigureAwait(false);
        }
    }
}
