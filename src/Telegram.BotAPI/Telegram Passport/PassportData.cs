// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Contains information about Telegram Passport data shared with the bot by the user.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportData : IEquatable<PassportData>
    {
        /// <summary>Array with information about documents and other Telegram Passport elements that was shared with the bot.</summary>
        [JsonPropertyName(PropertyNames.Data)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<EncryptedPassportElement> Data { get; set; }
        /// <summary>Encrypted credentials required to decrypt the data.</summary>
        [JsonPropertyName(PropertyNames.Credentials)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public EncryptedCredentials Credentials { get; set; }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PassportData);
        }

        public bool Equals(PassportData other)
        {
            return other != null &&
                   EqualityComparer<IEnumerable<EncryptedPassportElement>>.Default.Equals(Data, other.Data) &&
                   EqualityComparer<EncryptedCredentials>.Default.Equals(Credentials, other.Credentials);
        }

        public override int GetHashCode()
        {
            int hashCode = -1529841922;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<EncryptedPassportElement>>.Default.GetHashCode(Data);
            hashCode = hashCode * -1521134295 + EqualityComparer<EncryptedCredentials>.Default.GetHashCode(Credentials);
            return hashCode;
        }

        public static bool operator ==(PassportData left, PassportData right)
        {
            return EqualityComparer<PassportData>.Default.Equals(left, right);
        }

        public static bool operator !=(PassportData left, PassportData right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
