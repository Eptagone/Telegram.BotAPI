// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Represents the scope of bot commands, covering a specific member of a group or supergroup chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotCommandScopeChatMember : BotCommandScope, IEquatable<BotCommandScopeChatMember>
    {
        /// <summary>Scope type, must be chat_member.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => BotCommandScopeType.ChatMember;
        /// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        /// <summary>Unique identifier of the target user.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long UserId { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as BotCommandScopeChatMember);
        }

        public bool Equals(BotCommandScopeChatMember other)
        {
            return other != null &&
                   EqualityComparer<object>.Default.Equals(ChatId, other.ChatId) &&
                   UserId == other.UserId;
        }

        public override int GetHashCode()
        {
            int hashCode = -329865067;
            hashCode = hashCode * -1521134295 + EqualityComparer<object>.Default.GetHashCode(ChatId);
            hashCode = hashCode * -1521134295 + UserId.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(BotCommandScopeChatMember left, BotCommandScopeChatMember right)
        {
            return EqualityComparer<BotCommandScopeChatMember>.Default.Equals(left, right);
        }

        public static bool operator !=(BotCommandScopeChatMember left, BotCommandScopeChatMember right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
