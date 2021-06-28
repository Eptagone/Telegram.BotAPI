// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Represents an issue in one of the data fields that was provided by the user. The error is considered resolved when the field's value changes.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportElementErrorDataField : PassportElementError, IEquatable<PassportElementErrorDataField>
    {
        /// <summary>Error source, must be data.</summary>
        [JsonPropertyName(PropertyNames.Source)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => PassportElementErrorSource.Data;
        /// <summary>The section of the user's Telegram Passport which has the error, one of “personal_details”, “passport”, “driver_license”, “identity_card”, “internal_passport”, “address”.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>Name of the data field which has the error.</summary>
        [JsonPropertyName(PropertyNames.FieldName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FieldName { get; set; }
        /// <summary>Base64-encoded data hash.</summary>
        [JsonPropertyName(PropertyNames.DataHash)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DataHash { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PassportElementErrorDataField);
        }

        public bool Equals(PassportElementErrorDataField other)
        {
            return other != null &&
                   Source == other.Source &&
                   Type == other.Type &&
                   Message == other.Message &&
                   Source == other.Source &&
                   Type == other.Type &&
                   FieldName == other.FieldName &&
                   DataHash == other.DataHash;
        }

        public override int GetHashCode()
        {
            int hashCode = -2002396357;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FieldName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DataHash);
            return hashCode;
        }

        public static bool operator ==(PassportElementErrorDataField left, PassportElementErrorDataField right)
        {
            return EqualityComparer<PassportElementErrorDataField>.Default.Equals(left, right);
        }

        public static bool operator !=(PassportElementErrorDataField left, PassportElementErrorDataField right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
