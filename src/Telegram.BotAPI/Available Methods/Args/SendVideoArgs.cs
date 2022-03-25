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
    /// <summary>SendVideo method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class SendVideoArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IAttachFiles, IMultipartForm
    {
        /// <summary>Initialize a new instance of <see cref="SendVideoArgs"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data.</param>
        public SendVideoArgs(long chatId, InputFile video) : base(chatId)
        {
            Video = video;
        }
        /// <summary>Initialize a new instance of <see cref="SendVideoArgs"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data.</param>
        public SendVideoArgs(long chatId, string video) : base(chatId)
        {
            Video = video;
        }
        /// <summary>Initialize a new instance of <see cref="SendVideoArgs"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data.</param>
        public SendVideoArgs(string chatId, InputFile video) : base(chatId)
        {
            Video = video;
        }
        /// <summary>Initialize a new instance of <see cref="SendVideoArgs"/>.</summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="video">Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data.</param>
        public SendVideoArgs(string chatId, string video) : base(chatId)
        {
            Video = video;
        }


        ///<summary>Video to send. Pass a file_id as String to send a video that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a video from the Internet, or upload a new video using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Video)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Video { get; }
        ///<summary>Optional. Duration of sent video in seconds.</summary>
        [JsonPropertyName(PropertyNames.Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? Duration { get; set; }
        ///<summary>Optional. Video width.</summary>
        [JsonPropertyName(PropertyNames.Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? Width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName(PropertyNames.Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? Height { get; set; }
        ///<summary>Optional. Thumbnail of the file sent; can be ignored if thumbnail generation for the file is supported server-side. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail's width and height should not exceed 320. Ignored if the file is not uploaded using multipart/form-data. Thumbnails can't be reused and can be only uploaded as a new file, so you can pass “attach://&lt;file_attach_name&gt;” if the thumbnail was uploaded using multipart/form-data under &lt;file_attach_name&gt;.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object? Thumb { get; set; }
        ///<summary>Optional. Video caption (may also be used when resending videos by file_id), 0-1024 characters.</summary>
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
        ///<summary>Optional. Pass True, if the uploaded video is suitable for streaming.</summary>
        [JsonPropertyName(PropertyNames.SupportsStreaming)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SupportsStreaming { get; set; }
        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        [Newtonsoft.Json.JsonIgnore]
        public ICollection<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

        bool IMultipartForm.UseMultipart()
        {
            if (Video != default)
            {
                if (Video.GetType() == typeof(InputFile))
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
