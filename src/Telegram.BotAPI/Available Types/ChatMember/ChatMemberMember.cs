// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a chat member that has no additional privileges or restrictions.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMemberMember : ChatMember, IEquatable<ChatMemberMember>
    {
        ///<summary>The member's status in the chat, always “member”.</summary>
        [JsonPropertyName(PropertyNames.Status)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Status => ChatMemberStatus.Member;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ChatMemberMember);
        }

        public bool Equals(ChatMemberMember other)
        {
            return other != null &&
                   Status == other.Status &&
                   EqualityComparer<User>.Default.Equals(User, other.User);
        }

        public override int GetHashCode()
        {
            int hashCode = -2144010887;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            return hashCode;
        }

        public static bool operator ==(ChatMemberMember left, ChatMemberMember right)
        {
            return EqualityComparer<ChatMemberMember>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatMemberMember left, ChatMemberMember right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
