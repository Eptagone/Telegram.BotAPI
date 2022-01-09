// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents one shipping option.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ShippingOption : IEquatable<ShippingOption>
    {
        /// <summary>Shipping option identifier</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Option title</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>List of price portions</summary>
        [JsonPropertyName(PropertyNames.Prices)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<LabeledPrice> Prices { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ShippingOption);
        }

        public bool Equals(ShippingOption other)
        {
            return other != null &&
                   Id == other.Id &&
                   Title == other.Title &&
                   EqualityComparer<IEnumerable<LabeledPrice>>.Default.Equals(Prices, other.Prices);
        }

        public override int GetHashCode()
        {
            int hashCode = 46498380;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<LabeledPrice>>.Default.GetHashCode(Prices);
            return hashCode;
        }

        public static bool operator ==(ShippingOption left, ShippingOption right)
        {
            return EqualityComparer<ShippingOption>.Default.Equals(left, right);
        }

        public static bool operator !=(ShippingOption left, ShippingOption right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
