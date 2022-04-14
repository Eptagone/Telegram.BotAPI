// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable enable

namespace Telegram.BotAPI.Payments
{
    /// <summary>AnswerShippingQuery method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AnswerShippingQueryArgs
    {
        /// <summary>
        /// Initialize a new instance of <see cref="AnswerShippingQueryArgs"/>.
        /// </summary>
        /// <param name="shippingQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AnswerShippingQueryArgs(string shippingQueryId, bool ok)
        {
            ShippingQueryId = shippingQueryId ?? throw new ArgumentNullException(nameof(shippingQueryId));
            Ok = ok;
        }

        /// <summary>
        /// Initialize a new instance of <see cref="AnswerShippingQueryArgs"/>.
        /// </summary>
        /// <param name="shippingQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="shippingOptions">An array of <see cref="ShippingOption"/>.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AnswerShippingQueryArgs(string shippingQueryId, IEnumerable<ShippingOption> shippingOptions)
        {
            ShippingQueryId = shippingQueryId ?? throw new ArgumentNullException(nameof(shippingQueryId));
            Ok = true;
            ShippingOptions = shippingOptions ?? throw new ArgumentNullException(nameof(shippingOptions));
        }

        /// <summary>
        /// Initialize a new instance of <see cref="AnswerShippingQueryArgs"/>.
        /// </summary>
        /// <param name="shippingQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="errorMessage">Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AnswerShippingQueryArgs(string shippingQueryId, string errorMessage)
        {
            ShippingQueryId = shippingQueryId ?? throw new ArgumentNullException(nameof(shippingQueryId));
            Ok = false;
            ErrorMessage = errorMessage ?? throw new ArgumentNullException(nameof(errorMessage));
        }

        /// <summary>Unique identifier for the query to be answered.</summary>
        [JsonPropertyName(PropertyNames.ShippingQueryId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShippingQueryId { get; }
        /// <summary>Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</summary>
        [JsonPropertyName(PropertyNames.Ok)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Ok { get; }
        /// <summary>Required if ok is True. An array of <see cref="ShippingOption"/>.</summary>
        [JsonPropertyName(PropertyNames.ShippingOptions)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<ShippingOption>? ShippingOptions { get; set; }
        /// <summary>Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</summary>
        [JsonPropertyName(PropertyNames.ErrorMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ErrorMessage { get; set; }
    }
}
