// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents an invite link for a chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatInviteLink : IEquatable<ChatInviteLink>
    {
        ///<summary>The invite link. If the link was created by another chat administrator, then the second part of the link will be replaced with “…”.</summary>
        [JsonPropertyName(PropertyNames.InviteLink)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InviteLink { get; set; }
        ///<summary>Creator of the link.</summary>
        [JsonPropertyName(PropertyNames.Creator)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User Creator { get; set; }
        ///<summary>True, if users joining the chat via the link need to be approved by chat administrators.</summary>
        [JsonPropertyName(PropertyNames.CreatesJoinRequest)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool CreatesJoinRequest { get; set; }
        ///<summary>True, if the link is primary.</summary>
        [JsonPropertyName(PropertyNames.IsPrimary)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsPrimary { get; set; }
        ///<summary>True, if the link is revoked.</summary>
        [JsonPropertyName(PropertyNames.IsRevoked)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsRevoked { get; set; }
        ///<summary>Optional. Invite link name.</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        ///<summary>Optional. Point in time (Unix timestamp) when the link will expire or has been expired.</summary>
        [JsonPropertyName(PropertyNames.ExpireDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ExpireDate { get; set; }
        ///<summary>Optional. Maximum number of users that can be members of the chat simultaneously after joining the chat via this invite link; 1-99999.</summary>
        [JsonPropertyName(PropertyNames.MemberLimit)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint MemberLimit { get; set; }
        ///<summary>Optional. Number of pending join requests created using this link.</summary>
        [JsonPropertyName(PropertyNames.PendingJoinRequestCount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint PendingJoinRequestCount { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ChatInviteLink);
        }

        public bool Equals(ChatInviteLink other)
        {
            return other != null &&
                   InviteLink == other.InviteLink &&
                   EqualityComparer<User>.Default.Equals(Creator, other.Creator) &&
                   CreatesJoinRequest == other.CreatesJoinRequest &&
                   IsPrimary == other.IsPrimary &&
                   IsRevoked == other.IsRevoked &&
                   Name == other.Name &&
                   ExpireDate == other.ExpireDate &&
                   MemberLimit == other.MemberLimit &&
                   PendingJoinRequestCount == other.PendingJoinRequestCount;
        }

        public override int GetHashCode()
        {
            int hashCode = 2030292606;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InviteLink);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(Creator);
            hashCode = hashCode * -1521134295 + CreatesJoinRequest.GetHashCode();
            hashCode = hashCode * -1521134295 + IsPrimary.GetHashCode();
            hashCode = hashCode * -1521134295 + IsRevoked.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + ExpireDate.GetHashCode();
            hashCode = hashCode * -1521134295 + MemberLimit.GetHashCode();
            hashCode = hashCode * -1521134295 + PendingJoinRequestCount.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ChatInviteLink left, ChatInviteLink right)
        {
            return EqualityComparer<ChatInviteLink>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatInviteLink left, ChatInviteLink right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
