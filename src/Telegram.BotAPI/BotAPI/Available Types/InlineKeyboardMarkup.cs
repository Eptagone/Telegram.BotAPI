// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class InlineKeyboardMarkup : ReplyMarkup, IEquatable<InlineKeyboardMarkup>
    {
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        public InlineKeyboardMarkup() { }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(params IEnumerable<InlineKeyboardButton>[] inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(params InlineKeyboardButton[][] inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }
        ///<summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
        ///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
        public InlineKeyboardMarkup(IEnumerable<IEnumerable<InlineKeyboardButton>> inlineKeyboard)
        {
            InlineKeyboard = inlineKeyboard;
        }

        ///<summary>Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</summary>
        [JsonPropertyName(PropertyNames.InlineKeyboard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<IEnumerable<InlineKeyboardButton>> InlineKeyboard { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InlineKeyboardMarkup);
        }

        public bool Equals(InlineKeyboardMarkup other)
        {
            return other != null &&
                EqualityComparer<IEnumerable<IEnumerable<InlineKeyboardButton>>>.Default.Equals(InlineKeyboard, other.InlineKeyboard);
        }

        public override int GetHashCode()
        {
            return 1862756913 + EqualityComparer<IEnumerable<IEnumerable<InlineKeyboardButton>>>.Default.GetHashCode(InlineKeyboard);
        }

        public static bool operator ==(InlineKeyboardMarkup left, InlineKeyboardMarkup right)
        {
            return EqualityComparer<InlineKeyboardMarkup>.Default.Equals(left, right);
        }

        public static bool operator !=(InlineKeyboardMarkup left, InlineKeyboardMarkup right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
