// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode
{
    /// <summary>Represents the content of a contact message to be sent as the result of an inline query.</summary>
    public sealed class InputContactMessageContent : InputMessageContent, IContact, IEquatable<InputContactMessageContent>
    {
        /// <summary>Contact's phone number.</summary>
        public string PhoneNumber { get; set; }
        /// <summary>Contact's first name.</summary>
        public string FirstName { get; set; }
        /// <summary>Optional. Contact's last name.</summary>
        public string LastName { get; set; }
        /// <summary>Optional. Additional data about the contact in the form of a vCard.</summary>
        public string Vcard { get; set; }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public override bool Equals(object obj)
        {
            return Equals(obj as InputContactMessageContent);
        }

        public bool Equals(InputContactMessageContent other)
        {
            return other != null &&
                   PhoneNumber == other.PhoneNumber &&
                   FirstName == other.FirstName &&
                   LastName == other.LastName &&
                   Vcard == other.Vcard;
        }

        public override int GetHashCode()
        {
            int hashCode = -229410427;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(PhoneNumber);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Vcard);
            return hashCode;
        }

        public static bool operator ==(InputContactMessageContent left, InputContactMessageContent right)
        {
            return EqualityComparer<InputContactMessageContent>.Default.Equals(left, right);
        }

        public static bool operator !=(InputContactMessageContent left, InputContactMessageContent right)
        {
            return !(left == right);
        }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}
