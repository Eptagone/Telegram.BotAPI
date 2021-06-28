// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a video to be sent.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputMediaVideo : InputMedia, IThumbnail<string>, IEquatable<InputMediaVideo>
    {
        ///<summary>Type of the result, must be video.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InputMediaType.Video;
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb { get; set; }
        ///<summary>Optional. Caption of the video to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Caption { get; set; }
        ///<summary>Optional. Video width.</summary>
        [JsonPropertyName(PropertyNames.Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName(PropertyNames.Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>Optional. Video duration.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }
        ///<summary>Optional. Pass True, if the uploaded video is suitable for streaming.</summary>
        [JsonPropertyName(PropertyNames.SupportsStreaming)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupportsStreaming { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputMediaVideo);
        }

        public bool Equals(InputMediaVideo other)
        {
            return other != null &&
                   Media == other.Media &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Thumb == other.Thumb &&
                   Caption == other.Caption &&
                   ParseMode == other.ParseMode &&
                   Width == other.Width &&
                   Height == other.Height &&
                   Duration == other.Duration &&
                   SupportsStreaming == other.SupportsStreaming;
        }

        public override int GetHashCode()
        {
            int hashCode = 1150311166;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Media);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Thumb);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            hashCode = hashCode * -1521134295 + Duration.GetHashCode();
            hashCode = hashCode * -1521134295 + SupportsStreaming.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InputMediaVideo left, InputMediaVideo right)
        {
            return EqualityComparer<InputMediaVideo>.Default.Equals(left, right);
        }

        public static bool operator !=(InputMediaVideo left, InputMediaVideo right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
