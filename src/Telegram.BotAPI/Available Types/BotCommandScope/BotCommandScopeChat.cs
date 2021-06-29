// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Represents the scope of bot commands, covering a specific chat.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotCommandScopeChat : BotCommandScope, IEquatable<BotCommandScopeChat>
    {
        /// <summary>Scope type, must be chat.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => BotCommandScopeType.Chat;
        /// <summary><see cref="long"/> or <see cref="string"/>. Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as BotCommandScopeChat);
        }

        public bool Equals(BotCommandScopeChat other)
        {
            return other != null &&
                   EqualityComparer<object>.Default.Equals(ChatId, other.ChatId);
        }

        public override int GetHashCode()
        {
            return -1413881002 + EqualityComparer<object>.Default.GetHashCode(ChatId);
        }

        public static bool operator ==(BotCommandScopeChat left, BotCommandScopeChat right)
        {
            return EqualityComparer<BotCommandScopeChat>.Default.Equals(left, right);
        }

        public static bool operator !=(BotCommandScopeChat left, BotCommandScopeChat right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
