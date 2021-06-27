// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Contains data required for decrypting and authenticating EncryptedPassportElement. See the <a href="https://core.telegram.org/passport#receiving-information">Telegram Passport Documentation</a> for a complete description of the data decryption and authentication processes.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EncryptedCredentials : IEquatable<EncryptedCredentials>
    {
        /// <summary>Base64-encoded encrypted JSON-serialized data with unique user's payload, data hashes and secrets required for EncryptedPassportElement decryption and authentication.</summary>
        [JsonPropertyName(PropertyNames.Data)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Data { get; set; }
        /// <summary>Base64-encoded data hash for data authentication.</summary>
        [JsonPropertyName(PropertyNames.Hash)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Hash { get; set; }
        /// <summary>Base64-encoded secret, encrypted with the bot's public RSA key, required for data decryption.</summary>
        [JsonPropertyName(PropertyNames.Secret)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Secret { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as EncryptedCredentials);
        }

        public bool Equals(EncryptedCredentials other)
        {
            return other != null &&
                   Data == other.Data &&
                   Hash == other.Hash &&
                   Secret == other.Secret;
        }

        public override int GetHashCode()
        {
            int hashCode = 651824479;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Data);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Hash);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Secret);
            return hashCode;
        }

        public static bool operator ==(EncryptedCredentials left, EncryptedCredentials right)
        {
            return EqualityComparer<EncryptedCredentials>.Default.Equals(left, right);
        }

        public static bool operator !=(EncryptedCredentials left, EncryptedCredentials right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
