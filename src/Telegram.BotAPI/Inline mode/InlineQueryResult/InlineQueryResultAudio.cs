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
    /// <summary>Represents a link to an mp3 audio file. By default, this audio file will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the audio.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultAudio : InlineQueryResultWithEntities, ICaption, IEquatable<InlineQueryResultAudio>
    {
        /// <summary>Type of the result, must be audio.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public override string Type => InlineQueryResultType.Audio;
        ///<summary>A valid URL for the audio file.</summary>
        [JsonPropertyName(PropertyNames.AudioUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string AudioUrl { get; set; }
        ///<summary>Optional. Caption, 0-1024 characters.</summary>
        [JsonPropertyName(PropertyNames.Caption)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Caption { get; set; }
        /// <summary>Optional. Performer.</summary>
        [JsonPropertyName(PropertyNames.Performer)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Performer { get; set; }
        /// <summary>Optional. Audio duration in seconds.</summary>
        [JsonPropertyName(PropertyNames.AudioDuration)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint AudioDuration { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the audio.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineQueryResultAudio);
        }

        public bool Equals(InlineQueryResultAudio other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<MessageEntity[]>.Default.Equals(CaptionEntities, other.CaptionEntities) &&
                   Type == other.Type &&
                   AudioUrl == other.AudioUrl &&
                   Caption == other.Caption &&
                   Performer == other.Performer &&
                   AudioDuration == other.AudioDuration &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent);
        }

        public override int GetHashCode()
        {
            int hashCode = -1920528627;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<MessageEntity[]>.Default.GetHashCode(CaptionEntities);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(AudioUrl);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Caption);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Performer);
            hashCode = hashCode * -1521134295 + AudioDuration.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultAudio left, InlineQueryResultAudio right)
        {
            return EqualityComparer<InlineQueryResultAudio>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultAudio left, InlineQueryResultAudio right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
