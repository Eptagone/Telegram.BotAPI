// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a service message about new members invited to a video chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class VideoChatParticipantsInvited : IEquatable<VideoChatParticipantsInvited>
    {
        ///<summary>Optional. New members that were invited to the video chat.</summary>
        [JsonPropertyName(PropertyNames.Users)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User[] Users { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as VideoChatParticipantsInvited);
        }

        public bool Equals(VideoChatParticipantsInvited other)
        {
            return other != null &&
                   EqualityComparer<User[]>.Default.Equals(Users, other.Users);
        }

        public override int GetHashCode()
        {
            return 471895467 + EqualityComparer<User[]>.Default.GetHashCode(Users);
        }

        public static bool operator ==(VideoChatParticipantsInvited left, VideoChatParticipantsInvited right)
        {
            return EqualityComparer<VideoChatParticipantsInvited>.Default.Equals(left, right);
        }

        public static bool operator !=(VideoChatParticipantsInvited left, VideoChatParticipantsInvited right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
