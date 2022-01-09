// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.GettingUpdates
{
    public static partial class GettingUpdatesExtensions
    {
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SetWebhook(this BotClient bot, SetWebhookArgs args)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return bot.RPCF<bool>(MethodNames.SetWebhook, args);
        }
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="args">Parameters.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SetWebhookAsync(this BotClient bot, SetWebhookArgs args, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (args == default)
            {
                throw new ArgumentNullException(nameof(args));
            }

            return await bot.RPCAF<bool>(MethodNames.SetWebhook, args, cancellationToken: cancellationToken).ConfigureAwait(false);
        }
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="url">HTTPS url to send updates to. Use an empty string to remove webhook integration.</param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</param>
        /// <param name="ipAddress">The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS</param>
        /// <param name="maxConnections">Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.</param>
        /// <param name="allowedUpdates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</para></param>
        /// <param name="dropPendingUpdates">Pass True to drop all pending updates.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SetWebhook(this BotClient bot, string url, [Optional] InputFile certificate, [Optional] string ipAddress, [Optional] uint? maxConnections, [Optional] IEnumerable<string> allowedUpdates, [Optional] bool? dropPendingUpdates)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (certificate == default)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteString(PropertyNames.Url, url);
                if (!string.IsNullOrEmpty(ipAddress))
                {
                    json.WriteString(PropertyNames.IpAddress, ipAddress);
                }

                if (maxConnections != null)
                {
                    json.WriteNumber(PropertyNames.MaxConnections, (uint)maxConnections);
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
                if (dropPendingUpdates != null)
                {
                    json.WriteBoolean(PropertyNames.DropPendingUpdates, (bool)dropPendingUpdates);
                }

                json.WriteEndObject();
                json.Flush(); json.Dispose();
                stream.Seek(0, SeekOrigin.Begin);
                return bot.RPC<bool>(MethodNames.SetWebhook, stream);
            }
            else
            {
                var args = new SetWebhookArgs
                {
                    Url = url,
                    Certificate = certificate,
                    IpAddress = ipAddress,
                    MaxConnections = maxConnections,
                    AllowedUpdates = allowedUpdates,
                    DropPendingUpdates = dropPendingUpdates
                };

                return bot.RPCF<bool>(MethodNames.SetWebhook, args);
            }
        }
        /// <summary>Use this method to specify a url and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified url, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="url">HTTPS url to send updates to. Use an empty string to remove webhook integration.</param>
        /// <param name="ipAddress">The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS</param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our <a href="https://core.telegram.org/bots/self-signed">self-signed guide</a> for details.</param>
        /// <param name="maxConnections">Maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot‘s server, and higher values to increase your bot’s throughput.</param>
        /// <param name="allowedUpdates">List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</para></param>
        /// <param name="dropPendingUpdates">Pass True to drop all pending updates.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SetWebhookAsync(this BotClient bot, string url, [Optional] InputFile certificate, [Optional] string ipAddress, [Optional] uint? maxConnections, [Optional] IEnumerable<string> allowedUpdates, [Optional] bool? dropPendingUpdates, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (certificate == default)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteString(PropertyNames.Url, url);
                if (!string.IsNullOrEmpty(ipAddress))
                {
                    json.WriteString(PropertyNames.IpAddress, ipAddress);
                }

                if (maxConnections != null)
                {
                    json.WriteNumber(PropertyNames.MaxConnections, (uint)maxConnections);
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
                if (dropPendingUpdates != null)
                {
                    json.WriteBoolean(PropertyNames.DropPendingUpdates, (bool)dropPendingUpdates);
                }

                json.WriteEndObject();
                await json.FlushAsync(cancellationToken).ConfigureAwait(false); await json.DisposeAsync().ConfigureAwait(false);
                stream.Seek(0, SeekOrigin.Begin);
                return await bot.RPCA<bool>(MethodNames.SetWebhook, stream, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                var args = new SetWebhookArgs
                {
                    Url = url,
                    Certificate = certificate,
                    IpAddress = ipAddress,
                    MaxConnections = maxConnections,
                    AllowedUpdates = allowedUpdates,
                    DropPendingUpdates = dropPendingUpdates
                };

                return await bot.RPCAF<bool>(MethodNames.SetWebhook, args, cancellationToken: cancellationToken).ConfigureAwait(false);
            }
        }
    }
}