// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>This object represents one special entity in a text message. For example, hashtags, usernames, URLs, etc.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class MessageEntity : IEquatable<MessageEntity>
    {
        /// <summary>Type of the entity. Can be “mention” (@username), “hashtag” (#hashtag), “cashtag” ($USD), “bot_command” (/start@jobs_bot), “url” (https://telegram.org), “email” (do-not-reply@telegram.org), “phone_number” (+1-212-555-0123), “bold” (bold text), “italic” (italic text), “underline” (underlined text), “strikethrough” (strikethrough text), “code” (monowidth string), “pre” (monowidth block), “text_link” (for clickable text URLs), “text_mention” (for users without usernames).</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type { get; set; }
        /// <summary>Offset in UTF-16 code units to the start of the entity.</summary>
        [JsonPropertyName(PropertyNames.Offset)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Offset { get; set; }
        /// <summary>Length of the entity in UTF-16 code units.</summary>
        [JsonPropertyName(PropertyNames.Length)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint Length { get; set; }
        /// <summary>Optional. For “text_link” only, url that will be opened after user taps on the text.</summary>
        [JsonPropertyName(PropertyNames.Url)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Url { get; set; }
        /// <summary>Optional. For “text_mention” only, the mentioned user.</summary>
        [JsonPropertyName(PropertyNames.User)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public User User { get; set; }
        /// <summary>Optional. For “pre” only, the programming language of the entity text.</summary>
        [JsonPropertyName(PropertyNames.Language)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Language { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as MessageEntity);
        }

        public bool Equals(MessageEntity other)
        {
            return other != null &&
                   Type == other.Type &&
                   Offset == other.Offset &&
                   Length == other.Length &&
                   Url == other.Url &&
                   EqualityComparer<User>.Default.Equals(User, other.User) &&
                   Language == other.Language;
        }

        public override int GetHashCode()
        {
            int hashCode = -730586585;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + Offset.GetHashCode();
            hashCode = hashCode * -1521134295 + Length.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Url);
            hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(User);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Language);
            return hashCode;
        }

        public static bool operator ==(MessageEntity left, MessageEntity right)
        {
            return EqualityComparer<MessageEntity>.Default.Equals(left, right);
        }

        public static bool operator !=(MessageEntity left, MessageEntity right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
