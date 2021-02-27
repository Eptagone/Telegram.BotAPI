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
    /// <summary>Represents a link to a file. By default, this file will be sent by the user with an optional caption. Alternatively, you can use input_message_content to send a message with the specified content instead of the file. Currently, only .PDF and .ZIP files can be sent using this method.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultDocument : InlineQueryResultWithEntities, IInlineQueryResult, ICaption, IThumbUWH, IEquatable<InlineQueryResultDocument>
    {
        /// <summary>Type of the result, must be document.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "document";
        ///<summary>Optional. Caption of the document to be sent, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>A valid URL for the file.</summary>
        [JsonPropertyName(PropertyNames.DocumentUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string DocumentUrl { get; set; }
        /// <summary>Mime type of the content of the file, either “application/pdf” or “application/zip”.</summary>
        [JsonPropertyName(PropertyNames.MimeType)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MimeType { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the file.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>Optional. URL of the thumbnail (jpeg only) for the file.</summary>
        [JsonPropertyName(PropertyNames.ThumbUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ThumbUrl { get; set; }
        /// <summary>Optional. Thumbnail width.</summary>
        [JsonPropertyName(PropertyNames.ThumbWidth)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ThumbWidth { get; set; }
        /// <summary>Optional. Thumbnail height.</summary>
        [JsonPropertyName(PropertyNames.ThumbHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint ThumbHeight { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultDocument);
        }

        public bool Equals(InlineQueryResultDocument other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   Caption == other.Caption &&
                   DocumentUrl == other.DocumentUrl &&
                   MimeType == other.MimeType &&
                   Description == other.Description &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent) &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbWidth == other.ThumbWidth &&
                   ThumbHeight == other.ThumbHeight;
        }

        public override int GetHashCode()
        {
            int hashCode = -238500675;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(DocumentUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MimeType);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + ThumbWidth.GetHashCode();
            hashCode = hashCode * -1521134295 + ThumbHeight.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultDocument left, InlineQueryResultDocument right)
        {
            return EqualityComparer<InlineQueryResultDocument>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultDocument left, InlineQueryResultDocument right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
