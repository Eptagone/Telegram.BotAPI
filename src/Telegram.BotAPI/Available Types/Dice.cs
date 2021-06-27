// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents an animated emoji that displays a random value.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class Dice : IEquatable<Dice>
    {
        /// <summary>Emoji on which the dice throw animation is based.</summary>
        [JsonPropertyName(PropertyNames.Emoji)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emoji { get; set; }
        /// <summary>Value of the dice, 1-6 for “🎲”, “🎯” and “🎳” base emoji, 1-5 for “🏀” and “⚽” base emoji, 1-64 for “🎰” base emoji.</summary>
        [JsonPropertyName(PropertyNames.Value)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Value { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as Dice);
        }

        public bool Equals(Dice other)
        {
            return other != null &&
                   Emoji == other.Emoji &&
                   Value == other.Value;
        }

        public override int GetHashCode()
        {
            int hashCode = 1365940687;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Emoji);
            hashCode = hashCode * -1521134295 + Value.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(Dice left, Dice right)
        {
            return EqualityComparer<Dice>.Default.Equals(left, right);
        }

        public static bool operator !=(Dice left, Dice right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }

    /// <summary>Dice base emojis. Choose between different animations (dice, darts, basketball, football, bowling, slot machine) by specifying the emoji parameter in the method sendDice.</summary>
    public sealed class DiceValue
    {
        /// <summary>Dice: 🎲 1 - 6 </summary>
        public const string Dice = "🎲";
        /// <summary>Darts: 🎯 </summary>
        public const string Darts = "🎯";
        /// <summary>Basketball: 🏀 </summary>
        public const string Basketball = "🏀";
        /// <summary>Football: 🏀 </summary>
        public const string Football = "⚽";
        /// <summary>Bowling: 🎳 </summary>
        public const string Bowling = "🎳";
        /// <summary>Slot machine: 🏀 </summary>
        public const string SlotMachine = "🎰";
    }
}
