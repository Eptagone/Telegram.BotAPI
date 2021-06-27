// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes
{
    ///<summary>This object represents one button of the reply keyboard. For simple text buttons String can be used instead of this object to specify text of the button. Optional fields are mutually exclusive.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class KeyboardButton : IEquatable<KeyboardButton>
    {
        /// <summary>Creates a new keyboard button.</summary>
        /// <param name="text">Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed.</param>
        public KeyboardButton(string text)
        {
            Text = text;
        }

        ///<summary>Text of the button. If none of the optional fields are used, it will be sent as a message when the button is pressed.</summary>
        [JsonPropertyName(PropertyNames.Text)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Text { get; set; }
        ///<summary>Optional. If True, the user's phone number will be sent as a contact when the button is pressed. Available in private chats only.</summary>
        [JsonPropertyName(PropertyNames.RequestContact)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool RequestContact { get; set; }
        ///<summary>Optional. If True, the user's current location will be sent when the button is pressed. Available in private chats only.</summary>
        [JsonPropertyName(PropertyNames.RequestLocation)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool RequestLocation { get; set; }
        ///<summary>Optional. If specified, the user will be asked to create a poll and send it to the bot when the button is pressed. Available in private chats only.</summary>
        [JsonPropertyName(PropertyNames.RequestPoll)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public KeyboardButtonPollType RequestPoll { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as KeyboardButton);
        }

        public bool Equals(KeyboardButton other)
        {
            return other != null &&
                   Text == other.Text &&
                   RequestContact == other.RequestContact &&
                   RequestLocation == other.RequestLocation &&
                   EqualityComparer<KeyboardButtonPollType>.Default.Equals(RequestPoll, other.RequestPoll);
        }

        public override int GetHashCode()
        {
            int hashCode = -21297012;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Text);
            hashCode = hashCode * -1521134295 + RequestContact.GetHashCode();
            hashCode = hashCode * -1521134295 + RequestLocation.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<KeyboardButtonPollType>.Default.GetHashCode(RequestPoll);
            return hashCode;
        }

        public static bool operator ==(KeyboardButton left, KeyboardButton right)
        {
            return EqualityComparer<KeyboardButton>.Default.Equals(left, right);
        }

        public static bool operator !=(KeyboardButton left, KeyboardButton right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
