// Copyright (c) 2021 Quetzal Rivera.
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
        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned.</returns>
        public static BotCommand[] GetMyCommands(this BotClient bot, [Optional] BotCommandScope scope, [Optional] string languageCode) => bot.GetMyCommands<BotCommand[]>(scope, languageCode);

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned.</returns>
        public static TValue GetMyCommands<TValue>(this BotClient bot, [Optional] BotCommandScope scope, [Optional] string languageCode)
            where TValue : IEnumerable<BotCommand>
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new GetMyCommandsArgs(scope, languageCode);
            return bot.RPC<TValue>(MethodNames.GetMyCommands, args);
        }

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned.</returns>
        public static BotCommand[] GetMyCommands(this BotClient bot, GetMyCommandsArgs args) => bot.GetMyCommands<BotCommand[]>(args);

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned.</returns>
        public static TValue GetMyCommands<TValue>(this BotClient bot, GetMyCommandsArgs args)
            where TValue : IEnumerable<BotCommand>
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return bot.RPC<TValue>(MethodNames.GetMyCommands, args);
        }

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned.</returns>
        public static async Task<BotCommand[]> GetMyCommandsAsync(this BotClient bot, [Optional] BotCommandScope scope, [Optional] string languageCode, [Optional] CancellationToken cancellationToken) => await bot.GetMyCommandsAsync<BotCommand[]>(scope, languageCode, cancellationToken);

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="scope">A <see cref="BotCommandScope"/> object, describing scope of users. Defaults to <see cref="BotCommandScopeDefault"/>.</param>
        /// <param name="languageCode">A two-letter ISO 639-1 language code or an empty string.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned. on success. If commands aren't set, an empty list is returned.</returns>
        public static async Task<TValue> GetMyCommandsAsync<TValue>(this BotClient bot, [Optional] BotCommandScope scope, [Optional] string languageCode, [Optional] CancellationToken cancellationToken)
            where TValue : IEnumerable<BotCommand>
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new GetMyCommandsArgs(scope, languageCode);
            return await bot.RPCA<TValue>(MethodNames.GetMyCommands, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned. on success. If commands aren't set, an empty list is returned.</returns>
        public static async Task<BotCommand[]> GetMyCommandsAsync(this BotClient bot, GetMyCommandsArgs args, [Optional] CancellationToken cancellationToken) => await bot.GetMyCommandsAsync<BotCommand[]>(args, cancellationToken);

        /// <summary>Use this method to get the current list of the bot's commands for the given scope and user language.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/> on success. If commands aren't set, an empty list is returned. on success. If commands aren't set, an empty list is returned.</returns>
        public static async Task<TValue> GetMyCommandsAsync<TValue>(this BotClient bot, GetMyCommandsArgs args, [Optional] CancellationToken cancellationToken)
            where TValue : IEnumerable<BotCommand>
        {
            if (bot == null)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return await bot.RPCA<TValue>(MethodNames.GetMyCommands, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
