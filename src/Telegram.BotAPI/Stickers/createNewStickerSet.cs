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

            return bot.RPCF<bool>(MethodNames.CreateNewStickerSet, args);
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

            return await bot.RPCAF<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of created sticker set owner.</param>
        /// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
        /// <param name="title">Sticker set title, 1-64 characters.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="containsMasks">Pass True, if a set of mask stickers should be created.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool CreateNewStickerSet(this BotClient api, int userId, string name, string title, string emojis, [Optional] InputFile? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] bool? containsMasks, [Optional] MaskPosition? maskPosition)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new CreateNewStickerSetArgs(userId, name, title, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                ContainsMasks = containsMasks,
                MaskPosition = maskPosition
            };
            return api.RPCF<bool>(MethodNames.CreateNewStickerSet, args);
        }

        /// <summary>Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of created sticker set owner.</param>
        /// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
        /// <param name="title">Sticker set title, 1-64 characters.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="containsMasks">Pass True, if a set of mask stickers should be created.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool CreateNewStickerSet(this BotClient api, int userId, string name, string title, string emojis, [Optional] string? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] bool? containsMasks, [Optional] MaskPosition? maskPosition)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new CreateNewStickerSetArgs(userId, name, title, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                ContainsMasks = containsMasks,
                MaskPosition = maskPosition
            };
            return api.RPCF<bool>(MethodNames.CreateNewStickerSet, args);
        }

        /// <summary>Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of created sticker set owner.</param>
        /// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
        /// <param name="title">Sticker set title, 1-64 characters.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="containsMasks">Pass True, if a set of mask stickers should be created.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> CreateNewStickerSetAsync(this BotClient api, int userId, string name, string title, string emojis, [Optional] InputFile? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] bool? containsMasks, [Optional] MaskPosition? maskPosition, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new CreateNewStickerSetArgs(userId, name, title, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                ContainsMasks = containsMasks,
                MaskPosition = maskPosition
            };
            return await api.RPCAF<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to create a new sticker set owned by a user. The bot will be able to edit the sticker set thus created. You must use exactly one of the fields png_sticker, tgs_sticker, or webm_sticker. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="userId">User identifier of created sticker set owner.</param>
        /// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
        /// <param name="title">Sticker set title, 1-64 characters.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <param name="pngSticker">PNG image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. More info on Sending Files ».</param>
        /// <param name="tgsSticker">TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#animated-sticker-requirements for technical requirements.</param>
        /// <param name="webmSticker">WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</param>
        /// <param name="containsMasks">Pass True, if a set of mask stickers should be created.</param>
        /// <param name="maskPosition">A JSON-serialized object for position where the mask should be placed on faces.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> CreateNewStickerSetAsync(this BotClient api, int userId, string name, string title, string emojis, [Optional] string? pngSticker, [Optional] InputFile? tgsSticker, [Optional] InputFile? webmSticker, [Optional] bool? containsMasks, [Optional] MaskPosition? maskPosition, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new CreateNewStickerSetArgs(userId, name, title, emojis)
            {
                PngSticker = pngSticker,
                TgsSticker = tgsSticker,
                WebmSticker = webmSticker,
                ContainsMasks = containsMasks,
                MaskPosition = maskPosition
            };
            return await api.RPCAF<bool>(MethodNames.CreateNewStickerSet, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
