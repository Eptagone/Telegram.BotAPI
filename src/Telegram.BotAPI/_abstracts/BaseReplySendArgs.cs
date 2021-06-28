// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI
{
    /// <summary>Base object for reply message-sending.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseReplySendArgs
    {
        /// <summary>Optional. If the message is a reply, ID of the original message.</summary>
        [JsonPropertyName(PropertyNames.ReplyToMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int? ReplyToMessageId { get; set; }
        /// <summary>Pass True, if the message should be sent even if the specified replied-to message is not found.</summary>
        [JsonPropertyName(PropertyNames.AllowSendingWithoutReply)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? AllowSendingWithoutReply { get; set; }
    }
}
