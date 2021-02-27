// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Represents an issue in an unspecified place. The error is considered resolved when new data is added.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportElementErrorUnspecified : PassportElementError, IEquatable<PassportElementErrorUnspecified>
    {
        /// <summary>Error source, must be unspecified.</summary>
        [JsonPropertyName(PropertyNames.Source)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => "unspecified";
        /// <summary>Type of element of the user's Telegram Passport which has the issue.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded element hash.</summary>
        [JsonPropertyName(PropertyNames.ElementHash)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ElementHash { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PassportElementErrorUnspecified);
        }

        public bool Equals(PassportElementErrorUnspecified other)
        {
            return other != null &&
                   Source == other.Source &&
                   Type == other.Type &&
                   Message == other.Message &&
                   Source == other.Source &&
                   Type == other.Type &&
                   ElementHash == other.ElementHash;
        }

        public override int GetHashCode()
        {
            int hashCode = 1806438429;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ElementHash);
            return hashCode;
        }

        public static bool operator ==(PassportElementErrorUnspecified left, PassportElementErrorUnspecified right)
        {
            return EqualityComparer<PassportElementErrorUnspecified>.Default.Equals(left, right);
        }

        public static bool operator !=(PassportElementErrorUnspecified left, PassportElementErrorUnspecified right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
