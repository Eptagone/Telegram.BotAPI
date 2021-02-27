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
        /// <summary>Use this method to get the current list of the bot's commands. Requires no parameters. Returns Array of <see cref="BotCommand"/> on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/></returns>
        public static BotCommand[] GetMyCommands(this BotClient bot)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<BotCommand[]>(MethodNames.GetMyCommands);
        }
        /// <summary>Use this method to get the current list of the bot's commands. Requires no parameters. Returns Array of <see cref="BotCommand"/> on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/></returns>
        public static async Task<BotCommand[]> GetMyCommandsAsync(this BotClient bot, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return await bot.RPCA<BotCommand[]>(MethodNames.GetMyCommands, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to get the current list of the bot's commands. Requires no parameters. Returns Array of <see cref="BotCommand"/> on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/></returns>
        public static T GetMyCommands<T>(this BotClient bot)
            where T : IEnumerable<BotCommand>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<T>(MethodNames.GetMyCommands);
        }
        /// <summary>Use this method to get the current list of the bot's commands. Requires no parameters. Returns Array of <see cref="BotCommand"/> on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>Array of <see cref="BotCommand"/></returns>
        public static async Task<T> GetMyCommandsAsync<T>(this BotClient bot, [Optional] CancellationToken cancellationToken)
            where T : IEnumerable<BotCommand>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return await bot.RPCA<T>(MethodNames.GetMyCommands, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
