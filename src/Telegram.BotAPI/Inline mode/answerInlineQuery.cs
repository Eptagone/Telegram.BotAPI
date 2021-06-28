// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Inline mode</summary>
    public static class InlineModeExtensions
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

            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new InlineQueryResultConverter());
            options.Converters.Add(new Tools.InputMessageContentConverter());
            options.Converters.Add(new Tools.InlineKeyboardMarkupConverter());
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            JsonSerializer.Serialize(json, args, typeof(AnswerInlineQueryArgs), options);
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

            var options = new JsonSerializerOptions { IgnoreNullValues = true };
            options.Converters.Add(new InlineQueryResultConverter());
            options.Converters.Add(new Tools.InputMessageContentConverter());
            options.Converters.Add(new Tools.InlineKeyboardMarkupConverter());
            var stream = new MemoryStream();
            await JsonSerializer.SerializeAsync(stream, args, typeof(AnswerInlineQueryArgs), options, cancellationToken: cancellationToken).ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.AnswerInlineQuery, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}