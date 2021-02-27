// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>AnswerInlineQuery method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class AnswerInlineQueryArgs
    {
        ///<summary>Unique identifier for the answered query.</summary>
        [JsonPropertyName(PropertyNames.InlineQueryId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InlineQueryId { get; set; }
        ///<summary>A <see cref="IInlineQueryResult"/> array of results for the inline query.</summary>
        [JsonPropertyName(PropertyNames.Results)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<InlineQueryResult> Results { get; set; }
        ///<summary>The maximum amount of time in seconds that the result of the inline query may be cached on the server. Defaults to 300.</summary>
        [JsonPropertyName(PropertyNames.CacheTime)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int CacheTime { get; set; }
        ///<summary>Pass True, if results may be cached on the server side only for the user that sent the query. By default, results may be returned to any user who sends the same query.</summary>
        [JsonPropertyName(PropertyNames.IsPersonal)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool IsPersonal { get; set; }
        ///<summary>Pass the offset that a client should send in the next query with the same text to receive more results. Pass an empty string if there are no more results or if you don‘t support pagination. Offset length can’t exceed 64 bytes.</summary>
        [JsonPropertyName(PropertyNames.NextOffset)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string NextOffset { get; set; }
        ///<summary>If passed, clients will display a button with specified text that switches the user to a private chat with the bot and sends the bot a start message with the parameter switch_pm_parameter.</summary>
        [JsonPropertyName(PropertyNames.SwitchPmText)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SwitchPmText { get; set; }
        ///<summary>Deep-linking parameter for the /start message sent to the bot when user presses the switch button. 1-64 characters, only A-Z, a-z, 0-9, _ and - are allowed.</summary>
        [JsonPropertyName(PropertyNames.SwitchPmParameter)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string SwitchPmParameter { get; set; }
    }
}