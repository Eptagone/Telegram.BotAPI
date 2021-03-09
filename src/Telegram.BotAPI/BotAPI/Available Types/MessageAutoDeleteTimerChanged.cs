// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a service message about a change in auto-delete timer settings.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class MessageAutoDeleteTimerChanged : IEquatable<MessageAutoDeleteTimerChanged>
    {
        /// <summary>New auto-delete time for messages in the chat.</summary>
        [JsonPropertyName(PropertyNames.MessageAutoDeleteTime)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint MessageAutoDeleteTime { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as MessageAutoDeleteTimerChanged);
        }

        public bool Equals(MessageAutoDeleteTimerChanged other)
        {
            return other != null &&
                   MessageAutoDeleteTime == other.MessageAutoDeleteTime;
        }

        public override int GetHashCode()
        {
            return -523407135 + MessageAutoDeleteTime.GetHashCode();
        }

        public static bool operator ==(MessageAutoDeleteTimerChanged left, MessageAutoDeleteTimerChanged right)
        {
            return EqualityComparer<MessageAutoDeleteTimerChanged>.Default.Equals(left, right);
        }

        public static bool operator !=(MessageAutoDeleteTimerChanged left, MessageAutoDeleteTimerChanged right)
        {
            return !(left == right);
        }

#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
