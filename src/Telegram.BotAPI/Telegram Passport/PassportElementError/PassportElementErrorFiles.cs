// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Represents an issue with a list of scans. The error is considered resolved when the list of files containing the scans changes.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportElementErrorFiles : PassportElementError, IEquatable<PassportElementErrorFiles>
    {
        /// <summary>Error source, must be files.</summary>
        [JsonPropertyName(PropertyNames.Source)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => PassportElementErrorSource.Files;
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>List of base64-encoded file hashes.</summary>
        [JsonPropertyName(PropertyNames.FileHashes)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> FileHashes { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PassportElementErrorFiles);
        }

        public bool Equals(PassportElementErrorFiles other)
        {
            return other != null &&
                   Source == other.Source &&
                   Type == other.Type &&
                   Message == other.Message &&
                   Source == other.Source &&
                   Type == other.Type &&
                   EqualityComparer<IEnumerable<string>>.Default.Equals(FileHashes, other.FileHashes);
        }

        public override int GetHashCode()
        {
            int hashCode = -1313300663;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<string>>.Default.GetHashCode(FileHashes);
            return hashCode;
        }

        public static bool operator ==(PassportElementErrorFiles left, PassportElementErrorFiles right)
        {
            return EqualityComparer<PassportElementErrorFiles>.Default.Equals(left, right);
        }

        public static bool operator !=(PassportElementErrorFiles left, PassportElementErrorFiles right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
