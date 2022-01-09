// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a join request sent to a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatJoinRequest : IEquatable<ChatJoinRequest>
    {
        ///<summary>Chat to which the request was sent.</summary>
        [JsonPropertyName(PropertyNames.Chat)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Chat Chat { get; set; }
        ///<summary>User that sent the join request.</summary>
        [JsonPropertyName(PropertyNames.From)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User From { get; set; }
        ///<summary>Date the request was sent in Unix time.</summary>
        [JsonPropertyName(PropertyNames.Date)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Date { get; set; }
        ///<summary>Optional. Bio of the user.</summary>
        [JsonPropertyName(PropertyNames.Bio)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Bio { get; set; }
        ///<summary>Optional. Chat invite link that was used by the user to send the join request.</summary>
        [JsonPropertyName(PropertyNames.InviteLink)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InviteLink { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ChatJoinRequest);
        }

        public bool Equals(ChatJoinRequest other)
        {
            return other != null &&
                   EqualityComparer<Chat>.Default.Equals(Chat, other.Chat) &&
                   EqualityComparer<User>.Default.Equals(From, other.From) &&
                   Date == other.Date &&
                   Bio == other.Bio &&
                   InviteLink == other.InviteLink;
        }

        public override int GetHashCode()
        {
            int hashCode = -1061456070;
            hashCode = hashCode * -1521134295 + EqualityComparer<Chat>.Default.GetHashCode(Chat);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(From);
            hashCode = hashCode * -1521134295 + Date.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Bio);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InviteLink);
            return hashCode;
        }

        public static bool operator ==(ChatJoinRequest left, ChatJoinRequest right)
        {
            return EqualityComparer<ChatJoinRequest>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatJoinRequest left, ChatJoinRequest right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
