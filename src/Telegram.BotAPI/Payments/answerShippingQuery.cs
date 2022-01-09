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

namespace Telegram.BotAPI.Payments
{
    public static partial class PaymentsExtensions
    {
        /// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="shippingQueryId">Unique identifier for the query to be answered</param>
        /// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
        /// <param name="shippingOptions">Required if ok is True. A JSON-serialized array of available shipping options.</param>
        /// <param name="errorMessage">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static Message AnswerShippingQuery(this BotClient bot, string shippingQueryId, bool ok, [Optional] IEnumerable<ShippingOption> shippingOptions, [Optional] string errorMessage)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("shipping_query_id", shippingQueryId);
            json.WriteBoolean("ok", ok);
            if (ok)
            {
                if (shippingOptions == default)
                {
                    throw new ArgumentNullException(nameof(shippingOptions));
                }

                json.WriteStartArray("shipping_options");
                foreach (var option in shippingOptions)
                {
                    json.WriteStartObject();
                    json.WriteString(PropertyNames.Id, option.Id);
                    json.WriteString(PropertyNames.Title, option.Title);
                    json.WriteStartArray(PropertyNames.Prices);
                    foreach (var price in option.Prices)
                    {
                        json.WriteStartObject();
                        json.WriteString(PropertyNames.Label, price.Label);
                        json.WriteNumber(PropertyNames.Amount, price.Amount);
                        json.WriteEndObject();
                    }
                    json.WriteEndArray();
                    json.WriteEndObject();
                }
                json.WriteEndArray();
            }
            else
            {
                if (errorMessage == default)
                {
                    throw new ArgumentNullException(nameof(errorMessage));
                }

                json.WriteString("error_message", errorMessage);

            }
            json.WriteEndObject();
            json.Flush(); json.Dispose();
            stream.Seek(0, SeekOrigin.Begin);
            return bot.RPC<Message>(MethodNames.AnswerShippingQuery, stream);
        }
        /// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
        /// <param name="bot">BotClient</param>
        /// <param name="shippingQueryId">Unique identifier for the query to be answered</param>
        /// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
        /// <param name="shippingOptions">Required if ok is True. A JSON-serialized array of available shipping options.</param>
        /// <param name="errorMessage">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
        /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
        /// <returns><see cref="Message"/></returns>
        /// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
        /// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
        public static async Task<Message> AnswerShippingQueryAsync(this BotClient bot, string shippingQueryId, bool ok, [Optional] IEnumerable<ShippingOption> shippingOptions, [Optional] string errorMessage, [Optional] CancellationToken cancellationToken)
        {
            if (bot == default)
            {
                throw new ArgumentNullException(nameof(bot));
            }

            var stream = new MemoryStream();
            using var json = new Utf8JsonWriter(stream, new JsonWriterOptions { Indented = true });
            json.WriteStartObject();
            json.WriteString("shipping_query_id", shippingQueryId);
            json.WriteBoolean("ok", ok);
            if (ok)
            {
                if (shippingOptions == default)
                {
                    throw new ArgumentNullException(nameof(shippingOptions));
                }

                json.WriteStartArray("shipping_options");
                foreach (var option in shippingOptions)
                {
                    json.WriteStartObject();
                    json.WriteString(PropertyNames.Id, option.Id);
                    json.WriteString(PropertyNames.Title, option.Title);
                    json.WriteStartArray(PropertyNames.Prices);
                    foreach (var price in option.Prices)
                    {
                        json.WriteStartObject();
                        json.WriteString(PropertyNames.Label, price.Label);
                        json.WriteNumber(PropertyNames.Amount, price.Amount);
                        json.WriteEndObject();
                    }
                    json.WriteEndArray();
                    json.WriteEndObject();
                }
                json.WriteEndArray();
            }
            else
            {
                if (errorMessage == default)
                {
                    throw new ArgumentNullException(nameof(errorMessage));
                }

                json.WriteString("error_message", errorMessage);

            }
            json.WriteEndObject();
            await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            await json.DisposeAsync().ConfigureAwait(false);
            stream.Seek(0, SeekOrigin.Begin);
            return await bot.RPCA<Message>(MethodNames.AnswerShippingQuery, stream, cancellationToken).ConfigureAwait(false);
        }
    }
}
