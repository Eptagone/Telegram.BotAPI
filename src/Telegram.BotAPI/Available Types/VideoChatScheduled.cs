// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a service message about a video chat scheduled in the chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class VideoChatScheduled : IEquatable<VideoChatScheduled>
    {
        ///<summary>Point in time (Unix timestamp) when the voice chat is supposed to be started by a chat administrator.</summary>
        [JsonPropertyName(PropertyNames.StartDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint StartDate { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as VideoChatScheduled);
        }

        public bool Equals(VideoChatScheduled other)
        {
            return other != null &&
                   StartDate == other.StartDate;
        }

        public override int GetHashCode()
        {
            return 1472038579 + StartDate.GetHashCode();
        }

        public static bool operator ==(VideoChatScheduled left, VideoChatScheduled right)
        {
            return EqualityComparer<VideoChatScheduled>.Default.Equals(left, right);
        }

        public static bool operator !=(VideoChatScheduled left, VideoChatScheduled right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
