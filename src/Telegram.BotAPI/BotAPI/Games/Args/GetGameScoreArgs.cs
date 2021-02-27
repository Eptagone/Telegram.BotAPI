// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>GetGameScore method args.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class GetGameScoreArgs
    {
        /// <summary>Target user id.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int UserId { get; set; }
        /// <summary>Required if inline_message_id is not specified. Unique identifier for the target chat.</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long ChatId { get; set; }
        /// <summary>Required if inline_message_id is not specified. Identifier of the sent message.</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MessageId { get; set; }
        /// <summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName(PropertyNames.InlineMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InlineMessageId { get; set; }
    }
}
