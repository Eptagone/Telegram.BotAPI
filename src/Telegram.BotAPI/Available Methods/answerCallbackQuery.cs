// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <returns>true</returns>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AnswerCallbackQuery(
            this BotClient bot,
            AnswerCallbackQueryArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<bool>(MethodNames.AnswerCallbackQuery, args);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="callbackQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="text">Optional. Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</param>
        /// <param name="showAlert">Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</param>
        /// <param name="url">Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button. <br/>Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</param>
        /// <param name="cacheTime">Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AnswerCallbackQuery(
            this BotClient bot,
            string callbackQueryId,
            [Optional] string? text,
            [Optional] bool? showAlert,
            [Optional] string? url,
            [Optional] uint? cacheTime)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.CallbackQueryId, callbackQueryId);
            if (!string.IsNullOrEmpty(text))
            {
                json.WriteString(PropertyNames.Text, text);
            }

            if (showAlert != null)
            {
                json.WriteBoolean(PropertyNames.ShowAlert, (bool)showAlert);
            }

            if (!string.IsNullOrEmpty(url))
            {
                json.WriteString(PropertyNames.Url, url);
            }

            if (cacheTime != null)
            {
                json.WriteNumber(PropertyNames.CacheTime, (uint)cacheTime);
            }

            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.AnswerCallbackQuery, stream);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AnswerCallbackQueryAsync(
            this BotClient bot,
            AnswerCallbackQueryArgs args,
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

            return await bot.RPCA<bool>(MethodNames.AnswerCallbackQuery, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to send answers to callback queries sent from inline keyboards. The answer will be displayed to the user as a notification at the top of the chat screen or as an alert. On success, True is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="callbackQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="text">Optional. Text of the notification. If not specified, nothing will be shown to the user, 0-200 characters.</param>
        /// <param name="showAlert">Optional. If true, an alert will be shown by the client instead of a notification at the top of the chat screen. Defaults to false.</param>
        /// <param name="url">Optional. URL that will be opened by the user's client. If you have created a Game and accepted the conditions via @Botfather, specify the URL that opens your game – note that this will only work if the query comes from a callback_game button. <br/>Otherwise, you may use links like t.me/your_bot?start=XXXX that open your bot with a parameter.</param>
        /// <param name="cacheTime">Optional. The maximum amount of time in seconds that the result of the callback query may be cached client-side. Telegram apps will support caching starting in version 3.14. Defaults to 0.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AnswerCallbackQueryAsync(
            this BotClient bot,
            string callbackQueryId,
            [Optional] string? text,
            [Optional] bool? showAlert,
            [Optional] string? url,
            [Optional] uint? cacheTime,
            [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            json.WriteString(PropertyNames.CallbackQueryId, callbackQueryId);
            if (!string.IsNullOrEmpty(text))
            {
                json.WriteString(PropertyNames.Text, text);
            }

            if (showAlert != null)
            {
                json.WriteBoolean(PropertyNames.ShowAlert, (bool)showAlert);
            }

            if (!string.IsNullOrEmpty(url))
            {
                json.WriteString(PropertyNames.Url, url);
            }

            if (cacheTime != null)
            {
                json.WriteNumber(PropertyNames.CacheTime, (uint)cacheTime);
            }

            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.AnswerCallbackQuery, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
