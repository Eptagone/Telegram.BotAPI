// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents the content of a service message, sent whenever a user in the chat triggers a proximity alert set by another user.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ProximityAlertTriggered : IEquatable<ProximityAlertTriggered>
    {
        ///<summary>User that triggered the alert.</summary>
        [JsonPropertyName(PropertyNames.Traveler)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Traveler { get; set; }
        ///<summary>User that set the alert.</summary>
        [JsonPropertyName(PropertyNames.Watcher)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Watcher { get; set; }
        ///<summary>The distance between the users.</summary>
        [JsonPropertyName(PropertyNames.Distance)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Distance { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ProximityAlertTriggered);
        }

        public bool Equals(ProximityAlertTriggered other)
        {
            return other != null &&
                   EqualityComparer<User>.Default.Equals(Traveler, other.Traveler) &&
                   EqualityComparer<User>.Default.Equals(Watcher, other.Watcher) &&
                   Distance == other.Distance;
        }

        public override int GetHashCode()
        {
            int hashCode = -665126421;
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(Traveler);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(Watcher);
            hashCode = hashCode * -1521134295 + Distance.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ProximityAlertTriggered left, ProximityAlertTriggered right)
        {
            return EqualityComparer<ProximityAlertTriggered>.Default.Equals(left, right);
        }

        public static bool operator !=(ProximityAlertTriggered left, ProximityAlertTriggered right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
