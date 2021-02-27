// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Linq;
using System;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    public static partial class AvailableMethodsExtensions
    {
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
        public static Message StopMessageLiveLocation(this BotClient bot, StopMessageLiveLocationArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return bot.RPC<Message>(MethodNames.StopMessageLiveLocation, args);
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
        public static async Task<Message> StopMessageLiveLocationAsync(this BotClient bot, StopMessageLiveLocationArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }
            return await bot.RPCA<Message>(MethodNames.StopMessageLiveLocation, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
        public static T StopMessageLiveLocation<T>(this BotClient bot, StopMessageLiveLocationArgs args)
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
                throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
            }
            return bot.RPC<T>(MethodNames.StopMessageLiveLocation, args);
        }
        /// <summary>Use this method to stop updating a live location message sent by the bot or via the bot (for inline bots) before live_period expires.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        /// <exception cref="ArgumentException">Thrown when T is not Telegram.BotAPI.AvailableTypes.Message or bool.</exception>
        /// <returns><see cref="Message"/> or <see cref="bool"/>. On success, if the message was sent by the bot, the sent Message is returned, otherwise True is returned.</returns>
        public static async Task<T> StopMessageLiveLocationAsync<T>(this BotClient bot, StopMessageLiveLocationArgs args, [Optional] CancellationToken cancellationToken)
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
                throw new ArgumentException($"{nameof(T)} must be Telegram.BotAPI.AvailableTypes.Message or bool.");
            }
            return await bot.RPCA<T>(MethodNames.StopMessageLiveLocation, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
