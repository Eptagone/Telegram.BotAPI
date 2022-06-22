// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

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
        /// <summary>Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="url">HTTPS URL to send updates to. Use an empty string to remove webhook integration.</param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our self-signed guide for details.</param>
        /// <param name="ipAddress">The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS.</param>
        /// <param name="maxConnections">The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot's server, and higher values to increase your bot's throughput.</param>
        /// <param name="allowedUpdates">A JSON-serialized list of the update types you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all update types except chat_member (default). If not specified, the previous setting will be used. <br/>
        /// Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</param>
        /// <param name="dropPendingUpdates">Pass True to drop all pending updates.</param>
        /// <param name="secretToken">A secret token to be sent in a header “X-Telegram-Bot-Api-Secret-Token” in every webhook request, 1-256 characters. Only characters A-Z, a-z, 0-9, _ and - are allowed. The header is useful to ensure that the request comes from a webhook set by you.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool SetWebhook(this BotClient api, string url, [Optional] InputFile? certificate, [Optional] string? ipAddress, [Optional] uint? maxConnections, [Optional] IEnumerable<string>? allowedUpdates, [Optional] bool? dropPendingUpdates, [Optional] string? secretToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SetWebhookArgs(url)
            {
                Certificate = certificate,
                IpAddress = ipAddress,
                MaxConnections = maxConnections,
                AllowedUpdates = allowedUpdates,
                DropPendingUpdates = dropPendingUpdates,
                SecretToken = secretToken
            };
            return api.RPCF<bool>(MethodNames.SetWebhook, args);
        }

        /// <summary>Use this method to specify a URL and receive incoming updates via an outgoing webhook. Whenever there is an update for the bot, we will send an HTTPS POST request to the specified URL, containing a JSON-serialized Update. In case of an unsuccessful request, we will give up after a reasonable amount of attempts. Returns True on success.</summary>
        /// <param name="api">The bot client.</param>
        /// <param name="url">HTTPS URL to send updates to. Use an empty string to remove webhook integration.</param>
        /// <param name="certificate">Upload your public key certificate so that the root certificate in use can be checked. See our self-signed guide for details.</param>
        /// <param name="ipAddress">The fixed IP address which will be used to send webhook requests instead of the IP address resolved through DNS.</param>
        /// <param name="maxConnections">The maximum allowed number of simultaneous HTTPS connections to the webhook for update delivery, 1-100. Defaults to 40. Use lower values to limit the load on your bot's server, and higher values to increase your bot's throughput.</param>
        /// <param name="allowedUpdates">A JSON-serialized list of the update types you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all update types except chat_member (default). If not specified, the previous setting will be used.<br/>
        /// Please note that this parameter doesn't affect updates created before the call to the setWebhook, so unwanted updates may be received for a short period of time.</param>
        /// <param name="dropPendingUpdates">Pass True to drop all pending updates.</param>
        /// <param name="secretToken">A secret token to be sent in a header “X-Telegram-Bot-Api-Secret-Token” in every webhook request, 1-256 characters. Only characters A-Z, a-z, 0-9, _ and - are allowed. The header is useful to ensure that the request comes from a webhook set by you.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> SetWebhookAsync(this BotClient api, string url, [Optional] InputFile? certificate, [Optional] string? ipAddress, [Optional] uint? maxConnections, [Optional] IEnumerable<string>? allowedUpdates, [Optional] bool? dropPendingUpdates, [Optional] string? secretToken, [Optional] CancellationToken cancellationToken)
        {
            if (api == null) { throw new ArgumentNullException(nameof(api)); }
            var args = new SetWebhookArgs(url)
            {
                Certificate = certificate,
                IpAddress = ipAddress,
                MaxConnections = maxConnections,
                AllowedUpdates = allowedUpdates,
                DropPendingUpdates = dropPendingUpdates,
                SecretToken = secretToken
            };
            return await api.RPCAF<bool>(MethodNames.SetWebhook, args, cancellationToken).ConfigureAwait(false);
        }
    }
}
