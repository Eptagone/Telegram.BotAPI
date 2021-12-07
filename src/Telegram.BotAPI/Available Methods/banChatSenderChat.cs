// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>Available Methods</summary>
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to ban a channel chat in a supergroup or a channel. The owner of the chat will not be able to send messages and join live streams on behalf of the chat, unless it is unbanned first. The bot must be an administrator in the supergroup or channel for this to work and must have the appropriate administrator rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="senderChatId">Unique identifier of the target sender chat</param>
        /// <param name="untilDate">Date when the sender chat will be unbanned, unix time. If the chat is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static bool BanChatSenderChat(this BotClient bot, long chatId, long senderChatId, [Optional] uint? untilDate)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.SenderChatId, senderChatId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.BanChatSenderChat, stream);
        }
        /// <summary>Use this method to ban a channel chat in a supergroup or a channel. The owner of the chat will not be able to send messages and join live streams on behalf of the chat, unless it is unbanned first. The bot must be an administrator in the supergroup or channel for this to work and must have the appropriate administrator rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="senderChatId">Unique identifier of the target sender chat</param>
        /// <param name="untilDate">Date when the sender chat will be unbanned, unix time. If the chat is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static bool BanChatSenderChat(this BotClient bot, string chatId, long senderChatId, [Optional] uint? untilDate)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.SenderChatId, senderChatId);
            if (untilDate != null)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.BanChatSenderChat, stream);
        }
        /// <summary>Use this method to ban a channel chat in a supergroup or a channel. The owner of the chat will not be able to send messages and join live streams on behalf of the chat, unless it is unbanned first. The bot must be an administrator in the supergroup or channel for this to work and must have the appropriate administrator rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="senderChatId">Unique identifier of the target sender chat</param>
        /// <param name="untilDate">Date when the sender chat will be unbanned, unix time. If the chat is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static async Task<bool> BanChatSenderChatAsync(this BotClient bot, long chatId, long senderChatId, [Optional] uint? untilDate, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.SenderChatId, senderChatId);
            if (untilDate != default)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.BanChatSenderChat, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to ban a channel chat in a supergroup or a channel. The owner of the chat will not be able to send messages and join live streams on behalf of the chat, unless it is unbanned first. The bot must be an administrator in the supergroup or channel for this to work and must have the appropriate administrator rights.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername)</param>
        /// <param name="senderChatId">Unique identifier of the target sender chat</param>
        /// <param name="untilDate">Date when the sender chat will be unbanned, unix time. If the chat is banned for more than 366 days or less than 30 seconds from the current time they are considered to be banned forever.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True on success.</returns>
        public static async Task<bool> BanChatSenderChatAsync(this BotClient bot, string chatId, long senderChatId, [Optional] uint? untilDate, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.SenderChatId, senderChatId);
            if (untilDate != default)
            {
                json.WriteNumber(PropertyNames.UntilDate, (uint)untilDate);
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.BanChatSenderChat, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
