// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents type of a poll, which is allowed to be created and sent when the corresponding button is pressed.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class KeyboardButtonPollType : IEquatable<KeyboardButtonPollType>
    {
        /// <summary>Optional. If quiz is passed, the user will be allowed to create only polls in the quiz mode. If regular is passed, only regular polls will be allowed. Otherwise, the user will be allowed to create a poll of any type.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as KeyboardButtonPollType);
        }

        public bool Equals(KeyboardButtonPollType other)
        {
            return other != null &&
                   Type == other.Type;
        }

        public override int GetHashCode()
        {
            return 2049151605 + EqualityComparer<string>.Default.GetHashCode(Type);
        }

        public static bool operator ==(KeyboardButtonPollType left, KeyboardButtonPollType right)
        {
            return EqualityComparer<KeyboardButtonPollType>.Default.Equals(left, right);
        }

        public static bool operator !=(KeyboardButtonPollType left, KeyboardButtonPollType right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
