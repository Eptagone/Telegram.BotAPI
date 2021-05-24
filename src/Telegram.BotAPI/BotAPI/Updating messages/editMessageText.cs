// Copyright (c) 2021 Quetzal Rivera.
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
        /// <summary>Use this method to edit text and game messages.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static Message EditMessageText(this BotClient bot, EditMessageTextArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return bot.RPC<Message>(MethodNames.EditMessageText, args);
        }
        /// <summary>Use this method to edit text and game messages.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<Message> EditMessageTextAsync(this BotClient bot, EditMessageTextArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return await bot.RPCA<Message>(MethodNames.EditMessageText, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to edit text and game messages.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static T EditMessageText<T>(this BotClient bot, EditMessageTextArgs args)
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
            return bot.RPC<T>(MethodNames.EditMessageText, args);
        }
        /// <summary>Use this method to edit text and game messages.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if edited message is sent by the bot, the edited Message is returned, otherwise True is returned.</returns>
        public static async Task<T> EditMessageTextAsync<T>(this BotClient bot, EditMessageTextArgs args, [Optional] CancellationToken cancellationToken)
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
            return await bot.RPCA<T>(MethodNames.EditMessageText, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}