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
    /// <summary>Represents a link to a sticker stored on the Telegram servers. By default, this sticker will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the sticker.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultCachedSticker : InlineQueryResult, IEquatable<InlineQueryResultCachedSticker>
    {
        /// <summary>Type of the result, must be sticker.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Sticker;
        /// <summary>A valid file identifier of the sticker.</summary>
        [JsonPropertyName(PropertyNames.StickerFileId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string StickerFileId { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the sticker.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultCachedSticker);
        }

        public bool Equals(InlineQueryResultCachedSticker other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   Type == other.Type &&
                   StickerFileId == other.StickerFileId &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent);
        }

        public override int GetHashCode()
        {
            int hashCode = -680348338;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(StickerFileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultCachedSticker left, InlineQueryResultCachedSticker right)
        {
            return EqualityComparer<InlineQueryResultCachedSticker>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultCachedSticker left, InlineQueryResultCachedSticker right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
