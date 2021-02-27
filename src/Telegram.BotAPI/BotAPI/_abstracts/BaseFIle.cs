// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI
{
    /// <summary>Base class for file objects.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class BaseFile : IFile
    {
        ///<summary>Identifier for this file, which can be used to download or reuse the file.</summary>
        [JsonPropertyName(PropertyNames.FileId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileId { get; set; }
        ///<summary>Unique identifier for this file, which is supposed to be the same over time and for different bots. Can't be used to download or reuse the file.</summary>
        [JsonPropertyName(PropertyNames.FileUniqueId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FileUniqueId { get; set; }
    }
}
