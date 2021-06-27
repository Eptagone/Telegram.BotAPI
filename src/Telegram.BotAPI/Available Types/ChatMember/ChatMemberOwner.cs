// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Represents a chat member that owns the chat and has all administrator privileges.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ChatMemberOwner : IChatMember, IEquatable<ChatMemberOwner>
    {
        ///<summary>The member's status in the chat, always “creator”.</summary>
        [JsonPropertyName(PropertyNames.Status)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Status => ChatMemberStatus.Creator;
        ///<summary>Information about the user.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        ///<summary>Custom title for this user.</summary>
        [JsonPropertyName(PropertyNames.CustomTitle)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string CustomTitle { get; set; }
        ///<summary>True, if the user's presence in the chat is hidden.</summary>
        [JsonPropertyName(PropertyNames.IsAnonymous)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsAnonymous { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ChatMemberOwner);
        }

        public bool Equals(ChatMemberOwner other)
        {
            return other != null &&
                   Status == other.Status &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   CustomTitle == other.CustomTitle &&
                   IsAnonymous == other.IsAnonymous;
        }

        public override int GetHashCode()
        {
            int hashCode = -947591761;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Status);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomTitle);
            hashCode = hashCode * -1521134295 + IsAnonymous.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ChatMemberOwner left, ChatMemberOwner right)
        {
            return EqualityComparer<ChatMemberOwner>.Default.Equals(left, right);
        }

        public static bool operator !=(ChatMemberOwner left, ChatMemberOwner right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
