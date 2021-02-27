// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents the content of a media message to be sent. It should be one of: <br /><br />
    /// • <see cref="InputMediaAnimation"/><br />
    /// • <see cref="InputMediaDocument"/><br />
    /// • <see cref="InputMediaAudio"/><br />
    /// • <see cref="InputMediaPhoto"/><br />
    /// • <see cref="InputMediaVideo"/></summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public abstract class InputMedia
    {
        ///<summary>File to send. Pass a file_id to send a file that exists on the Telegram servers (recommended), pass an HTTP URL for Telegram to get a file from the Internet, or pass “attach://&lt;file_attach_name&gt;” to upload a new one using multipart/form-data under &lt;file_attach_name&gt; name.</summary>
        [JsonPropertyName(PropertyNames.Media)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Media { get; set; }
        /// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName(PropertyNames.CaptionEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MessageEntity[] CaptionEntities { get; set; }
    }
}
