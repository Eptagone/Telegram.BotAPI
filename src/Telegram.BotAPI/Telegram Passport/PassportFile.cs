// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.TelegramPassport
{
    /// <summary>This object represents a file uploaded to Telegram Passport. Currently all Telegram Passport files are in JPEG format when decrypted and don't exceed 10MB.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PassportFile : IEquatable<PassportFile>
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName(PropertyNames.FileId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileId { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName(PropertyNames.FileUniqueId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileUniqueId { get; set; }
        /// <summary>File size</summary>
        [JsonPropertyName(PropertyNames.FileSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileSize { get; set; }
        /// <summary>Unix time when the file was uploaded</summary>
        [JsonPropertyName(PropertyNames.FileDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PassportFile);
        }

        public bool Equals(PassportFile other)
        {
            return other != null &&
                   FileId == other.FileId &&
                   FileUniqueId == other.FileUniqueId &&
                   FileSize == other.FileSize &&
                   FileDate == other.FileDate;
        }

        public override int GetHashCode()
        {
            int hashCode = -1433868396;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileUniqueId);
            hashCode = hashCode * -1521134295 + FileSize.GetHashCode();
            hashCode = hashCode * -1521134295 + FileDate.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(PassportFile left, PassportFile right)
        {
            return EqualityComparer<PassportFile>.Default.Equals(left, right);
        }

        public static bool operator !=(PassportFile left, PassportFile right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
