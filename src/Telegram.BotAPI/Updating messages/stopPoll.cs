// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
    /// <summary>Updating messages</summary>
    public static partial class UpdatingMessagesExtensions
    {
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, long chatId, int messageId)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageId, messageId);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Poll>(MethodNames.StopPoll, stream);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, string chatId, int messageId)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageId, messageId);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Poll>(MethodNames.StopPoll, stream);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, long chatId, int messageId, InlineKeyboardMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (replyMarkup == default)
            {
                throw new ArgumentNullException(nameof(replyMarkup));
            }

            var args = new StopPollArgs
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup
            };
            return bot.RPC<Poll>(MethodNames.StopPoll, args);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, string chatId, int messageId, InlineKeyboardMarkup replyMarkup)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (replyMarkup == default)
            {
                throw new ArgumentNullException(nameof(replyMarkup));
            }

            var args = new StopPollArgs
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup
            };
            return bot.RPC<Poll>(MethodNames.StopPoll, args);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, long chatId, int messageId, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageId, messageId);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Poll>(MethodNames.StopPoll, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, string chatId, int messageId, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.MessageId, messageId);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Poll>(MethodNames.StopPoll, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, long chatId, int messageId, [Optional] InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (replyMarkup == default)
            {
                throw new ArgumentNullException(nameof(replyMarkup));
            }

            var args = new StopPollArgs
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup
            };
            return await bot.RPCA<Poll>(MethodNames.StopPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="messageId">Identifier of the original message with the poll</param>
        /// <param name="replyMarkup">A <see cref="InlineKeyboardMarkup"/> object for a new message inline keyboard.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, string chatId, int messageId, InlineKeyboardMarkup replyMarkup, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (replyMarkup == default)
            {
                throw new ArgumentNullException(nameof(replyMarkup));
            }

            var args = new StopPollArgs
            {
                ChatId = chatId,
                MessageId = messageId,
                ReplyMarkup = replyMarkup
            };
            return await bot.RPCA<Poll>(MethodNames.StopPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Poll StopPoll(this BotClient bot, StopPollArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Poll>(MethodNames.StopPoll, args);
        }
        /// <summary>Use this method to stop a poll which was sent by the bot. On success, the stopped Poll with the final results is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Poll> StopPollAsync(this BotClient bot, StopPollArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Poll>(MethodNames.StopPoll, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
