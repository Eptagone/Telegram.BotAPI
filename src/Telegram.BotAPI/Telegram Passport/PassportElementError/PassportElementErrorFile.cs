// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>Represents an issue with a document scan. The error is considered resolved when the file with the document scan changes.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportElementErrorFile : PassportElementError, IEquatable<PassportElementErrorFile>
    {
        /// <summary>Error source, must be file.</summary>
        [JsonPropertyName(PropertyNames.Source)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Source => PassportElementErrorSource.File;
        /// <summary>The section of the user's Telegram Passport which has the issue, one of “utility_bill”, “bank_statement”, “rental_agreement”, “passport_registration”, “temporary_registration”.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type { get; set; }
        /// <summary>Base64-encoded file hash.</summary>
        [JsonPropertyName(PropertyNames.FileHash)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileHash { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PassportElementErrorFile);
        }

        public bool Equals(PassportElementErrorFile other)
        {
            return other != null &&
                   Source == other.Source &&
                   Type == other.Type &&
                   Message == other.Message &&
                   Source == other.Source &&
                   Type == other.Type &&
                   FileHash == other.FileHash;
        }

        public override int GetHashCode()
        {
            int hashCode = -539630311;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Message);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Source);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileHash);
            return hashCode;
        }

        public static bool operator ==(PassportElementErrorFile left, PassportElementErrorFile right)
        {
            return EqualityComparer<PassportElementErrorFile>.Default.Equals(left, right);
        }

        public static bool operator !=(PassportElementErrorFile left, PassportElementErrorFile right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
