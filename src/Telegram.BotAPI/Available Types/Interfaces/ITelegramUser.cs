// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
    /// <summary>Defines the basic properties of a Telegram user.</summary>
    public interface ITelegramUser
    {
        /// <summary>Unique identifier for this user or bot.</summary>
        public long Id { get; set; }
        /// <summary>True, if this user is a bot.</summary>
        public bool IsBot { get; set; }
        /// <summary>User‘s or bot’s first name.</summary>
        public string FirstName { get; set; }
        /// <summary>Optional. User‘s or bot’s last name.</summary>
        public string LastName { get; set; }
        /// <summary>Optional. User‘s or bot’s username.</summary>
        public string Username { get; set; }
        /// <summary>Optional. IETF language tag of the user's language.</summary>
        public string LanguageCode { get; set; }
    }
}
