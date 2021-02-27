// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetChatAdministratorCustomTitle(
            this BotClient bot,
            long chatId,
            int userId,
            string customTitle)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteString(PropertyNames.CustomTitle, customTitle);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SendVideoNote, stream);
        }

        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static bool SetChatAdministratorCustomTitle(
            this BotClient bot,
            string chatId,
            int userId,
            string customTitle)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteString(PropertyNames.CustomTitle, customTitle);
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<bool>(MethodNames.SendVideoNote, stream);
        }
        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetChatAdministratorCustomTitleAsync(this BotClient bot, long chatId, int userId, string customTitle, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteNumber(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteString(PropertyNames.CustomTitle, customTitle);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SendVideoNote, stream, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>Use this method to set a custom title for an administrator in a supergroup promoted by the bot. Returns True on success.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="chatId">Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</param>
        /// <param name="userId">Unique identifier of the target user.</param>
        /// <param name="customTitle">New custom title for the administrator; 0-16 characters, emoji are not allowed.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns>True</returns>
        public static async Task<bool> SetChatAdministratorCustomTitleAsync(this BotClient bot, string chatId, int userId, string customTitle, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString(PropertyNames.ChatId, chatId);
            json.WriteNumber(PropertyNames.UserId, userId);
            json.WriteString(PropertyNames.CustomTitle, customTitle);
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<bool>(MethodNames.SendVideoNote, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
