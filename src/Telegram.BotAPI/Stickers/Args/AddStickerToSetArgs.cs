// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>AddStickerToSet method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class AddStickerToSetArgs : IMultipartForm
    {
        /// <summary>
        /// Initialize a new instance of <see cref="AddStickerToSetArgs"/>.
        /// </summary>
        /// <param name="userId">User identifier of sticker set owner.</param>
        /// <param name="name">Sticker set name.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public AddStickerToSetArgs(long userId, string name, string emojis)
        {
            UserId = userId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Emojis = emojis ?? throw new ArgumentNullException(nameof(emojis));
        }

        /// <summary>User identifier of sticker set owner.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long UserId { get; }
        /// <summary>Sticker set name.</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; }
        /// <summary>Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.PngSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PngSticker { get; set; }
        /// <summary>TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</summary>
        [JsonPropertyName(PropertyNames.TgsSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile TgsSticker { get; set; }
        /// <summary>WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</summary>
        [JsonPropertyName(PropertyNames.WebmSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile WebmSticker { get; set; }
        /// <summary>One or more emoji corresponding to the sticker.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emojis { get; }
        /// <summary>Optional. A <see cref="MaskPosition"/> object for position where the mask should be placed on faces.</summary>
        [JsonPropertyName(PropertyNames.MaskPosition)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public MaskPosition MaskPosition { get; set; }

        bool IMultipartForm.UseMultipart()
        {
            if (PngSticker != null)
            {
                if (PngSticker.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }
            else if (TgsSticker != null)
            {
                return true;
            }
            else if (WebmSticker != null)
            {
                return true;
            }

            return false;
        }
    }
}
