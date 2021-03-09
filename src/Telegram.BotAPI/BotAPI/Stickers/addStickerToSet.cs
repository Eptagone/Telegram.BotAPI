// Copyright (c) 2021 Quetzal Rivera.
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
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="pngSticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgsSticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="maskPosition">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient bot, long userId, string name, [Optional] string pngSticker, [Optional] InputFile tgsSticker, string emojis, [Optional] MaskPosition maskPosition)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { UserId = userId, Name = name, Emojis = emojis };
            if (!string.IsNullOrEmpty(pngSticker))
            {
                args.PngSticker = pngSticker;
            }

            if (tgsSticker != default)
            {
                args.TgsSticker = tgsSticker;
            }

            if (maskPosition != default)
            {
                args.MaskPosition = maskPosition;
            }

            if (args.UseMultipart())
            {
                return bot.RPCF<bool>(MethodNames.AddStickerToSet, args);
            }
            else
            {
                return bot.RPC<bool>(MethodNames.AddStickerToSet, args);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="pngSticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgsSticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="maskPosition">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient bot, long userId, string name, [Optional] string pngSticker, [Optional] InputFile tgsSticker, string emojis, [Optional] MaskPosition maskPosition, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { UserId = userId, Name = name, Emojis = emojis };
            if (!string.IsNullOrEmpty(pngSticker))
            {
                args.PngSticker = pngSticker;
            }

            if (tgsSticker != default)
            {
                args.TgsSticker = tgsSticker;
            }

            if (maskPosition != default)
            {
                args.MaskPosition = maskPosition;
            }

            if (args.UseMultipart())
            {
                return await bot.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="pngSticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgsSticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="maskPosition">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient bot, long userId, string name, [Optional] InputFile pngSticker, [Optional] InputFile tgsSticker, string emojis, [Optional] MaskPosition maskPosition)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { UserId = userId, Name = name, Emojis = emojis };
            if (pngSticker != default)
            {
                args.PngSticker = pngSticker;
            }

            if (tgsSticker != default)
            {
                args.TgsSticker = tgsSticker;
            }

            if (maskPosition != default)
            {
                args.MaskPosition = maskPosition;
            }

            if (args.UseMultipart())
            {
                return bot.RPCF<bool>(MethodNames.AddStickerToSet, args);
            }
            else
            {
                return bot.RPC<bool>(MethodNames.AddStickerToSet, args);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">User identifier of sticker set owner.</param>
        /// <param name="pngSticker">Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// /// <param name="tgsSticker">Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="maskPosition">A <see cref="MaskPosition"/> for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient bot, long userId, string name, [Optional] InputFile pngSticker, [Optional] InputFile tgsSticker, string emojis, [Optional] MaskPosition maskPosition, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var args = new AddStickerToSetArgs { UserId = userId, Name = name, Emojis = emojis };
            if (pngSticker != default)
            {
                args.PngSticker = pngSticker;
            }

            if (tgsSticker != default)
            {
                args.TgsSticker = tgsSticker;
            }

            if (maskPosition != default)
            {
                args.MaskPosition = maskPosition;
            }

            if (args.UseMultipart())
            {
                return await bot.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient bot, AddStickerToSetArgs args)
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
                return bot.RPCF<bool>(MethodNames.AddStickerToSet, args);
            }
            else
            {
                return bot.RPC<bool>(MethodNames.AddStickerToSet, args);
            }
        }
        /// <summary>Use this method to add a new sticker to a set created by the bot. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient bot, AddStickerToSetArgs args, [Optional] CancellationToken cancellationToken)
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
                return await bot.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}