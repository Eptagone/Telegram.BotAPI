// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SendMediaGroud method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendMediaGroupArgs : BaseSendArgs, IAttachFiles
    {
        ///<summary>A JSON array of <see cref="InputMedia"/> and <see cref="InputMedia"/>, describing photos and videos to be sent, must include 2–10 items.</summary>
        [JsonPropertyName(PropertyNames.Media)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public List<InputMedia> Media { get; } = new List<InputMedia>();
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public List<AttachFile> AttachFiles { get; set; } = new List<AttachFile>();
        internal bool UseMultipart()
        {
            return AttachFiles.Any();
        }
    }
}