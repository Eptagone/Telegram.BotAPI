// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a photo to be sent.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputMediaPhoto : InputMedia, IEquatable<InputMediaPhoto>
    {
        ///<summary>Type of the result, must be photo.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InputMediaType.Photo;
        ///<summary>Optional. Caption of the photo to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Caption { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputMediaPhoto);
        }

        public bool Equals(InputMediaPhoto other)
        {
            return other != null &&
                   Media == other.Media &&
                   EqualityComparer<IEnumerable<MessageEntity>>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Caption == other.Caption &&
                   ParseMode == other.ParseMode;
        }

        public override int GetHashCode()
        {
            int hashCode = -1830701226;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Media);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            return hashCode;
        }

        public static bool operator ==(InputMediaPhoto left, InputMediaPhoto right)
        {
            return EqualityComparer<InputMediaPhoto>.Default.Equals(left, right);
        }

        public static bool operator !=(InputMediaPhoto left, InputMediaPhoto right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
