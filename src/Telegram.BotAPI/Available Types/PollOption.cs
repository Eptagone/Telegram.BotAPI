// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object contains information about one answer option in a poll.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class PollOption : IEquatable<PollOption>
    {
        /// <summary>Option text, 1-100 characters.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>Number of users that voted for this option.</summary>
        [JsonPropertyName(PropertyNames.VoterCount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint VoterCount { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PollOption);
        }

        public bool Equals(PollOption other)
        {
            return other != null &&
                   Text == other.Text &&
                   VoterCount == other.VoterCount;
        }

        public override int GetHashCode()
        {
            int hashCode = -274894174;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + VoterCount.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(PollOption left, PollOption right)
        {
            return EqualityComparer<PollOption>.Default.Equals(left, right);
        }

        public static bool operator !=(PollOption left, PollOption right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
