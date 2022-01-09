// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="userId">User identifier of sticker file owner.</param>
        /// <param name="pngSticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static File UploadStickerFile(this BotClient bot, long userId, InputFile pngSticker)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (pngSticker is null)
            {
                throw new ArgumentNullException(nameof(pngSticker));
            }

            return bot.RPCF<File>(MethodNames.UploadStickerFile, new UploadStickerFileArgs { UserId = userId, PngSticker = pngSticker });
        }

        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static File UploadStickerFile(this BotClient bot, UploadStickerFileArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<File>(MethodNames.UploadStickerFile, args);
        }
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="userId">User identifier of sticker file owner.</param>
        /// <param name="pngSticker">Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<File> UploadStickerFileAsync(this BotClient bot, long userId, InputFile pngSticker, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (pngSticker is null)
            {
                throw new ArgumentNullException(nameof(pngSticker));
            }

            return await bot.RPCAF<File>(MethodNames.UploadStickerFile, new UploadStickerFileArgs { UserId = userId, PngSticker = pngSticker }, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to upload a .png file with a sticker for later use in createNewStickerSet and addStickerToSet methods (can be used multiple times). Returns the uploaded File on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<File> UploadStickerFileAsync(this BotClient bot, UploadStickerFileArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<File>(MethodNames.UploadStickerFile, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}