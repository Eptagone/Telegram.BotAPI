// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments
{
    /// <summary>This object contains information about an incoming shipping query.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ShippingQuery : IEquatable<ShippingQuery>
    {
        /// <summary>Unique query identifier</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>User who sent the query</summary>
        [JsonPropertyName(PropertyNames.From)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvailableTypes.User From { get; set; }
        /// <summary>Bot specified invoice payload</summary>
        [JsonPropertyName(PropertyNames.InvoicePayload)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InvoicePayload { get; set; }
        /// <summary>User specified shipping address</summary>
        [JsonPropertyName(PropertyNames.ShippingAddress)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ShippingAddress ShippingAddress { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ShippingQuery);
        }

        public bool Equals(ShippingQuery other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<User>.Default.Equals(From, other.From) &&
                   InvoicePayload == other.InvoicePayload &&
                   EqualityComparer<ShippingAddress>.Default.Equals(ShippingAddress, other.ShippingAddress);
        }

        public override int GetHashCode()
        {
            int hashCode = -837343580;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InvoicePayload);
            hashCode = hashCode * -1521134295 + EqualityComparer<ShippingAddress>.Default.GetHashCode(ShippingAddress);
            return hashCode;
        }

        public static bool operator ==(ShippingQuery left, ShippingQuery right)
        {
            return EqualityComparer<ShippingQuery>.Default.Equals(left, right);
        }

        public static bool operator !=(ShippingQuery left, ShippingQuery right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
