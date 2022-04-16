// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>AnswerWebAppQuery method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AnswerWebAppQueryArgs
    {
        /// <summary>
        /// Initialize a new instance of .<see cref="AnswerWebAppQueryArgs"/>
        /// </summary>
        /// <param name="webAppQueryId">Unique identifier for the query to be answered.</param>
        /// <param name="result">A <see cref="InlineQueryResult"/> object describing the message to be sent.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AnswerWebAppQueryArgs(string webAppQueryId, InlineQueryResult result)
        {
            WebAppQueryId = webAppQueryId ?? throw new ArgumentNullException(nameof(webAppQueryId));
            Result = result ?? throw new ArgumentNullException(nameof(result));
        }

        ///<summary>Unique identifier for the query to be answered.</summary>
        [JsonPropertyName(PropertyNames.WebAppQueryId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string WebAppQueryId { get; }
        ///<summary>A <see cref="InlineQueryResult"/> object describing the message to be sent.</summary>
        [JsonPropertyName(PropertyNames.Result)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineQueryResult Result { get; }
    }
}
