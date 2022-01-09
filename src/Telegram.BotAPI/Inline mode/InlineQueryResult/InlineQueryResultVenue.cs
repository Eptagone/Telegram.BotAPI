// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a venue. By default, the venue will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the venue.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultVenue : InlineQueryResult, IVenue, IExternalThumbnail, IEquatable<InlineQueryResultVenue>
    {
        /// <summary>Type of the result, must be venue.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Venue;
        /// <summary>Latitude of the venue location in degrees.</summary>
        [JsonPropertyName(PropertyNames.Latitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        /// <summary>Longitude of the venue location in degrees.</summary>
        [JsonPropertyName(PropertyNames.Longitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Title of the venue.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonPropertyName(PropertyNames.Address)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue if known.</summary>
        [JsonPropertyName(PropertyNames.FoursquareId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareId { get; set; }
        ///<summary>Optional. Foursquare type of the venue, if known. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
        [JsonPropertyName(PropertyNames.FoursquareType)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareType { get; set; }
        ///<summary>Optional. Google Places identifier of the venue.</summary>
        [JsonPropertyName(PropertyNames.GooglePlaceId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GooglePlaceId { get; set; }
        ///<summary>Optional. Google Places type of the venue. (See <a href="https://developers.google.com/places/web-service/supported_types">supported types</a>.)</summary>
        [JsonPropertyName(PropertyNames.GooglePlaceType)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GooglePlaceType { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the venue.</summary>
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
        public uint? ThumbWidth { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName(PropertyNames.ThumbHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? ThumbHeight { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultVenue);
        }

        public bool Equals(InlineQueryResultVenue other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   Type == other.Type &&
                   Latitude == other.Latitude &&
                   Longitude == other.Longitude &&
                   Title == other.Title &&
                   Address == other.Address &&
                   FoursquareId == other.FoursquareId &&
                   FoursquareType == other.FoursquareType &&
                   GooglePlaceId == other.GooglePlaceId &&
                   GooglePlaceType == other.GooglePlaceType &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent) &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbWidth == other.ThumbWidth &&
                   ThumbHeight == other.ThumbHeight;
        }

        public override int GetHashCode()
        {
            int hashCode = -545969655;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + Latitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Longitude.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoursquareId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoursquareType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GooglePlaceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GooglePlaceType);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + ThumbWidth.GetHashCode();
            hashCode = hashCode * -1521134295 + ThumbHeight.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultVenue left, InlineQueryResultVenue right)
        {
            return EqualityComparer<InlineQueryResultVenue>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultVenue left, InlineQueryResultVenue right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
