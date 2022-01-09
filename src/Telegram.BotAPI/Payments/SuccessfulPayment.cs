// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains basic information about a successful payment.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SuccessfulPayment : IEquatable<SuccessfulPayment>
    {
        /// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code</summary>
        [JsonPropertyName(PropertyNames.Currency)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; set; }
        /// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
        [JsonPropertyName(PropertyNames.TotalAmount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TotalAmount { get; set; }
        /// <summary>Bot specified invoice payload.</summary>
        [JsonPropertyName(PropertyNames.InvoicePayload)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoicePayload { get; set; }
        /// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
        [JsonPropertyName(PropertyNames.ShippingOptionId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ShippingOptionId { get; set; }
        /// <summary>Optional. Order info provided by the user.</summary>
        [JsonPropertyName(PropertyNames.OrderInfo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public OrderInfo OrderInfo { get; set; }
        /// <summary>Telegram payment identifier.</summary>
        [JsonPropertyName(PropertyNames.TelegramPaymentChargeId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string TelegramPaymentChargeId { get; set; }
        /// <summary>Provider payment identifier.</summary>
        [JsonPropertyName(PropertyNames.ProviderPaymentChargeId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ProviderPaymentChargeId { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as SuccessfulPayment);
        }

        public bool Equals(SuccessfulPayment other)
        {
            return other != null &&
                   Currency == other.Currency &&
                   TotalAmount == other.TotalAmount &&
                   InvoicePayload == other.InvoicePayload &&
                   ShippingOptionId == other.ShippingOptionId &&
                   EqualityComparer<OrderInfo>.Default.Equals(OrderInfo, other.OrderInfo) &&
                   TelegramPaymentChargeId == other.TelegramPaymentChargeId &&
                   ProviderPaymentChargeId == other.ProviderPaymentChargeId;
        }

        public override int GetHashCode()
        {
            int hashCode = 1627006191;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Currency);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TotalAmount);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InvoicePayload);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ShippingOptionId);
            hashCode = hashCode * -1521134295 + EqualityComparer<OrderInfo>.Default.GetHashCode(OrderInfo);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(TelegramPaymentChargeId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ProviderPaymentChargeId);
            return hashCode;
        }

        public static bool operator ==(SuccessfulPayment left, SuccessfulPayment right)
        {
            return EqualityComparer<SuccessfulPayment>.Default.Equals(left, right);
        }

        public static bool operator !=(SuccessfulPayment left, SuccessfulPayment right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
