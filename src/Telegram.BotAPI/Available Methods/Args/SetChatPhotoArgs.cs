// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SetChatPhoto method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SetChatPhotoArgs
    {
        /// <summary>Unique identifier for the target chat or username of the target supergroup (in the format @supergroupusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        /// <summary>New chat photo, uploaded using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Photo)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile Photo { get; set; }
    }
}
