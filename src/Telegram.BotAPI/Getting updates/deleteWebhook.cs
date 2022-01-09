// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.GettingUpdates
{
    /// <summary>Getting Updates</summary>
    public static partial class GettingUpdatesExtensions
    {
        /// <summary>Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success. Requires no parameters.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="dropPendingUpdates">Pass True to drop all pending updates.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static bool DeleteWebhook(this BotClient bot, [Optional] bool? dropPendingUpdates)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (dropPendingUpdates != null)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteBoolean(PropertyNames.DropPendingUpdates, (bool)dropPendingUpdates);
                json.WriteEndObject();
                json.Flush(); json.Dispose();
                stream.Seek(0, SeekOrigin.Begin);
                return bot.RPC<bool>(MethodNames.DeleteWebhook, stream);
            }
            else
            {
                return bot.RPC<bool>(MethodNames.DeleteWebhook);
            }
        }
        /// <summary>Use this method to remove webhook integration if you decide to switch back to getUpdates. Returns True on success. Requires no parameters.</summary>
        /// <param name="bot">Bot Client</param>
        /// <param name="dropPendingUpdates">Pass True to drop all pending updates.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<bool> DeleteWebhookAsync(this BotClient bot, [Optional] bool? dropPendingUpdates, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            if (dropPendingUpdates != null)
            {
                var stream = new MemoryStream();
                using var json = new Utf8JsonWriter(stream);
                json.WriteStartObject();
                json.WriteBoolean(PropertyNames.DropPendingUpdates, (bool)dropPendingUpdates);
                json.WriteEndObject();
                await json.FlushAsync(cancellationToken).ConfigureAwait(false);
                await json.DisposeAsync().ConfigureAwait(false);
                stream.Seek(0, SeekOrigin.Begin);
                return await bot.RPCA<bool>(MethodNames.DeleteWebhook, stream, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                return await bot.RPCA<bool>(MethodNames.DeleteWebhook, cancellationToken).ConfigureAwait(false);
            }
        }
    }
}
