// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a Game.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultGame : InlineQueryResult, IEquatable<InlineQueryResultGame>
    {
        /// <summary>Type of the result, must be game.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Game;
        /// <summary>Short name of the game.</summary>
        [JsonPropertyName(PropertyNames.GameShortName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GameShortName { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultGame);
        }

        public bool Equals(InlineQueryResultGame other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   Type == other.Type &&
                   GameShortName == other.GameShortName;
        }

        public override int GetHashCode()
        {
            int hashCode = -2029204352;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GameShortName);
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultGame left, InlineQueryResultGame right)
        {
            return EqualityComparer<InlineQueryResultGame>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultGame left, InlineQueryResultGame right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
