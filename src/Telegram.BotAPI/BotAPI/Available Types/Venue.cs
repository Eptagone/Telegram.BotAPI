// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents a venue.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Venue : IVenue, IEquatable<Venue>
    {
        ///<summary>Venue location.</summary>
        [JsonPropertyName(PropertyNames.Location)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Location Location { get; set; }
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
            return Equals(obj as Venue);
        }

        public bool Equals(Venue other)
        {
            return other != null &&
                   EqualityComparer<Location>.Default.Equals(Location, other.Location) &&
                   Title == other.Title &&
                   Address == other.Address &&
                   FoursquareId == other.FoursquareId &&
                   FoursquareType == other.FoursquareType &&
                   GooglePlaceId == other.GooglePlaceId &&
                   GooglePlaceType == other.GooglePlaceType;
        }

        public override int GetHashCode()
        {
            int hashCode = -328902192;
            hashCode = hashCode * -1521134295 + EqualityComparer<Location>.Default.GetHashCode(Location);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Address);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoursquareId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FoursquareType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GooglePlaceId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GooglePlaceType);
            return hashCode;
        }

        public static bool operator ==(Venue left, Venue right)
        {
            return EqualityComparer<Venue>.Default.Equals(left, right);
        }

        public static bool operator !=(Venue left, Venue right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
