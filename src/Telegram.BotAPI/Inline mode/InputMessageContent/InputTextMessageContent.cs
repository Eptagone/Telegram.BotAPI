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
    /// <summary>Represents the content of a text message to be sent as the result of an inline query.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InputTextMessageContent : InputMessageContent, IEquatable<InputTextMessageContent>
    {
        ///<summary>Text of the message to be sent, 1-4096 characters.</summary>
        [JsonPropertyName(PropertyNames.MessageText)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string MessageText { get; set; }
        ///<summary>Optional. Send Markdown or HTML, if you want Telegram apps to show bold, italic, fixed-width text or inline URLs in your bot's message.</summary>
        [JsonPropertyName(PropertyNames.ParseMode)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string ParseMode { get; set; }
        ///<summary>Optional. List of special entities that appear in message text, which can be specified instead of parse_mode.</summary>
        [JsonPropertyName(PropertyNames.Entities)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<MessageEntity> Entities { get; set; }
        ///<summary>Optional. Disables link previews for links in the sent message.</summary>
        [JsonPropertyName(PropertyNames.DisableWebPagePreview)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool DisableWebPagePreview { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputTextMessageContent);
        }

        public bool Equals(InputTextMessageContent other)
        {
            return other != null &&
                   MessageText == other.MessageText &&
                   ParseMode == other.ParseMode &&
                   EqualityComparer<IEnumerable<MessageEntity>>.Default.Equals(Entities, other.Entities) &&
                   DisableWebPagePreview == other.DisableWebPagePreview;
        }

        public override int GetHashCode()
        {
            int hashCode = 119831400;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(MessageText);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ParseMode);
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<MessageEntity>>.Default.GetHashCode(Entities);
            hashCode = hashCode * -1521134295 + DisableWebPagePreview.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(InputTextMessageContent left, InputTextMessageContent right)
        {
            return EqualityComparer<InputTextMessageContent>.Default.Equals(left, right);
        }

        public static bool operator !=(InputTextMessageContent left, InputTextMessageContent right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
