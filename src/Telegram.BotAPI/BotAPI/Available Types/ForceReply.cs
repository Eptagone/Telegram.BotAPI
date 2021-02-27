// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>Upon receiving a message with this object, Telegram clients will display a reply interface to the user (act as if the user has selected the bot‘s message and tapped ’Reply'). This can be extremely useful if you want to create user-friendly step-by-step interfaces without having to sacrifice privacy mode.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ForceReply : ReplyMarkup, IEquatable<ForceReply>
    {
        ///<summary>Shows reply interface to the user, as if they manually selected the bot‘s message and tapped ’Reply'.</summary>
        [JsonPropertyName(PropertyNames.ForceReply)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public static bool ForceReplyTag => true;
        ///<summary>Optional. Use this parameter if you want to force reply from specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.</summary>
        [JsonPropertyName(PropertyNames.Selective)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Selective { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ForceReply);
        }

        public bool Equals(ForceReply other)
        {
            return other != null &&
                   Selective == other.Selective;
        }

        public override int GetHashCode()
        {
            return 1578763193 + Selective.GetHashCode();
        }

        public static bool operator ==(ForceReply left, ForceReply right)
        {
            return EqualityComparer<ForceReply>.Default.Equals(left, right);
        }

        public static bool operator !=(ForceReply left, ForceReply right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}