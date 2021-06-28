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
    /// <summary>Represents a link to an article or web page.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultArticle : InlineQueryResult, IExternalThumbnail, IEquatable<InlineQueryResultArticle>
    {
        /// <summary>Type of the result, must be article.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Article;
        /// <summary>Title of the result.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Content of the message to be sent.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>Optional. URL of the result.</summary>
        [JsonPropertyName(PropertyNames.Url)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        /// <summary>Optional. Pass True, if you don't want the URL to be shown in the message.</summary>
        [JsonPropertyName(PropertyNames.HideUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool HideUrl { get; set; }
        /// <summary>Optional. Short description of the result.</summary>
        [JsonPropertyName(PropertyNames.Description)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Description { get; set; }
        /// <summary>URL of the static thumbnail for the result (jpeg or gif).</summary>
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
            return Equals(obj as InlineQueryResultArticle);
        }

        public bool Equals(InlineQueryResultArticle other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   Type == other.Type &&
                   Title == other.Title &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent) &&
                   Url == other.Url &&
                   HideUrl == other.HideUrl &&
                   Description == other.Description &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbWidth == other.ThumbWidth &&
                   ThumbHeight == other.ThumbHeight;
        }

        public override int GetHashCode()
        {
            int hashCode = 1439155506;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Url);
            hashCode = hashCode * -1521134295 + HideUrl.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + ThumbWidth.GetHashCode();
            hashCode = hashCode * -1521134295 + ThumbHeight.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultArticle left, InlineQueryResultArticle right)
        {
            return EqualityComparer<InlineQueryResultArticle>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultArticle left, InlineQueryResultArticle right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
