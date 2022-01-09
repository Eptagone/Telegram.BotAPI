// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    public static partial class StickersExtensions
    {
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="userId">User identifier of the sticker set owner</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient bot, string name, long userId)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.Name, name);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SetStickerSetThumb, stream);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="userId">User identifier of the sticker set owner</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient bot, string name, long userId, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.Name, name);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SetStickerSetThumb, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="userId">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient bot, string name, long userId, string thumb)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (string.IsNullOrEmpty(thumb))
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.Name, name);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteString(PropertyNames.Thumb, thumb);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SetStickerSetThumb, stream);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="userId">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient bot, string name, long userId, string thumb, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (string.IsNullOrEmpty(thumb))
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.Name, name);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteString(PropertyNames.Thumb, thumb);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SetStickerSetThumb, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="userId">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient bot, string name, long userId, InputFile thumb)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (thumb == default)
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var args = new SetStickerSetThumbArgs { Name = name, UserId = userId, Thumb = thumb };
            return bot.RPCF<bool>(MethodNames.SetStickerSetThumb, args);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="name">Sticker set name</param>
        /// <param name="userId">User identifier of the sticker set owner</param>
        /// <param name="thumb">A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient bot, string name, long userId, InputFile thumb, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (userId == default)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (thumb == default)
            {
                throw new ArgumentNullException(nameof(thumb));
            }

            var args = new SetStickerSetThumbArgs { Name = name, UserId = userId, Thumb = thumb };
            return await bot.RPCAF<bool>(MethodNames.SetStickerSetThumb, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetStickerSetThumb(this BotClient bot, SetStickerSetThumbArgs args)
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
                return bot.RPCF<bool>(MethodNames.SetStickerSetThumb, args);
            }
            else
            {
                return bot.RPC<bool>(MethodNames.SetStickerSetThumb, args);
            }
        }
        /// <summary>Use this method to set the thumbnail of a sticker set. Animated thumbnails can be set for animated sticker sets only. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetStickerSetThumbAsync(this BotClient bot, SetStickerSetThumbArgs args, [Optional] CancellationToken cancellationToken)
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
                return await bot.RPCAF<bool>(MethodNames.SetStickerSetThumb, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>(MethodNames.SetStickerSetThumb, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
