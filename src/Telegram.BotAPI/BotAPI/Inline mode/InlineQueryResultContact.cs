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
    /// <summary>Represents a contact with a phone number. By default, this contact will be sent by the user. Alternatively, you can use input_message_content to send a message with the specified content instead of the contact.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineQueryResultContact : InlineQueryResult, IInlineQueryResult, IContact, IThumbUWH, IEquatable<InlineQueryResultContact>
    {
        /// <summary>Type of the result, must be contact.</summary>
        [JsonPropertyName(PropertyNames.Type)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Type => "contact";
        /// <summary>Contact's phone number.</summary>
        [JsonPropertyName(PropertyNames.PhoneNumber)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string PhoneNumber { get; set; }
        /// <summary>Contact's first name.</summary>
        [JsonPropertyName(PropertyNames.FirstName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string FirstName { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        [JsonPropertyName(PropertyNames.LastName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string LastName { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard, 0-2048 bytes.</summary>
        [JsonPropertyName(PropertyNames.Vcard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Vcard { get; set; }
        /// <summary>Optional. Content of the message to be sent instead of the contact.</summary>
        [JsonPropertyName(PropertyNames.InputMessageContent)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InputMessageContent InputMessageContent { get; set; }
        /// <summary>Optional. Url of the thumbnail for the result.</summary>
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
            return Equals(obj as InlineQueryResultContact);
        }

        public bool Equals(InlineQueryResultContact other)
        {
            return other != null &&
                   Id == other.Id &&
                   EqualityComparer<InlineKeyboardMarkup>.Default.Equals(ReplyMarkup, other.ReplyMarkup) &&
                   Type == other.Type &&
                   PhoneNumber == other.PhoneNumber &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Vcard == other.Vcard &&
                   EqualityComparer<InputMessageContent>.Default.Equals(InputMessageContent, other.InputMessageContent) &&
                   ThumbUrl == other.ThumbUrl &&
                   ThumbWidth == other.ThumbWidth &&
                   ThumbHeight == other.ThumbHeight;
        }

        public override int GetHashCode()
        {
            int hashCode = -737408647;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Id);
            hashCode = hashCode * -1521134295 + EqualityComparer<InlineKeyboardMarkup>.Default.GetHashCode(ReplyMarkup);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Vcard);
            hashCode = hashCode * -1521134295 + EqualityComparer<InputMessageContent>.Default.GetHashCode(InputMessageContent);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ThumbUrl);
            hashCode = hashCode * -1521134295 + ThumbWidth.GetHashCode();
            hashCode = hashCode * -1521134295 + ThumbHeight.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InlineQueryResultContact left, InlineQueryResultContact right)
        {
            return EqualityComparer<InlineQueryResultContact>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineQueryResultContact left, InlineQueryResultContact right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
