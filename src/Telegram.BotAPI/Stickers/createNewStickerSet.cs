// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool CreateNewStickerSet(this BotClient bot, CreateNewStickerSetArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return bot.RPCF<bool>(MethodNames.CreateNewStickerSet, args);
            }
            else
            {
                return bot.RPC<bool>(MethodNames.CreateNewStickerSet, args);
            }
        }
        /// <summary>Use this method to create new sticker set owned by a user. The bot will be able to edit the created sticker set. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> CreateNewStickerSetAsync(this BotClient bot, CreateNewStickerSetArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            if (args.UseMultipart())
            {
                return await bot.RPCAF<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}