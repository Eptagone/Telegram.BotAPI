// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents a link to a voice message stored on the Telegram servers. By default, this voice message will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the voice message.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultCachedVoice : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultCachedVoice>
    {
        /// <summary>Type of the result, must be voice</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Voice;
        /// <summary>A valid file identifier for the voice message.</summary>
        [JsonPropertyName(PropertyNames.VoiceFileId)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string VoiceFileId { get; set; }
        /// <summary>Voice message title.</summary>
        [JsonPropertyName(PropertyNames.Title)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Title { get; set; }
        /// <summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the voice message.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultCachedVoice);
        }

        public bool Equals(InlineQueryResultCachedVoice other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<IEnumerable<MessageEntity>>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   VoiceFileId == other.VoiceFileId &&
                   Title == other.Title &&
                   Caption == other.Caption &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent);
        }

        public override int GetHashCode()
        {
            int hashCode = 864641024;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(VoiceFileId);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Title);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultCachedVoice left, InlineQueryResultCachedVoice right)
        {
            return EqualityComparer<InlineQueryResultCachedVoice>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultCachedVoice left, InlineQueryResultCachedVoice right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
