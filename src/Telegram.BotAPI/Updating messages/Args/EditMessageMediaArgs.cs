// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.UpdatingMessages
{
    /// <summary>EditMessageMedia method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class EditMessageMediaArgs : IAttachFiles
    {
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName(PropertyNames.ChatId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object ChatId { get; set; }
        ///<summary>Required if inline_message_id is not specified. Unique identifier for the target chat or username of the target channel (in the format @channelusername).</summary>
        [JsonPropertyName(PropertyNames.MessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int MessageId { get; set; }
        ///<summary>Required if chat_id and message_id are not specified. Identifier of the inline message.</summary>
        [JsonPropertyName(PropertyNames.InlineMessageId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string InlineMessageId { get; set; }
        ///<summary>A <see cref="InputMedia"/> object for a new media content of the message.</summary>
        [JsonPropertyName(PropertyNames.Media)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMedia Media { get; set; }
        ///<summary>A <see cref="InlineKeyboardMarkup"/> object for a new inline keyboard.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup ReplyMarkup { get; set; }

        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

        bool IMultipartForm.UseMultipart()
        {
            return AttachedFiles.Any();
        }
    }
}
