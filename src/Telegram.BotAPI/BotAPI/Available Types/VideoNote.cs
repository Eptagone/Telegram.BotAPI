// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a video message (available in Telegram apps as of v.4.0).</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class VideoNote : BaseFile, IThumb<PhotoSize>, IEquatable<VideoNote>
    {
        ///<summary>Video width and height (diameter of the video message) as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Length)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Length { get; set; }
        ///<summary>Duration of the video in seconds as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Video thumbnail.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName(PropertyNames.FileSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileSize { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as VideoNote);
        }

        public bool Equals(VideoNote other)
        {
            return other != null &&
                   FileId == other.FileId &&
                   FileUniqueId == other.FileUniqueId &&
                   Length == other.Length &&
                   Duration == other.Duration &&
                   EqualityComparer<PhotoSize>.Default.Equals(Thumb, other.Thumb) &&
                   FileSize == other.FileSize;
        }

        public override int GetHashCode()
        {
            int hashCode = -1054635646;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileUniqueId);
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            hashCode = hashCode * -1521134295 + Duration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(Thumb);
            hashCode = hashCode * -1521134295 + FileSize.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(VideoNote left, VideoNote right)
        {
            return EqualityComparer<VideoNote>.Default.Equals(left, right);
        }

        public static bool operator !=(VideoNote left, VideoNote right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
