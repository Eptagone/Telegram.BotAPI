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
    /// <summary>Represents a link to an animated GIF file. By default, this animated GIF file will be sent by the user with optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the animation.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultGif : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultGif>
    {
        /// <summary>Type of the result, must be gif.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Gif;
        ///<summary>A valid URL for the GIF file. File size must not exceed 1MB.</summary>
        [JsonPropertyName(PropertyNames.GifUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GifUrl { get; set; }
        /// <summary>Optional. Width of the GIF.</summary>
        [JsonPropertyName(PropertyNames.GifWidth)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GifWidth { get; set; }
        ///<summary>Optional. Height of the GIF.</summary>
        [JsonPropertyName(PropertyNames.GifHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GifHeight { get; set; }
        ///<summary>Optional. Duration of the GIF.</summary>
        [JsonPropertyName(PropertyNames.GifDuration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string GifDuration { get; set; }
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
        ///<summary>Optional. Caption of the GIF file to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultGif);
        }

        public bool Equals(InlineQueryResultGif other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   GifUrl == other.GifUrl &&
                   GifWidth == other.GifWidth &&
                   GifHeight == other.GifHeight &&
                   GifDuration == other.GifDuration &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbMimeType == other.ThumbMimeType &&
                   Title == other.Title &&
                   Caption == other.Caption &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent);
        }

        public override int GetHashCode()
        {
            int hashCode = -1113146679;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GifUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GifWidth);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GifHeight);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(GifDuration);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbMimeType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultGif left, InlineQueryResultGif right)
        {
            return EqualityComparer<InlineQueryResultGif>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultGif left, InlineQueryResultGif right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
