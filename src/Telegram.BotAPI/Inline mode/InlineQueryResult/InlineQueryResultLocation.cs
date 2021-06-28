// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a location on a map. By default, the location will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the location.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultLocation : InlineQueryResultWithEntities, ILocation, IExternalThumbnail, IEquatable<InlineQueryResultLocation>
    {
        /// <summary>Type of the result, must be location.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Location;
        ///<summary>Longitude as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Longitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Latitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        /// <summary>Title of the result.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
        [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float HorizontalAccuracy { get; set; }
        ///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
        [JsonPropertyName(PropertyNames.LivePeriod)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint LivePeriod { get; set; }
        ///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
        [JsonPropertyName(PropertyNames.Heading)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Heading { get; set; }
        ///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
        [JsonPropertyName(PropertyNames.ProximityAlertRadius)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ProximityAlertRadius { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the location.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
        [JsonPropertyName(PropertyNames.ThumbUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbUrl { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonPropertyName(PropertyNames.ThumbWidth)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ThumbWidth { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName(PropertyNames.ThumbHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ThumbHeight { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultLocation);
        }

        public bool Equals(InlineQueryResultLocation other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Longitude == other.Longitude &&
                   Latitude == other.Latitude &&
                   Title == other.Title &&
                   HorizontalAccuracy == other.HorizontalAccuracy &&
                   LivePeriod == other.LivePeriod &&
                   Heading == other.Heading &&
                   ProximityAlertRadius == other.ProximityAlertRadius &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent) &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbWidth == other.ThumbWidth &&
                   ThumbHeight == other.ThumbHeight;
        }

        public override int GetHashCode()
        {
            int hashCode = -1945719542;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + Longitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Latitude.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + HorizontalAccuracy.GetHashCode();
            hashCode = hashCode * -1521134295 + LivePeriod.GetHashCode();
            hashCode = hashCode * -1521134295 + Heading.GetHashCode();
            hashCode = hashCode * -1521134295 + ProximityAlertRadius.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + ThumbWidth.GetHashCode();
            hashCode = hashCode * -1521134295 + ThumbHeight.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultLocation left, InlineQueryResultLocation right)
        {
            return EqualityComparer<InlineQueryResultLocation>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultLocation left, InlineQueryResultLocation right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
