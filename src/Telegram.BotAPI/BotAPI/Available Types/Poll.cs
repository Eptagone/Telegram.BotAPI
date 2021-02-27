// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object contains information about a poll.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Poll : IEquatable<Poll>
    {
        /// <summary>Unique poll identifier.</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Id { get; set; }
        /// <summary>Poll question, 1-255 characters.</summary>
        [JsonPropertyName(PropertyNames.Question)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Question { get; set; }
        /// <summary>List of poll options.</summary>
        [JsonPropertyName(PropertyNames.Options)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<PollOption> Options { get; set; }
        /// <summary>Total number of users that voted in the poll.</summary>
        [JsonPropertyName(PropertyNames.TotalVoterCount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint TotalVoterCount { get; set; }
        /// <summary>True, if the poll is closed.</summary>
        [JsonPropertyName(PropertyNames.IsClosed)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsClosed { get; set; }
        /// <summary>True, if the poll is anonymous.</summary>
        [JsonPropertyName(PropertyNames.IsAnonymous)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnonymous { get; set; }
        /// <summary>Poll type, currently can be “regular” or “quiz”.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        /// <summary>True, if the poll allows multiple answers.</summary>
        [JsonPropertyName(PropertyNames.AllowsMultipleAnswers)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool AllowsMultipleAnswers { get; set; }
        /// <summary>Optional. 0-based identifier of the correct answer option. Available only for polls in the quiz mode, which are closed, or was sent (not forwarded) by the bot or to the private chat with the bot.</summary>
        [JsonPropertyName(PropertyNames.CorrectOptionId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint CorrectOptionId { get; set; }

        ///<summary>Optional. Text that is shown when a user chooses an incorrect answer or taps on the lamp icon in a quiz-style poll, 0-200 characters.</summary>
        [JsonPropertyName(PropertyNames.Explanation)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Explanation { get; set; }
        ///<summary>Optional. Special entities like usernames, URLs, bot commands, etc. that appear in the explanation.</summary>
        [JsonPropertyName(PropertyNames.ExplanationEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> ExplanationEntities { get; set; }
        ///<summary>Optional. Amount of time in seconds the poll will be active after creation.</summary>
        [JsonPropertyName(PropertyNames.OpenPeriod)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort OpenPeriod { get; set; }
        ///<summary>Optional. Point in time (Unix timestamp) when the poll will be automatically closed.</summary>
        [JsonPropertyName(PropertyNames.CloseDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint CloseDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Poll);
        }

        public bool Equals(Poll other)
        {
            return other != null &&
                   Id == other.Id &&
                   Question == other.Question &&
                   EqualityComparer<IEnumerable<PollOption>>.Default.Equals(Options, other.Options) &&
                   TotalVoterCount == other.TotalVoterCount &&
                   IsClosed == other.IsClosed &&
                   IsAnonymous == other.IsAnonymous &&
                   Type == other.Type &&
                   AllowsMultipleAnswers == other.AllowsMultipleAnswers &&
                   CorrectOptionId == other.CorrectOptionId &&
                   Explanation == other.Explanation &&
                   EqualityComparer<IEnumerable<MessageEntity>>.Default.Equals(ExplanationEntities, other.ExplanationEntities) &&
                   OpenPeriod == other.OpenPeriod &&
                   CloseDate == other.CloseDate;
        }

        public override int GetHashCode()
        {
            int hashCode = -1529620533;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Question);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<PollOption>>.Default.GetHashCode(Options);
            hashCode = hashCode * -1521134295 + TotalVoterCount.GetHashCode();
            hashCode = hashCode * -1521134295 + IsClosed.GetHashCode();
            hashCode = hashCode * -1521134295 + IsAnonymous.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + AllowsMultipleAnswers.GetHashCode();
            hashCode = hashCode * -1521134295 + CorrectOptionId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Explanation);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>>.Default.GetHashCode(ExplanationEntities);
            hashCode = hashCode * -1521134295 + OpenPeriod.GetHashCode();
            hashCode = hashCode * -1521134295 + CloseDate.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Poll left, Poll right)
        {
            return EqualityComparer<Poll>.Default.Equals(left, right);
        }

        public static bool operator !=(Poll left, Poll right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
