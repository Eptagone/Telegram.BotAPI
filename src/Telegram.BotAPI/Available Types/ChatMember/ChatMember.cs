// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.Converters;

using JsonConverter = System.Text.Json.Serialization.JsonConverterAttribute;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object contains information about one member of a chat. Currently, the following 6 types of chat members are supported: <br /><br />
    /// • <see cref="ChatMemberOwner"/><br />
    /// • <see cref="ChatMemberAdministrator"/><br />
    /// • <see cref="ChatMemberMember"/><br />
    /// • <see cref="ChatMemberRestricted"/><br />
    /// • <see cref="ChatMemberLeft"/><br />
    /// • <see cref="ChatMemberBanned"/><br />
    /// </summary>
    [JsonConverter(typeof(ChatMemberConverter))]
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class ChatMember
    {
        /// <summary>The member's status in the chat.</summary>
        [JsonPropertyName(PropertyNames.Status)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public abstract string Status { get; }
        ///<summary>Information about the user.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
    }
}
