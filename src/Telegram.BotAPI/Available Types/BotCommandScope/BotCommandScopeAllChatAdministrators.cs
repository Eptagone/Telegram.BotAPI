// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Represents the scope of bot commands, covering all group and supergroup chat administrators.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class BotCommandScopeAllChatAdministrators : BotCommandScope
    {
        /// <summary>Scope type, must be all_chat_administrators.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => BotCommandScopeType.AllChatAdministrators;
    }
}
