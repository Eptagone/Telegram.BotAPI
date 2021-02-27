// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.


using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class ReplyKeyboardMarkup : ReplyMarkup, IEquatable<ReplyKeyboardMarkup>
    {
        /// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
        public ReplyKeyboardMarkup() { }
        /// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
        /// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
        public ReplyKeyboardMarkup(params IEnumerable<KeyboardButton>[] keyboard)
        {
            Keyboard = keyboard;
        }
        /// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
        /// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
        public ReplyKeyboardMarkup(params KeyboardButton[][] keyboard)
        {
            Keyboard = keyboard;
        }

        /// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
        /// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
        /// <param name="resizeKeyboard">Optional. Requests clients to resize the keyboard vertically for optimal fit (e.g., make the keyboard smaller if there are just two rows of buttons). Defaults to false, in which case the custom keyboard is always of the same height as the app's standard keyboards.</param>
        /// <param name="oneTimeKeyboard">Optional. Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat – the user can press a special button in the input field to see the custom keyboard again. Defaults to false.</param>
        /// <param name="selective">Optional. Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.<para>Example: A user requests to change the bot‘s language, bot replies to the request with a keyboard to select the new language. Other users in the group don’t see the keyboard.</para></param>
        public ReplyKeyboardMarkup(
            IEnumerable<IEnumerable<KeyboardButton>> keyboard,
            [Optional] bool resizeKeyboard,
            [Optional] bool oneTimeKeyboard,
            [Optional] bool selective)
        {
            Keyboard = keyboard;
            ResizeKeyboard = resizeKeyboard;
            OneTimeKeyboard = oneTimeKeyboard;
            Selective = selective;
        }
        /// <summary>This object represents a custom keyboard with reply options (see Introduction to bots for details and examples).</summary>
        /// <param name="resizeKeyboard">Optional. Requests clients to resize the keyboard vertically for optimal fit (e.g., make the keyboard smaller if there are just two rows of buttons). Defaults to false, in which case the custom keyboard is always of the same height as the app's standard keyboards.</param>
        /// <param name="oneTimeKeyboard">Optional. Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat – the user can press a special button in the input field to see the custom keyboard again. Defaults to false.</param>
        /// <param name="selective">Optional. Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.<para>Example: A user requests to change the bot‘s language, bot replies to the request with a keyboard to select the new language. Other users in the group don’t see the keyboard.</para></param>
        /// <param name="keyboard">Array of button rows, each represented by an Array of KeyboardButton objects.</param>
        public ReplyKeyboardMarkup(
            KeyboardButton[][] keyboard,
            bool resizeKeyboard,
            bool oneTimeKeyboard,
            bool selective)
        {
            Keyboard = keyboard;
            ResizeKeyboard = resizeKeyboard;
            OneTimeKeyboard = oneTimeKeyboard;
            Selective = selective;
        }

        ///<summary>Array of button rows, each represented by an Array of KeyboardButton objects.</summary>
        [JsonPropertyName(PropertyNames.Keyboard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<IEnumerable<KeyboardButton>> Keyboard { get; set; }
        ///<summary>Optional. Requests clients to resize the keyboard vertically for optimal fit (e.g., make the keyboard smaller if there are just two rows of buttons). Defaults to false, in which case the custom keyboard is always of the same height as the app's standard keyboards.</summary>
        [JsonPropertyName(PropertyNames.ResizeKeyboard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool ResizeKeyboard { get; set; }
        ///<summary>Optional. Requests clients to hide the keyboard as soon as it's been used. The keyboard will still be available, but clients will automatically display the usual letter-keyboard in the chat – the user can press a special button in the input field to see the custom keyboard again. Defaults to false.</summary>
        [JsonPropertyName(PropertyNames.OneTimeKeyboard)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool OneTimeKeyboard { get; set; }
        ///<summary>Optional. Use this parameter if you want to show the keyboard to specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.<para>Example: A user requests to change the bot‘s language, bot replies to the request with a keyboard to select the new language. Other users in the group don’t see the keyboard.</para></summary>
        [JsonPropertyName(PropertyNames.Selective)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool Selective { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as ReplyKeyboardMarkup);
        }

        public bool Equals(ReplyKeyboardMarkup other)
        {
            return other != null &&
                   EqualityComparer<IEnumerable<IEnumerable<KeyboardButton>>>.Default.Equals(Keyboard, other.Keyboard) &&
                   ResizeKeyboard == other.ResizeKeyboard &&
                   OneTimeKeyboard == other.OneTimeKeyboard &&
                   Selective == other.Selective;
        }

        public override int GetHashCode()
        {
            int hashCode = 1321663856;
            hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<IEnumerable<KeyboardButton>>>.Default.GetHashCode(Keyboard);
            hashCode = hashCode * -1521134295 + ResizeKeyboard.GetHashCode();
            hashCode = hashCode * -1521134295 + OneTimeKeyboard.GetHashCode();
            hashCode = hashCode * -1521134295 + Selective.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(ReplyKeyboardMarkup left, ReplyKeyboardMarkup right)
        {
            return EqualityComparer<ReplyKeyboardMarkup>.Default.Equals(left, right);
        }

        public static bool operator !=(ReplyKeyboardMarkup left, ReplyKeyboardMarkup right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
