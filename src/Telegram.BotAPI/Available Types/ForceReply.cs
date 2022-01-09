// Copyright (c) 2022 Quetzal Rivera.
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
        [JsonProperty(PropertyName = PropertyNames.ForceReply, DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ForceReplyTag => true;
        ///<summary>Optional. The placeholder to be shown in the input field when the reply is active; 1-64 characters.</summary>
        [JsonPropertyName(PropertyNames.InputFieldPlaceholder)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InputFieldPlaceholder { get; set; }
        ///<summary>Optional. Use this parameter if you want to force reply from specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.</summary>
        [JsonPropertyName(PropertyNames.Selective)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? Selective { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ForceReply);
        }

        public bool Equals(ForceReply other)
        {
            return other != null &&
                   InputFieldPlaceholder == other.InputFieldPlaceholder &&
                   Selective == other.Selective;
        }

        public override int GetHashCode()
        {
            int hashCode = -854258181;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(InputFieldPlaceholder);
            hashCode = hashCode * -1521134295 + Selective.GetHashCode();
            return hashCode;
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