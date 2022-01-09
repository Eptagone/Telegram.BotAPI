// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents a shipping address.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ShippingAddress : IEquatable<ShippingAddress>
    {
        /// <summary>ISO 3166-1 alpha-2 country code</summary>
        [JsonPropertyName(PropertyNames.CountryCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CountryCode { get; set; }
        /// <summary>State, if applicable</summary>
        [JsonPropertyName(PropertyNames.State)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string State { get; set; }
        /// <summary>City</summary>
        [JsonPropertyName(PropertyNames.City)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string City { get; set; }
        /// <summary>First line for the address</summary>
        [JsonPropertyName(PropertyNames.StreetLine1)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetLine1 { get; set; }
        /// <summary>Second line for the address</summary>
        [JsonPropertyName(PropertyNames.StreetLine2)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StreetLine2 { get; set; }
        /// <summary>Address post code</summary>
        [JsonPropertyName(PropertyNames.PostCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PostCode { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ShippingAddress);
        }

        public bool Equals(ShippingAddress other)
        {
            return other != null &&
                   CountryCode == other.CountryCode &&
                   State == other.State &&
                   City == other.City &&
                   StreetLine1 == other.StreetLine1 &&
                   StreetLine2 == other.StreetLine2 &&
                   PostCode == other.PostCode;
        }

        public override int GetHashCode()
        {
            int hashCode = -702260041;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CountryCode);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(State);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(City);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StreetLine1);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StreetLine2);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PostCode);
            return hashCode;
        }

        public static bool operator ==(ShippingAddress left, ShippingAddress right)
        {
            return EqualityComparer<ShippingAddress>.Default.Equals(left, right);
        }

        public static bool operator !=(ShippingAddress left, ShippingAddress right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
