// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
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

            return bot.RPCF<bool>(MethodNames.AddStickerToSet, args);
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

            return await bot.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to add a new sticker to a set created by the bot. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Animated stickers can be added to animated sticker sets and only to them. Animated sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">Sticker set name.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient api, int userId, string name, string emojis, [Optional] InputFile? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] MaskPosition? maskPosition)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AddStickerToSetArgs(userId, name, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                MaskPosition = maskPosition
            };
            return api.RPCF<bool>(MethodNames.AddStickerToSet, args);
        }

        /// <summary>Use this method to add a new sticker to a set created by the bot. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Animated stickers can be added to animated sticker sets and only to them. Animated sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">Sticker set name.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool AddStickerToSet(this BotClient api, int userId, string name, string emojis, [Optional] string? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] MaskPosition? maskPosition)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AddStickerToSetArgs(userId, name, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                MaskPosition = maskPosition
            };
            return api.RPCF<bool>(MethodNames.AddStickerToSet, args);
        }

        /// <summary>Use this method to add a new sticker to a set created by the bot. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Animated stickers can be added to animated sticker sets and only to them. Animated sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">Sticker set name.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient api, int userId, string name, string emojis, [Optional] InputFile? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] MaskPosition? maskPosition, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AddStickerToSetArgs(userId, name, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                MaskPosition = maskPosition
            };
            return await api.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to add a new sticker to a set created by the bot. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Animated stickers can be added to animated sticker sets and only to them. Animated sticker sets can have up to 50 stickers. Static sticker sets can have up to 120 stickers. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">Sticker set name.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> AddStickerToSetAsync(this BotClient api, int userId, string name, string emojis, [Optional] string? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] MaskPosition? maskPosition, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new AddStickerToSetArgs(userId, name, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                MaskPosition = maskPosition
            };
            return await api.RPCAF<bool>(MethodNames.AddStickerToSet, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
