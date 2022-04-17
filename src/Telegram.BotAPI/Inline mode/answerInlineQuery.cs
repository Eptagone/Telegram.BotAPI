// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

#nullable enable

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Inline mode</summary>
    public static partial class InlineModeExtensions
    {
        /// <summary>Use this method to send answers to an inline query. On success, True is returned. 
        /// No more than 50 results per query are allowed.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AnswerInlineQuery(this BotClient bot, AnswerInlineQueryArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            JsonSerializer.Serialize(json, args, typeof(AnswerInlineQueryArgs), BotClient.DefaultSerializerOptions);
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.AnswerInlineQuery, stream);
        }
        /// <summary>Use this method to send answers to an inline query. On success, True is returned. 
        /// No more than 50 results per query are allowed.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AnswerInlineQueryAsync(this BotClient bot, AnswerInlineQueryArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, args, typeof(AnswerInlineQueryArgs), BotClient.DefaultSerializerOptions, cancellationToken: cancellationToken).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.AnswerInlineQuery, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Use this method to send answers to an inline query. On success, True is returned. <br/>
        /// No more than 50 results per query are allowed.
        /// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="inlineQueryId">Unique identifier for the answered query.</param>
		/// <param name="results">A JSON-serialized array of results for the inline query.</param>
		/// <param name="cacheTime">The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.</param>
		/// <param name="isPersonal">Pass True, if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.</param>
		/// <param name="nextOffset">Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don't support pagination. Offset length can't exceed 64 bytes.</param>
		/// <param name="switchPmText">If passed, clients will display a button with specified text that switches the user to a private chat with the bot and sends the bot a start message with the parameter switch_pm_parameter.</param>
		/// <param name="switchPmParameter">Deep-linking parameter for the /start message sent to the bot when user presses the switch button. 1-64 characters, only A-Z, a-z, 0-9, _ and - are allowed. <br/>
        /// Example: An inline bot that sends YouTube videos can ask the user to connect the bot to their YouTube account to adapt search results accordingly.To do this, it displays a 'Connect your YouTube account' button above the results, or even before showing any.The user presses the button, switches to a private chat with the bot and, in doing so, passes a start parameter that instructs the bot to return an OAuth link.Once done, the bot can offer a switch_inline button so that the user can easily return to the chat where they wanted to use the bot's inline capabilities.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AnswerInlineQuery(this BotClient api, string inlineQueryId, IEnumerable<InlineQueryResult> results, [Optional] uint? cacheTime, [Optional] bool? isPersonal, [Optional] string? nextOffset, [Optional] string? switchPmText, [Optional] string? switchPmParameter)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AnswerInlineQueryArgs(inlineQueryId, results)
            {
                CacheTime = cacheTime,
                IsPersonal = isPersonal,
                NextOffset = nextOffset,
                SwitchPmText = switchPmText,
                SwitchPmParameter = switchPmParameter
            };
            return api.RPC<bool>(MethodNames.AnswerInlineQuery, args);
        }

        /// <summary>Use this method to send answers to an inline query. On success, True is returned. <br/>
        /// No more than 50 results per query are allowed.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="inlineQueryId">Unique identifier for the answered query.</param>
        /// <param name="results">A JSON-serialized array of results for the inline query.</param>
        /// <param name="cacheTime">The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.</param>
        /// <param name="isPersonal">Pass True, if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.</param>
        /// <param name="nextOffset">Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don't support pagination. Offset length can't exceed 64 bytes.</param>
        /// <param name="switchPmText">If passed, clients will display a button with specified text that switches the user to a private chat with the bot and sends the bot a start message with the parameter switch_pm_parameter.</param>
        /// <param name="switchPmParameter">Deep-linking parameter for the /start message sent to the bot when user presses the switch button. 1-64 characters, only A-Z, a-z, 0-9, _ and - are allowed. <br/>
        /// Example: An inline bot that sends YouTube videos can ask the user to connect the bot to their YouTube account to adapt search results accordingly.To do this, it displays a 'Connect your YouTube account' button above the results, or even before showing any.The user presses the button, switches to a private chat with the bot and, in doing so, passes a start parameter that instructs the bot to return an OAuth link.Once done, the bot can offer a switch_inline button so that the user can easily return to the chat where they wanted to use the bot's inline capabilities.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AnswerInlineQueryAsync(this BotClient api, string inlineQueryId, IEnumerable<InlineQueryResult> results, [Optional] uint? cacheTime, [Optional] bool? isPersonal, [Optional] string? nextOffset, [Optional] string? switchPmText, [Optional] string? switchPmParameter, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AnswerInlineQueryArgs(inlineQueryId, results)
            {
                CacheTime = cacheTime,
                IsPersonal = isPersonal,
                NextOffset = nextOffset,
                SwitchPmText = switchPmText,
                SwitchPmParameter = switchPmParameter
            };
            return await api.RPCA<bool>(MethodNames.AnswerInlineQuery, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
