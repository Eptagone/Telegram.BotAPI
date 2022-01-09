// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.GettingUpdates
{
    public static partial class GettingUpdatesExtensions
    {
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Update[] GetUpdates(this BotClient bot)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<Update[]>(MethodNames.GetUpdates);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient bot)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return await bot.RPCA<Update[]>(MethodNames.GetUpdates).ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Update[] GetUpdates(this BotClient bot, GetUpdatesArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<Update[]>(MethodNames.GetUpdates, args);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient bot, GetUpdatesArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<Update[]>(MethodNames.GetUpdates, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
        /// <param name="allowedUpdates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Update[] GetUpdates(this BotClient bot, [Optional] int? offset, [Optional] ushort? limit, [Optional] uint? timeout, [Optional] IEnumerable<string> allowedUpdates)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (offset != null)
            {
                json.WriteNumber(PropertyNames.Offset, (int)offset);
            }

            if (limit != null)
            {
                json.WriteNumber(PropertyNames.Limit, (ushort)limit);
            }

            if (timeout != null)
            {
                json.WriteNumber(PropertyNames.Timeout, (uint)timeout);
            }

            if (allowedUpdates != default)
            {
                json.WriteStartArray(PropertyNames.AllowedUpdates);
                foreach (var value in allowedUpdates)
                {
                    json.WriteStringValue(value);
                }
                json.WriteEndArray();
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Update[]>(MethodNames.GetUpdates, stream);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
        /// <param name="allowedUpdates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Update[]> GetUpdatesAsync(this BotClient bot, [Optional] int? offset, [Optional] ushort? limit, [Optional] uint? timeout, [Optional] IEnumerable<string> allowedUpdates, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (offset != null)
            {
                json.WriteNumber(PropertyNames.Offset, (int)offset);
            }

            if (limit != null)
            {
                json.WriteNumber(PropertyNames.Limit, (ushort)limit);
            }

            if (timeout != null)
            {
                json.WriteNumber(PropertyNames.Timeout, (uint)timeout);
            }

            if (allowedUpdates != default)
            {
                json.WriteStartArray(PropertyNames.AllowedUpdates);
                foreach (var value in allowedUpdates)
                {
                    json.WriteStringValue(value);
                }
                json.WriteEndArray();
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Update[]>(MethodNames.GetUpdates, stream, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static T GetUpdates<T>(this BotClient bot)
            where T : IEnumerable<Update>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            return bot.RPC<T>(MethodNames.GetUpdates);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<T> GetUpdatesAsync<T>(this BotClient bot)
            where T : IEnumerable<Update>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            return await bot.RPCA<T>(MethodNames.GetUpdates).ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static T GetUpdates<T>(this BotClient bot, GetUpdatesArgs args)
            where T : IEnumerable<Update>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPC<T>(MethodNames.GetUpdates, args);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Optional parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<T> GetUpdatesAsync<T>(this BotClient bot, GetUpdatesArgs args, [Optional] CancellationToken cancellationToken)
            where T : IEnumerable<Update>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCA<T>(MethodNames.GetUpdates, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
        /// <param name="allowedUpdates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static T GetUpdates<T>(this BotClient bot, [Optional] int? offset, [Optional] ushort? limit, [Optional] uint? timeout, [Optional] IEnumerable<string> allowedUpdates)
            where T : IEnumerable<Update>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (offset != null)
            {
                json.WriteNumber(PropertyNames.Offset, (int)offset);
            }

            if (limit != null)
            {
                json.WriteNumber(PropertyNames.Limit, (ushort)limit);
            }

            if (timeout != null)
            {
                json.WriteNumber(PropertyNames.Timeout, (uint)timeout);
            }

            if (allowedUpdates != default)
            {
                json.WriteStartArray(PropertyNames.AllowedUpdates);
                foreach (var value in allowedUpdates)
                {
                    json.WriteStringValue(value);
                }
                json.WriteEndArray();
            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<T>(MethodNames.GetUpdates, stream);
        }
        /// <summary>Use this method to receive incoming updates using long polling. An Array of <see cref="Update"/> objects is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="offset">Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</param>
        /// <param name="limit">Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</param>
        /// <param name="timeout">Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</param>
        /// <param name="allowedUpdates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<T> GetUpdatesAsync<T>(this BotClient bot, [Optional] int? offset, [Optional] ushort? limit, [Optional] uint? timeout, [Optional] IEnumerable<string> allowedUpdates, [Optional] CancellationToken cancellationToken)
            where T : IEnumerable<Update>
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }
            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream);
            json.WriteStartObject();
            if (offset != null)
            {
                json.WriteNumber(PropertyNames.Offset, (int)offset);
            }
            if (limit != null)
            {
                json.WriteNumber(PropertyNames.Limit, (ushort)limit);
            }
            if (timeout != null)
            {
                json.WriteNumber(PropertyNames.Timeout, (uint)timeout);
            }
            if (allowedUpdates != default)
            {
                json.WriteStartArray(PropertyNames.AllowedUpdates);
                foreach (var value in allowedUpdates)
                {
                    json.WriteStringValue(value);
                }
                json.WriteEndArray();
            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<T>(MethodNames.GetUpdates, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}