// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents an animation file (GIF or H.264/MPEG-4 AVC video without sound) to be sent.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputMediaAnimation : InputMedia, IThumbnail<string>, IEquatable<InputMediaAnimation>
    {
        ///<summary>Type of the result, must be animation.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InputMediaType.Animation;
        ///<summary>Optional. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Thumb { get; set; }
        ///<summary>Optional. Caption of the animation to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Caption { get; set; }
        ///<summary>Optional. Animation width.</summary>
        [JsonPropertyName(PropertyNames.Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Width { get; set; }
        ///<summary>Optional. Animation height.</summary>
        [JsonPropertyName(PropertyNames.Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Height { get; set; }
        ///<summary>Optional. Animation duration.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputMediaAnimation);
        }

        public bool Equals(InputMediaAnimation other)
        {
            return other != null &&
                   Media == other.Media &&
                   EqualityComparer<IEnumerable<MessageEntity>>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Thumb == other.Thumb &&
                   Caption == other.Caption &&
                   ParseMode == other.ParseMode &&
                   Width == other.Width &&
                   Height == other.Height &&
                   Duration == other.Duration;
        }

        public override int GetHashCode()
        {
            int hashCode = -2075930081;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Media);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Thumb);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            hashCode = hashCode * -1521134295 + Duration.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InputMediaAnimation left, InputMediaAnimation right)
        {
            return EqualityComparer<InputMediaAnimation>.Default.Equals(left, right);
        }

        public static bool operator !=(InputMediaAnimation left, InputMediaAnimation right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
