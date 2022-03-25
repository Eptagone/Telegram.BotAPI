// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SendAnimation method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendAnimationArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IAttachFiles, IMultipartForm, IThumbnail<object>
    {
        /// <summary>
        /// Initialize a new instance of <see cref="SendAnimationArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        public SendAnimationArgs(long chatId, InputFile animation) : base(chatId)
        {
            Animation = animation;
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendAnimationArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        public SendAnimationArgs(long chatId, string animation) : base(chatId)
        {
            Animation = animation;
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendAnimationArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        public SendAnimationArgs(string chatId, InputFile animation) : base(chatId)
        {
            Animation = animation;
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendAnimationArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="animation">Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</param>
        public SendAnimationArgs(string chatId, string animation) : base(chatId)
        {
            Animation = animation;
        }


        ///<summary>Animation to send. Pass a file_id as String to send an animation that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get an animation from the Internet, or upload a new animation using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Animation)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Animation { get; }
        ///<summary>Optional. Duration of sent animation in seconds.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? Duration { get; set; }
        ///<summary>Optional. Animation width.</summary>
        [JsonPropertyName(PropertyNames.Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? Width { get; set; }
        ///<summary>Optional. Animation height.</summary>
        [JsonPropertyName(PropertyNames.Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? Height { get; set; }
        ///<summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can’t be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt; <a href="https://core.telegram.org/bots/api#sending-files">More Info in Sending Files</a></summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object? Thumb { get; set; }
        ///<summary>Optional. Animation caption (may also be used when resending animation by file_id), 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Caption { get; set; }
        /// <summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in the media caption.</summary>
        [JsonPropertyName(PropertyNames.ParseMode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ParseMode { get; set; }
        /// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName(PropertyNames.CaptionEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<AttachedFile> AttachedFiles { get; set; } = new List<AttachedFile>();

        bool IMultipartForm.UseMultipart()
        {
            if (Animation != default)
            {
                if (Animation.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }

            if (Thumb != default)
            {
                if (Thumb.GetType() == typeof(InputFile))
                {
                    return true;
                }
            }

            return AttachedFiles.Any();
        }
    }
}
