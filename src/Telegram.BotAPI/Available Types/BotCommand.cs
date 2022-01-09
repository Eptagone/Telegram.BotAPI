// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents a bot command.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotCommand : IEquatable<BotCommand>
    {
        /// <summary>New Bot Command</summary>
        public BotCommand() { }
        /// <summary>New Bot Command</summary>
        /// <param name="command">Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</param>
        /// <param name="description">Description of the command, 3-256 characters.</param>
        public BotCommand(string command, string description)
        {
            Command = command;
            Description = description;
        }

        /// <summary>Text of the command, 1-32 characters. Can contain only lowercase English letters, digits and underscores.</summary>
        [JsonPropertyName(PropertyNames.Command)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Command { get; set; }
        /// <summary>Description of the command, 3-256 characters.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as BotCommand);
        }

        public bool Equals(BotCommand other)
        {
            return other != null &&
                   Command == other.Command &&
                   Description == other.Description;
        }

        public override int GetHashCode()
        {
            int hashCode = -56514517;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Command);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            return hashCode;
        }

        public static bool operator ==(BotCommand left, BotCommand right)
        {
            return EqualityComparer<BotCommand>.Default.Equals(left, right);
        }

        public static bool operator !=(BotCommand left, BotCommand right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
