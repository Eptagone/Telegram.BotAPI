// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a service message about a video chat ended in the chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class VideoChatEnded : IEquatable<VideoChatEnded>
    {
        ///<summary>Video chat duration in seconds.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Duration { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as VideoChatEnded);
        }

        public bool Equals(VideoChatEnded other)
        {
            return other != null &&
                   Duration == other.Duration;
        }

        public override int GetHashCode()
        {
            return -1943557835 + Duration.GetHashCode();
        }

        public static bool operator ==(VideoChatEnded left, VideoChatEnded right)
        {
            return EqualityComparer<VideoChatEnded>.Default.Equals(left, right);
        }

        public static bool operator !=(VideoChatEnded left, VideoChatEnded right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
