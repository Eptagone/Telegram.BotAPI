// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Stickers
{
    ///<summary>This object describes the position on faces where a mask should be placed by default.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class MaskPosition : IEquatable<MaskPosition>
    {
        ///<summary>The part of the face relative to which the mask should be placed. One of “forehead”, “eyes”, “mouth”, or “chin”.</summary>
        [JsonPropertyName(PropertyNames.Point)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Point { get; set; }
        ///<summary>Shift by X-axis measured in widths of the mask scaled to the face size, from left to right. For example, choosing -1.0 will place mask just to the left of the default mask position.</summary>
        [JsonPropertyName(PropertyNames.XShift)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float XShift { get; set; }
        ///<summary>Shift by Y-axis measured in heights of the mask scaled to the face size, from top to bottom. For example, 1.0 will place the mask just below the default mask position.</summary>
        [JsonPropertyName(PropertyNames.YShift)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float YShift { get; set; }
        ///<summary>Mask scaling coefficient. For example, 2.0 means double size.</summary>
        [JsonPropertyName(PropertyNames.Scale)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Scale { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as MaskPosition);
        }

        public bool Equals(MaskPosition other)
        {
            return other != null &&
                   Point == other.Point &&
                   XShift == other.XShift &&
                   YShift == other.YShift &&
                   Scale == other.Scale;
        }

        public override int GetHashCode()
        {
            int hashCode = 808330583;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Point);
            hashCode = hashCode * -1521134295 + XShift.GetHashCode();
            hashCode = hashCode * -1521134295 + YShift.GetHashCode();
            hashCode = hashCode * -1521134295 + Scale.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(MaskPosition left, MaskPosition right)
        {
            return EqualityComparer<MaskPosition>.Default.Equals(left, right);
        }

        public static bool operator !=(MaskPosition left, MaskPosition right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
