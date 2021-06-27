// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games
{
    public static partial class GamesExtensions
    {
        ///<summary>Use this method to send a game. On success, the sent Message is returned.</summary>
        ///<param name="bot">BotClient</param>
        ///<param name="args">Parameters</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message SendGame(this BotClient bot, SendGameArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<Message>(MethodNames.SendGame, args);
        }
        ///<summary>Use this method to send a game. On success, the sent Message is returned.</summary>
        ///<param name="bot">BotClient</param>
        ///<param name="args">Parameters</param>
        ///<param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> SendGameAsync(this BotClient bot, SendGameArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Message>(MethodNames.SendGame, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
