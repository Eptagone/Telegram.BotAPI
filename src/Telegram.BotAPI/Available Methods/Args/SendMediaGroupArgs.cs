// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SendMediaGroud method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendMediaGroupArgs : SendMessageBase, IAttachFiles
    {
        /// <summary>
        /// Initialize a new instance of <see cref="SendMediaGroupArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
        public SendMediaGroupArgs(long chatId, IEnumerable<InputMedia> media) : base(chatId)
        {
            Media = new HashSet<InputMedia>(media ?? throw new ArgumentNullException(nameof(media)));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendMediaGroupArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="media">An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</param>
        public SendMediaGroupArgs(string chatId, IEnumerable<InputMedia> media) : base(chatId)
        {
            Media = new HashSet<InputMedia>(media ?? throw new ArgumentNullException(nameof(media)));
        }

        ///<summary>An array of <see cref="InputMediaAudio"/>, <see cref="InputMediaDocument"/>, <see cref="InputMediaPhoto"/> and <see cref="InputMediaVideo"/> describing messages to be sent, must include 2-10 items.</summary>
        [JsonPropertyName(PropertyNames.Media)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public ICollection<InputMedia> Media { get; }

        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

        bool IMultipartForm.UseMultipart()
        {
            return AttachedFiles.Any();
        }
    }
}
