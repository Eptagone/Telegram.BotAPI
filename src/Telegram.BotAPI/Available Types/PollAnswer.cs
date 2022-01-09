// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents an answer of a user in a non-anonymous poll.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptOut, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class PollAnswer : IEquatable<PollAnswer>
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonPropertyName(PropertyNames.PollId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PollId { get; set; }
        /// <summary>The user, who changed the answer to the poll.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        /// <summary>0-based identifiers of answer options, chosen by the user. May be empty if the user retracted their vote.</summary>
        [JsonPropertyName(PropertyNames.OptionIds)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<uint> OptionIds { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as PollAnswer);
        }

        public bool Equals(PollAnswer other)
        {
            return other != null &&
                   PollId == other.PollId &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   EqualityComparer<IEnumerable<uint>>.Default.Equals(OptionIds, other.OptionIds);
        }

        public override int GetHashCode()
        {
            int hashCode = 603583861;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PollId);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<uint>>.Default.GetHashCode(OptionIds);
            return hashCode;
        }

        public static bool operator ==(PollAnswer left, PollAnswer right)
        {
            return EqualityComparer<PollAnswer>.Default.Equals(left, right);
        }

        public static bool operator !=(PollAnswer left, PollAnswer right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
