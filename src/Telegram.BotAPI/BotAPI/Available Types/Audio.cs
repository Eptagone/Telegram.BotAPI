// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents an audio file to be treated as music by the Telegram clients.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Audio : BaseFile, IThumb<PhotoSize>, IEquatable<Audio>
    {
        ///<summary>Duration of the audio in seconds as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Performer of the audio as defined by sender or by audio tags.</summary>
        [JsonPropertyName(PropertyNames.Performer)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; set; }
        ///<summary>Optional. Title of the audio as defined by sender or by audio tags.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Optional. Original filename as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.FileName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileName { get; set; }
        ///<summary>Optional. MIME type of the file as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.MimeType)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; set; }
        ///<summary>Optional. File size.</summary>
        [JsonPropertyName(PropertyNames.FileSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint FileSize { get; set; }
        ///<summary>Optional. Thumbnail of the album cover to which the music file belongs.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Audio);
        }

        public bool Equals(Audio other)
        {
            return other != null &&
                   FileId == other.FileId &&
                   FileUniqueId == other.FileUniqueId &&
                   Duration == other.Duration &&
                   Performer == other.Performer &&
                   Title == other.Title &&
                   FileName == other.FileName &&
                   MimeType == other.MimeType &&
                   FileSize == other.FileSize &&
                   EqualityComparer<PhotoSize>.Default.Equals(Thumb, other.Thumb);
        }

        public override int GetHashCode()
        {
            int hashCode = -1371790424;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileUniqueId);
            hashCode = hashCode * -1521134295 + Duration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Performer);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FileName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MimeType);
            hashCode = hashCode * -1521134295 + FileSize.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(Thumb);
            return hashCode;
        }

        public static bool operator ==(Audio left, Audio right)
        {
            return EqualityComparer<Audio>.Default.Equals(left, right);
        }

        public static bool operator !=(Audio left, Audio right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}