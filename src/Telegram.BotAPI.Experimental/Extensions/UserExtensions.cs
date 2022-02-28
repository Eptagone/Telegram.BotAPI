// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI.AvailableTypes
{
    public static class UserExtensions
    {
        /// <summary>Gets user's fullname.</summary>
        /// <param name="user">User information.</param>
        /// <returns>The user's fullname.</returns>
        public static string GetFullname(this User user)
        {
            var fullname = user.FirstName;
            if (!string.IsNullOrEmpty(user.LastName))
            {
                fullname += string.Format(" {0}", user.LastName);
            }
            return fullname;
        }
    }
}
