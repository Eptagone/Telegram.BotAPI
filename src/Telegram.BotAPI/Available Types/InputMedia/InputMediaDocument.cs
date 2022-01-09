// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Represents a general file to be sent.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputMediaDocument : InputMedia, IThumbnail<string>, IEquatable<InputMediaDocument>
    {
        ///<summary>Type of the result, must be document.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InputMediaType.Document;
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb { get; set; }
        ///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Caption { get; set; }
        ///<summary>Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</summary>
        [JsonPropertyName(PropertyNames.DisableContentTypeDetection)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableContentTypeDetection { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputMediaDocument);
        }

        public bool Equals(InputMediaDocument other)
        {
            return other != null &&
                   Media == other.Media &&
                   EqualityComparer<IEnumerable<MessageEntity>>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Thumb == other.Thumb &&
                   Caption == other.Caption &&
                   ParseMode == other.ParseMode &&
                   DisableContentTypeDetection == other.DisableContentTypeDetection;
        }

        public override int GetHashCode()
        {
            int hashCode = 363848984;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Media);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Thumb);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + DisableContentTypeDetection.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InputMediaDocument left, InputMediaDocument right)
        {
            return EqualityComparer<InputMediaDocument>.Default.Equals(left, right);
        }

        public static bool operator !=(InputMediaDocument left, InputMediaDocument right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
