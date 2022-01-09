// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object represents information about an order.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class OrderInfo : IEquatable<OrderInfo>
    {
        /// <summary>Optional. User name</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>Optional. User's phone number</summary>
        [JsonPropertyName(PropertyNames.PhoneNumber)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneNumber { get; set; }
        /// <summary>Optional. User email</summary>
        [JsonPropertyName(PropertyNames.Email)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Email { get; set; }
        /// <summary>Optional. User shipping address</summary>
        [JsonPropertyName(PropertyNames.ShippingAddress)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingAddress ShippingAddress { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as OrderInfo);
        }

        public bool Equals(OrderInfo other)
        {
            return other != null &&
                   Name == other.Name &&
                   PhoneNumber == other.PhoneNumber &&
                   Email == other.Email &&
                   EqualityComparer<ShippingAddress>.Default.Equals(ShippingAddress, other.ShippingAddress);
        }

        public override int GetHashCode()
        {
            int hashCode = 814573844;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Email);
            hashCode = hashCode * -1521134295 + EqualityComparer<ShippingAddress>.Default.GetHashCode(ShippingAddress);
            return hashCode;
        }

        public static bool operator ==(OrderInfo left, OrderInfo right)
        {
            return EqualityComparer<OrderInfo>.Default.Equals(left, right);
        }

        public static bool operator !=(OrderInfo left, OrderInfo right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
