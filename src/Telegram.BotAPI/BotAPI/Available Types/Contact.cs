// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a phone contact.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Contact : IContact, IEquatable<Contact>
    {
        /// <summary>Contact's phone number.</summary>
        [JsonPropertyName(PropertyNames.PhoneNumber)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneNumber { get; set; }
        /// <summary>Contact's first name.</summary>
        [JsonPropertyName(PropertyNames.FirstName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        [JsonPropertyName(PropertyNames.LastName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }
        /// <summary>Optional. Contact's user identifier in Telegram.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long UserId { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
        [JsonPropertyName(PropertyNames.Vcard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Vcard { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Contact);
        }

        public bool Equals(Contact other)
        {
            return other != null &&
                   PhoneNumber == other.PhoneNumber &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   UserId == other.UserId &&
                   Vcard == other.Vcard;
        }

        public override int GetHashCode()
        {
            int hashCode = 267866028;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + UserId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Vcard);
            return hashCode;
        }

        public static bool operator ==(Contact left, Contact right)
        {
            return EqualityComparer<Contact>.Default.Equals(left, right);
        }

        public static bool operator !=(Contact left, Contact right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}