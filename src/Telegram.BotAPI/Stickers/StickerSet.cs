// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>This object represents a sticker set.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class StickerSet : IEquatable<StickerSet>
    {
        ///<summary>Sticker set name.</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        ///<summary>Sticker set title.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>True, if the sticker is animated.</summary>
        [JsonPropertyName(PropertyNames.IsAnimated)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnimated { get; set; }
        ///<summary>True, if the sticker set contains masks.</summary>
        [JsonPropertyName(PropertyNames.ContainsMasks)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ContainsMasks { get; set; }
        ///<summary>List of all set stickers.</summary>
        [JsonPropertyName(PropertyNames.Stickers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<Sticker> Stickers { get; set; }
        ///<summary>Optional. Sticker set thumbnail in the .WEBP or .TGS format.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public PhotoSize Thumb { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as StickerSet);
        }

        public bool Equals(StickerSet other)
        {
            return other != null &&
                   Name == other.Name &&
                   Title == other.Title &&
                   IsAnimated == other.IsAnimated &&
                   ContainsMasks == other.ContainsMasks &&
                   EqualityComparer<IEnumerable<Sticker>>.Default.Equals(Stickers, other.Stickers) &&
                   EqualityComparer<PhotoSize>.Default.Equals(Thumb, other.Thumb);
        }

        public override int GetHashCode()
        {
            int hashCode = 883736284;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + IsAnimated.GetHashCode();
            hashCode = hashCode * -1521134295 + ContainsMasks.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<Sticker>>.Default.GetHashCode(Stickers);
            hashCode = hashCode * -1521134295 + EqualityComparer<PhotoSize>.Default.GetHashCode(Thumb);
            return hashCode;
        }

        public static bool operator ==(StickerSet left, StickerSet right)
        {
            return EqualityComparer<StickerSet>.Default.Equals(left, right);
        }

        public static bool operator !=(StickerSet left, StickerSet right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
