// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a unique message identifier.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class MessageID : IEquatable<MessageID>
    {
        /// <summary>Unique message identifier.</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MessageId { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as MessageID);
        }

        public bool Equals(MessageID other)
        {
            return other != null &&
                   MessageId == other.MessageId;
        }

        public override int GetHashCode()
        {
            return 212258449 + MessageId.GetHashCode();
        }

        public static bool operator ==(MessageID left, MessageID right)
        {
            return EqualityComparer<MessageID>.Default.Equals(left, right);
        }

        public static bool operator !=(MessageID left, MessageID right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
