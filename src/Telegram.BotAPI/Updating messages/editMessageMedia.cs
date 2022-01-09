// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
    public static partial class UpdatingMessagesExtensions
    {
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static Message EditMessageMedia(this BotClient bot, EditMessageMediaArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return bot.RPCF<Message>(MethodNames.EditMessageMedia, args);
        }
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<Message> EditMessageMediaAsync(this BotClient bot, EditMessageMediaArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return await bot.RPCAF<Message>(MethodNames.EditMessageMedia, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static T EditMessageMedia<T>(this BotClient bot, EditMessageMediaArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool) && typeof(T) != typeof(JObject) && typeof(T) != typeof(JsonDocument))
            {
                throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
            }
            return bot.RPCF<T>(MethodNames.EditMessageMedia, args);
        }
        /// <summary>Use this method to edit animation, audio, document, photo, or video messages. If a message is a part of a message album, then it can be edited only to a photo or a video. Otherwise, message type can be changed arbitrarily. When inline message is edited, new file can't be uploaded. Use previously uploaded file via its file_id or specify a URL.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the edited message was sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<T> EditMessageMediaAsync<T>(this BotClient bot, EditMessageMediaArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            if (typeof(T) != typeof(Message) && typeof(T) != typeof(bool) && typeof(T) != typeof(JObject) && typeof(T) != typeof(JsonDocument))
            {
                throw new ArgumentException($"{nameof(T)} must be a Telegram.BotAPI.AvailableTypes.Message or bool.");
            }
            return await bot.RPCAF<T>(MethodNames.EditMessageMedia, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}