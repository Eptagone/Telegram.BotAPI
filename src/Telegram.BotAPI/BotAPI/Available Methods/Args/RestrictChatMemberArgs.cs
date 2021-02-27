// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>RestrictChatMember method summaryeters.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class RestrictChatMemberArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        /// <summary>Unique identifier of the target user.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int UserId { get; set; }
        /// <summary>New user permissions.</summary>
        [JsonPropertyName(PropertyNames.Permissions)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ChatPermissions Permissions { get; set; }
        /// <summary>Optional. Date when restrictions will be lifted for the user, unix time. If user is restricted for more than 366 days or less than 30 seconds from the current time, they are considered to be restricted forever.</summary>
        [JsonPropertyName(PropertyNames.UntilDate)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint UntilDate { get; set; }
    }
}
