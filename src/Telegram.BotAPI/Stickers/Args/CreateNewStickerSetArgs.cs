// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Stickers
{
    /// <summary>CreateNewStickerSet method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateNewStickerSetArgs : IMultipartForm
    {
        /// <summary>
        /// Initialize a new instance of <see cref="CreateNewStickerSetArgs"/>.
        /// </summary>
        /// <param name="userId">User identifier of created sticker set owner.</param>
        /// <param name="name">Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</param>
        /// <param name="title">Sticker set title, 1-64 characters.</param>
        /// <param name="emojis">One or more emoji corresponding to the sticker.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public CreateNewStickerSetArgs(long userId, string name, string title, string emojis)
        {
            UserId = userId;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Emojis = emojis ?? throw new ArgumentNullException(nameof(emojis));
        }

        /// <summary>User identifier of created sticker set owner.</summary>
        [JsonPropertyName(PropertyNames.UserId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public long UserId { get; }
        /// <summary>Short name of sticker set, to be used in t.me/addstickers/ URLs (e.g., animals). Can contain only english letters, digits and underscores. Must begin with a letter, can't contain consecutive underscores and must end in “_by_&lt;bot username&gt;”. &lt;bot_username&gt; is case insensitive. 1-64 characters.</summary>
        [JsonPropertyName(PropertyNames.Name)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Name { get; }
        /// <summary>Sticker set title, 1-64 characters.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; }
        /// <summary>Optional. Png image with the sticker, must be up to 512 kilobytes in size, dimensions must not exceed 512px, and either width or height must be exactly 512px. Pass a file_id as a String to send a file that already exists on the Telegram servers, pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.PngSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object PngSticker { get; set; }
        /// <summary>Optional. TGS animation with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/animated_stickers#technical-requirements for technical requirements.</summary>
        [JsonPropertyName(PropertyNames.TgsSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile TgsSticker { get; set; }
        /// <summary>Optional. WEBM video with the sticker, uploaded using multipart/form-data. See https://core.telegram.org/stickers#video-sticker-requirements for technical requirements.</summary>
        [JsonPropertyName(PropertyNames.WebmSticker)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputFile WebmSticker { get; set; }
        /// <summary>One or more emoji corresponding to the sticker.</summary>
        [JsonPropertyName(PropertyNames.Emojis)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Emojis { get; }
        /// <summary>Optional. Pass True, if a set of mask stickers should be created.</summary>
        [JsonPropertyName(PropertyNames.ContainsMasks)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? ContainsMasks { get; set; }
        /// <summary>Optional. A JSON object for position where the mask should be placed on faces.</summary>
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
