// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient bot, SendMessageArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Message>(MethodNames.SendMessage, args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient bot, SendMessageArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Message>(MethodNames.SendMessage, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parseMode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="entities">List of special entities that appear in message text, which can be specified instead of parseMode.</param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient bot, object chatId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new SendMessageArgs()
            {
                ChatId = chatId,
                Text = text
            };
            if (parseMode != default)
            {
                args.ParseMode = parseMode;
            }

            if (entities != default)
            {
                args.Entities = entities;
            }

            args.DisableWebPagePreview = disableWebPagePreview;
            args.DisableNotification = disableNotification;
            if (replyToMessageId != default)
            {
                args.ReplyToMessageId = replyToMessageId;
            }

            args.AllowSendingWithoutReply = allowSendingWithoutReply;
            if (replyMarkup != default)
            {
                args.ReplyMarkup = replyMarkup;
            }

            return bot.RPC<Message>(MethodNames.SendMessage, args);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parseMode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="entities">List of special entities that appear in message text, which can be specified instead of parseMode.</param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="replyMarkup">Additional interface options. A JSON-serialized object for an inline keyboard, custom reply keyboard, instructions to remove reply keyboard or to force a reply from the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient bot, object chatId, string text, [Optional] string parseMode, [Optional] MessageEntity[] entities, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] ReplyMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new SendMessageArgs()
            {
                ChatId = chatId,
                Text = text
            };
            if (parseMode != default)
            {
                args.ParseMode = parseMode;
            }

            if (entities != default)
            {
                args.Entities = entities;
            }

            args.DisableWebPagePreview = disableWebPagePreview;
            args.DisableNotification = disableNotification;
            if (replyToMessageId != default)
            {
                args.ReplyToMessageId = replyToMessageId;
            }

            args.AllowSendingWithoutReply = allowSendingWithoutReply;
            if (replyMarkup != default)
            {
                args.ReplyMarkup = replyMarkup;
            }

            return await bot.RPCA<Message>(MethodNames.SendMessage, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parseMode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static Message SendMessage(this BotClient bot, long chatId, string text, [Optional] string parseMode, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteString(PropertyNames.Text, text);
            if (parseMode != default)
            {
                json.WriteString(PropertyNames.ParseMode, parseMode);
            }

            if (disableWebPagePreview != null)
            {
                json.WriteBoolean(PropertyNames.DisableWebPagePreview, (bool)disableWebPagePreview);
            }

            if (disableNotification != null)
            {
                json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
            }

            if (replyToMessageId != default)
            {
                json.WriteNumber(PropertyNames.ReplyToMessageId, (int)replyToMessageId);
            }

            if (allowSendingWithoutReply != null)
            {
                json.WriteBoolean(PropertyNames.AllowSendingWithoutReply, (bool)allowSendingWithoutReply);
            }

            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Message>(MethodNames.SendMessage, stream);
        }
        /// <summary>Use this method to send text messages. On success, the sent Message is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="text">Text of the message to be sent.</param>
        /// <param name="parseMode">Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</param>
        /// <param name="disableWebPagePreview">Disables link previews for links in this message</param>
        /// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
        /// <param name="replyToMessageId">If the message is a reply, ID of the original message</param>
        /// <param name="allowSendingWithoutReply">Pass True, if the message should be sent even if the specified replied-to message is not found</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Message Object.</returns>
        public static async Task<Message> SendMessageAsync(this BotClient bot, long chatId, string text, [Optional] string parseMode, [Optional] bool? disableWebPagePreview, [Optional] bool? disableNotification, [Optional] int? replyToMessageId, [Optional] bool? allowSendingWithoutReply, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteString(PropertyNames.Text, text);
            if (parseMode != default)
            {
                json.WriteString(PropertyNames.ParseMode, parseMode);
            }

            if (disableWebPagePreview != null)
            {
                json.WriteBoolean(PropertyNames.DisableWebPagePreview, (bool)disableWebPagePreview);
            }

            if (disableNotification != null)
            {
                json.WriteBoolean(PropertyNames.DisableNotification, (bool)disableNotification);
            }

            if (allowSendingWithoutReply != null)
            {
                json.WriteBoolean(PropertyNames.AllowSendingWithoutReply, (bool)allowSendingWithoutReply);
            }

            if (replyToMessageId != default)
            {
                json.WriteNumber(PropertyNames.ReplyToMessageId, (int)replyToMessageId);
            }

            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Message>(MethodNames.SendMessage, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}