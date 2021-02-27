// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.Games
{
    /// <summary>SendGame method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendGameArgs
    {
        /// <summary>Unique identifier for the target chat.</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long ChatId { get; set; }
        /// <summary>Short name of the game, serves as the unique identifier for the game. Set up your games via BotFather.</summary>
        [JsonPropertyName(PropertyNames.GameShortName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GameShortName { get; set; }
        /// <summary>Optional. Sends the message silently. Users will receive a notification with no sound.</summary>
        [JsonPropertyName(PropertyNames.DisableNotification)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableNotification { get; set; }
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonPropertyName(PropertyNames.ReplyToMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int ReplyToMessageId { get; set; }
        /// <summary>Optional. A JSON-serialized object for an inline keyboard. If empty, one ‘Play game_title’ button will be shown. If not empty, the first button must launch the game.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public AvailableTypes.InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}
