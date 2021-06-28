// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a link to a video animation (H.264/MPEG-4 AVC video without sound). By default, this animated MPEG-4 file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultMpeg4Gif : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultMpeg4Gif>
    {
        /// <summary>Type of the result, must be mpeg4_gif.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Mpeg4Gif;
        ///<summary>A valid URL for the MP4 file. File size must not exceed 1MB.</summary>
        [JsonPropertyName(PropertyNames.Mpeg4Url)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Mpeg4Url { get; set; }
        /// <summary>Optional. Video width.</summary>
        [JsonPropertyName(PropertyNames.Mpeg4Width)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4Width { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName(PropertyNames.Mpeg4Height)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4Height { get; set; }
        ///<summary>Optional. Video height.</summary>
        [JsonPropertyName(PropertyNames.Mpeg4Duration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public int Mpeg4Duration { get; set; }
        /// <summary>URL of the static (JPEG or GIF) or animated (MPEG4) thumbnail for the result.</summary>
        [JsonPropertyName(PropertyNames.ThumbUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbUrl { get; set; }
        /// <summary>Optional. MIME type of the thumbnail, must be one of “image/jpeg”, “image/gif”, or “video/mp4”. Defaults to “image/jpeg”.</summary>
        [JsonPropertyName(PropertyNames.ThumbMimeType)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbMimeType { get; set; }
        /// <summary>Optional. Title of the result.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        ///<summary>Optional. Caption of the MPEG-4 file to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the video animation.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultMpeg4Gif);
        }

        public bool Equals(InlineQueryResultMpeg4Gif other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Mpeg4Url == other.Mpeg4Url &&
                   Mpeg4Width == other.Mpeg4Width &&
                   Mpeg4Height == other.Mpeg4Height &&
                   Mpeg4Duration == other.Mpeg4Duration &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbMimeType == other.ThumbMimeType &&
                   Title == other.Title &&
                   Caption == other.Caption &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent);
        }

        public override int GetHashCode()
        {
            int hashCode = -572359803;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Mpeg4Url);
            hashCode = hashCode * -1521134295 + Mpeg4Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Mpeg4Height.GetHashCode();
            hashCode = hashCode * -1521134295 + Mpeg4Duration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbMimeType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultMpeg4Gif left, InlineQueryResultMpeg4Gif right)
        {
            return EqualityComparer<InlineQueryResultMpeg4Gif>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultMpeg4Gif left, InlineQueryResultMpeg4Gif right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
