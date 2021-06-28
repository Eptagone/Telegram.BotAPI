// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents a point on the map.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Location : ILocation, IEquatable<Location>
    {
        ///<summary>Longitude as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Longitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Longitude { get; set; }
        ///<summary>Latitude as defined by sender.</summary>
        [JsonPropertyName(PropertyNames.Latitude)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float Latitude { get; set; }
        ///<summary>Optional. The radius of uncertainty for the location, measured in meters; 0-1500.</summary>
        [JsonPropertyName(PropertyNames.HorizontalAccuracy)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public float? HorizontalAccuracy { get; set; }
        ///<summary>Optional. Time relative to the message sending date, during which the location can be updated, in seconds. For active live locations only.</summary>
        [JsonPropertyName(PropertyNames.LivePeriod)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? LivePeriod { get; set; }
        ///<summary>Optional. The direction in which user is moving, in degrees; 1-360. For active live locations only.</summary>
        [JsonPropertyName(PropertyNames.Heading)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort? Heading { get; set; }
        ///<summary>Optional. Maximum distance for proximity alerts about approaching another chat member, in meters. For sent live locations only.</summary>
        [JsonPropertyName(PropertyNames.ProximityAlertRadius)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? ProximityAlertRadius { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Location);
        }

        public bool Equals(Location other)
        {
            return other != null &&
                   Longitude == other.Longitude &&
                   Latitude == other.Latitude &&
                   HorizontalAccuracy == other.HorizontalAccuracy &&
                   LivePeriod == other.LivePeriod &&
                   Heading == other.Heading &&
                   ProximityAlertRadius == other.ProximityAlertRadius;
        }

        public override int GetHashCode()
        {
            int hashCode = 1466495924;
            hashCode = hashCode * -1521134295 + Longitude.GetHashCode();
            hashCode = hashCode * -1521134295 + Latitude.GetHashCode();
            hashCode = hashCode * -1521134295 + HorizontalAccuracy.GetHashCode();
            hashCode = hashCode * -1521134295 + LivePeriod.GetHashCode();
            hashCode = hashCode * -1521134295 + Heading.GetHashCode();
            hashCode = hashCode * -1521134295 + ProximityAlertRadius.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Location left, Location right)
        {
            return EqualityComparer<Location>.Default.Equals(left, right);
        }

        public static bool operator !=(Location left, Location right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
