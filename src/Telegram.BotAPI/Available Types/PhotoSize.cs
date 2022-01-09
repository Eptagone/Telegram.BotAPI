// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents one size of a photo or a file / sticker thumbnail.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PhotoSize : TelegramFileBase, IEquatable<PhotoSize>
    {
        ///<summary>Photo width.</summary>
        [JsonPropertyName(PropertyNames.Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Photo height.</summary>
        [JsonPropertyName(PropertyNames.Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName(PropertyNames.FileSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileSize { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PhotoSize);
        }

        public bool Equals(PhotoSize other)
        {
            return other != null &&
                   FileId == other.FileId &&
                   FileUniqueId == other.FileUniqueId &&
                   Width == other.Width &&
                   Height == other.Height &&
                   FileSize == other.FileSize;
        }

        public override int GetHashCode()
        {
            int hashCode = 1709852582;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileUniqueId);
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            hashCode = hashCode * -1521134295 + FileSize.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(PhotoSize left, PhotoSize right)
        {
            return EqualityComparer<PhotoSize>.Default.Equals(left, right);
        }

        public static bool operator !=(PhotoSize left, PhotoSize right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
