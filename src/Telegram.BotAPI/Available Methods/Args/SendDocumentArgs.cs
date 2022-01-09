// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.AvailableMethods
{
    /// <summary>SendDocument method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendDocumentArgs : SendMessageWithReplyMarkupBase, ICaption, IFormattableMessage, IAttachFiles, IThumbnail<object>
    {
        /// <summary>
        /// Initialize a new instance of <see cref="SendDocumentArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendDocumentArgs(long chatId, InputFile document) : base(chatId)
        {
            Document = document ?? throw new ArgumentNullException(nameof(document));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendDocumentArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendDocumentArgs(long chatId, string document) : base(chatId)
        {
            Document = document ?? throw new ArgumentNullException(nameof(document));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendDocumentArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendDocumentArgs(string chatId, InputFile document) : base(chatId)
        {
            Document = document ?? throw new ArgumentNullException(nameof(document));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendDocumentArgs"/>.
        /// </summary>
        /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
        /// <param name="document">File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendDocumentArgs(string chatId, string document) : base(chatId)
        {
            Document = document ?? throw new ArgumentNullException(nameof(document));
        }

        ///<summary>File to send. Pass a file_id as String to send a file that exists on the Telegram servers (recommended), pass an HTTP URL as a String for Telegram to get a file from the Internet, or upload a new one using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Document)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object Document { get; }
        ///<summary>Optional. InputFile or String. Thumbnail of the file sent. The thumbnail should be in JPEG format and less than 200 kB in size. A thumbnail‘s width and height should not exceed 90. Ignored if the file is not uploaded using multipart/form-data.</summary>
        [JsonPropertyName(PropertyNames.Thumb)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public object? Thumb { get; set; }
        ///<summary>Document caption (may also be used when resending documents by file_id), 0-1024 characters after entities parsing.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? Caption { get; set; }
        /// <summary>Mode for parsing entities in the document caption. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</summary>
        [JsonPropertyName(PropertyNames.ParseMode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ParseMode { get; set; }
        /// <summary>Optional. List of special entities that appear in the caption, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName(PropertyNames.CaptionEntities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity>? CaptionEntities { get; set; }
        /// <summary>Optional. Disables automatic server-side content type detection for files uploaded using multipart/form-data. Always true, if the document is sent as part of an album.</summary>
        [JsonPropertyName(PropertyNames.DisableContentTypeDetection)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? DisableContentTypeDetection { get; set; }

        /// <summary>Attached files.</summary>
        [System.Text.Json.Serialization.JsonIgnore]
        public ICollection<AttachedFile> AttachedFiles { get; set; } = new HashSet<AttachedFile>();

        bool IMultipartForm.UseMultipart()
        {
            if (Document != default)
            {
                if (Document.GetType() == typeof(InputFile))
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
