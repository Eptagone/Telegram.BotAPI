// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents the content of a venue message to be sent as the result of an inline query.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputVenueMessageContent : InputMessageContent, IVenue, IEquatable<InputVenueMessageContent>
    {
        ///<summary>Latitude of the venue in degrees.</summary>
        [JsonPropertyName(PropertyNames.Latitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        ///<summary>Longitude of the venue in degrees.</summary>
        [JsonPropertyName(PropertyNames.Longitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Name of the venue.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Address of the venue.</summary>
        [JsonPropertyName(PropertyNames.Address)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Address { get; set; }
        ///<summary>Optional. Foursquare identifier of the venue.</summary>
        [JsonPropertyName(PropertyNames.FoursquareId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FoursquareId { get; set; }
        ///<summary>Optional. Foursquare type of the venue. (For example, “arts_entertainment/default”, “arts_entertainment/aquarium” or “food/icecream”.)</summary>
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

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputVenueMessageContent);
        }

        public bool Equals(InputVenueMessageContent other)
        {
            return other != null &&
                   Latitude == other.Latitude &&
                   Longitude == other.Longitude &&
                   Title == other.Title &&
                   Address == other.Address &&
                   FoursquareId == other.FoursquareId &&
                   FoursquareType == other.FoursquareType &&
                   GooglePlaceId == other.GooglePlaceId &&
                   GooglePlaceType == other.GooglePlaceType;
        }

        public override int GetHashCode()
        {
            int hashCode = -297061995;
            hashCode = hashCode * -1521134295 + Latitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Longitude.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoursquareId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoursquareType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GooglePlaceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GooglePlaceType);
            return hashCode;
        }

        public static bool operator ==(InputVenueMessageContent left, InputVenueMessageContent right)
        {
            return EqualityComparer<InputVenueMessageContent>.Default.Equals(left, right);
        }

        public static bool operator !=(InputVenueMessageContent left, InputVenueMessageContent right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
