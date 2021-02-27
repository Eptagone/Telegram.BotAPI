// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents a file ready to be downloaded. The file can be downloaded via the link https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt;. It is guaranteed that the link will be valid for at least 1 hour. When the link expires, a new one can be requested by calling getFile.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class File : BaseFile, IEquatable<File>
    {
        ///<summary>Optional. File size, if known.</summary>
        [JsonPropertyName(PropertyNames.FileSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileSize { get; set; }
        ///<summary>Optional. File path. Use https://api.telegram.org/file/bot&lt;token&gt;/&lt;file_path&gt; to get the file.</summary>
        [JsonPropertyName(PropertyNames.FilePath)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FilePath { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as File);
        }

        public bool Equals(File other)
        {
            return other != null &&
                   FileId == other.FileId &&
                   FileUniqueId == other.FileUniqueId &&
                   FileSize == other.FileSize &&
                   FilePath == other.FilePath;
        }

        public override int GetHashCode()
        {
            int hashCode = -1737632191;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileUniqueId);
            hashCode = hashCode * -1521134295 + FileSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FilePath);
            return hashCode;
        }

        public static bool operator ==(File left, File right)
        {
            return EqualityComparer<File>.Default.Equals(left, right);
        }

        public static bool operator !=(File left, File right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}