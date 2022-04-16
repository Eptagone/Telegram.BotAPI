// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Contains information about a Web App.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class WebAppInfo : IEquatable<WebAppInfo>
    {
        /// <summary>An HTTPS URL of a Web App to be opened with additional data as specified in Initializing Web Apps.</summary>
        [JsonPropertyName(PropertyNames.Url)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as WebAppInfo);
        }

        public bool Equals(WebAppInfo other)
        {
            return other != null &&
                   Url == other.Url;
        }

        public override int GetHashCode()
        {
            return -1915121810 + EqualityComparer<string>.Default.GetHashCode(Url);
        }

        public static bool operator ==(WebAppInfo left, WebAppInfo right)
        {
            return EqualityComparer<WebAppInfo>.Default.Equals(left, right);
        }

        public static bool operator !=(WebAppInfo left, WebAppInfo right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
