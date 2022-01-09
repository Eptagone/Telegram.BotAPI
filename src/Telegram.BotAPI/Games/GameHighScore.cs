// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Games
{
    /// <summary>This object represents one row of the high scores table for a game.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class GameHighScore : IEquatable<GameHighScore>
    {
        /// <summary>Position in high score table for the game</summary>
        [JsonPropertyName(PropertyNames.Position)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Position { get; set; }
        /// <summary>User</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        /// <summary>Score</summary>
        [JsonPropertyName(PropertyNames.Score)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Score { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as GameHighScore);
        }

        public bool Equals(GameHighScore other)
        {
            return other != null &&
                   Position == other.Position &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   Score == other.Score;
        }

        public override int GetHashCode()
        {
            int hashCode = 1602484449;
            hashCode = hashCode * -1521134295 + Position.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + Score.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(GameHighScore left, GameHighScore right)
        {
            return EqualityComparer<GameHighScore>.Default.Equals(left, right);
        }

        public static bool operator !=(GameHighScore left, GameHighScore right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
