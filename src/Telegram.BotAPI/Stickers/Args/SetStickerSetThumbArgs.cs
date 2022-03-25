// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>SetStickerSetThumb method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SetStickerSetThumbArgs
    {
        /// <summary>Sticker set name</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; set; }
        /// <summary>User identifier of the sticker set owner</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long UserId { get; set; }
        /// <summary>A PNG image with the thumbnail, must be up to 128 kilobytes in size and have width and height exactly 100px, or a TGS animation with the thumbnail up to 32 kilobytes in size; see https://core.telegram.org/animated_stickers#technical-requirements for animated sticker technical requirements. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data. <a href="https://core.telegram.org/bots/api#sending-files">More info on Sending Files »</a>. Animated sticker set thumbnail can't be uploaded via HTTP URL.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Thumb { get; set; }
        internal bool UseMultipart()
        {
            if (Thumb != default)
            {
                if (Thumb.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
