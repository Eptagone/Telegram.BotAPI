// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.GettingUpdates
{
    /// <summary>GetUpdate method arguments</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GetUpdatesArgs
    {
        ///<summary>Identifier of the first update to be returned. Must be greater by one than the highest among the identifiers of previously received updates. By default, updates starting with the earliest unconfirmed update are returned.</summary>
        [JsonPropertyName(PropertyNames.Offset)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Offset { get; set; }
        ///<summary>Limits the number of updates to be retrieved. Values between 1—100 are accepted. Defaults to 100.</summary>
        [JsonPropertyName(PropertyNames.Limit)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ushort Limit { get; set; }
        ///<summary>Timeout in seconds for long polling. Defaults to 0, i.e. usual short polling. Should be positive, short polling should be used for testing purposes only.</summary>
        [JsonPropertyName(PropertyNames.Timeout)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Timeout { get; set; }
        ///<summary>List the types of updates you want your bot to receive. For example, specify [“message”, “edited_channel_post”, “callback_query”] to only receive updates of these types. See Update for a complete list of available update types. Specify an empty list to receive all updates regardless of type (default). If not specified, the previous setting will be used.<para>Please note that this parameter doesn't affect updates created before the call to the getUpdates, so unwanted updates may be received for a short period of time.</para></summary>
        [JsonPropertyName(PropertyNames.AllowedUpdates)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<string> AllowedUpdates { get; set; }
    }
}
