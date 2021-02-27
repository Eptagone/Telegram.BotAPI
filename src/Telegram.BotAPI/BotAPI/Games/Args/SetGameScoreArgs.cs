// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>SetGameScore method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SetGameScoreArgs
    {
        /// <summary>User identifier.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint UserId { get; set; }
        /// <summary>New score.</summary>
        [JsonPropertyName(PropertyNames.Score)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Score { get; set; }
        /// <summary>Optional. Pass True, if the high score is allowed to decrease. This can be useful when fixing mistakes or banning cheaters.</summary>
        [JsonPropertyName(PropertyNames.Force)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Force { get; set; }
        /// <summary>Optional. Pass True, if the game message should not be automatically edited to include the current scoreboard.</summary>
        [JsonPropertyName(PropertyNames.DisableEditMessage)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableEditMessage { get; set; }
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
        public uint InlineMessageId { get; set; }
    }
}
