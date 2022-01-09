// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Represents the bot's response to the request.</summary>
    /// <typeparam name="T">Result type.</typeparam>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotResponse<T> : IEquatable<BotResponse<T>>
    {
        /// <summary>True, if the request was successful, otherwise false.</summary>
        [JsonPropertyName("ok")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Ok { get; set; }
        /// <summary>Result.</summary>
        [JsonPropertyName("result")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public T Result { get; set; }
        ///<summary>Error code.</summary>
        [JsonPropertyName("error_code")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ErrorCode { get; set; }
        ///<summary>Error description.</summary>
        [JsonPropertyName("description")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        ///<summary>Parameters.</summary>
        [JsonPropertyName("parameters")]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ResponseParameters Parameters { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as BotResponse<T>);
        }

        public bool Equals(BotResponse<T> other)
        {
            return other != null &&
                   Ok == other.Ok &&
                   EqualityComparer<T>.Default.Equals(Result, other.Result) &&
                   ErrorCode == other.ErrorCode &&
                   Description == other.Description &&
                   EqualityComparer<ResponseParameters>.Default.Equals(Parameters, other.Parameters);
        }

        public override int GetHashCode()
        {
            int hashCode = 493339093;
            hashCode = hashCode * -1521134295 + Ok.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<T>.Default.GetHashCode(Result);
            hashCode = hashCode * -1521134295 + ErrorCode.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<ResponseParameters>.Default.GetHashCode(Parameters);
            return hashCode;
        }

        public static bool operator ==(BotResponse<T> left, BotResponse<T> right)
        {
            return EqualityComparer<BotResponse<T>>.Default.Equals(left, right);
        }

        public static bool operator !=(BotResponse<T> left, BotResponse<T> right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
