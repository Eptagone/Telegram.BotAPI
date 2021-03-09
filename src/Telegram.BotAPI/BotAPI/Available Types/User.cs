// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a Telegram user or bot.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class User : IEquatable<User>
    {
        /// <summary>Unique identifier for this user or bot.</summary>
        [JsonPropertyName(PropertyNames.Id)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long Id { get; set; }
        /// <summary>True, if this user is a bot.</summary>
        [JsonPropertyName(PropertyNames.IsBot)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsBot { get; set; }
        /// <summary>User‘s or bot’s first name.</summary>
        [JsonPropertyName(PropertyNames.FirstName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }
        /// <summary>Optional. User‘s or bot’s last name.</summary>
        [JsonPropertyName(PropertyNames.LastName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }
        /// <summary>Optional. User‘s or bot’s username.</summary>
        [JsonPropertyName(PropertyNames.Username)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Username { get; set; }
        /// <summary>Optional. IETF language tag of the user's language.</summary>
        [JsonPropertyName(PropertyNames.LanguageCode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LanguageCode { get; set; }
        /// <summary>Optional. True, if the bot can be invited to groups. Returned only in getMe.</summary>
        [JsonPropertyName(PropertyNames.CanJoinGroups)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanJoinGroups { get; set; }
        /// <summary>Optional. True, if privacy mode is disabled for the bot. Returned only in getMe.</summary>
        [JsonPropertyName(PropertyNames.CanReadAllGroupMessages)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CanReadAllGroupMessages { get; set; }
        /// <summary>Optional. True, if the bot supports inline queries. Returned only in getMe.</summary>
        [JsonPropertyName(PropertyNames.SupportsInlineQueries)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool SupportsInlineQueries { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as User);
        }

        public bool Equals(User other)
        {
            return other != null &&
                   Id == other.Id &&
                   IsBot == other.IsBot &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Username == other.Username &&
                   LanguageCode == other.LanguageCode &&
                   CanJoinGroups == other.CanJoinGroups &&
                   CanReadAllGroupMessages == other.CanReadAllGroupMessages &&
                   SupportsInlineQueries == other.SupportsInlineQueries;
        }

        public override int GetHashCode()
        {
            int hashCode = 1040595173;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + IsBot.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Username);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LanguageCode);
            hashCode = hashCode * -1521134295 + CanJoinGroups.GetHashCode();
            hashCode = hashCode * -1521134295 + CanReadAllGroupMessages.GetHashCode();
            hashCode = hashCode * -1521134295 + SupportsInlineQueries.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(User left, User right)
        {
            return EqualityComparer<User>.Default.Equals(left, right);
        }

        public static bool operator !=(User left, User right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
