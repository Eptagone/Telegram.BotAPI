// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains basic information about an invoice.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Invoice
    {
        /// <summary>Product name.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Product description.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Unique bot deep-linking parameter that can be used to generate this invoice.</summary>
        [JsonPropertyName(PropertyNames.StartParameter)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StartParameter { get; set; }
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code.</summary>
        [JsonPropertyName(PropertyNames.Currency)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonPropertyName(PropertyNames.TotalAmount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint TotalAmount { get; set; }
    }
}