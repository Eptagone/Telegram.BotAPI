// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.ComponentModel.DataAnnotations;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Abstractions
{
    public abstract class TelegramUser : ITelegramUser
    {
        public TelegramUser()
        {
        }

        public TelegramUser(ITelegramUser user) : this()
        {
            Id = user.Id;
            Username = user.Username;
            FirstName = user.FirstName;
            LastName = user.LastName;
            LanguageCode = user.LanguageCode;
        }

        [Key]
        public long Id { get; set; }

        [MaxLength(64)]
        public string FirstName { get; set; } = null!;
        [MaxLength(64)]
        public string? LastName { get; set; }
        [MaxLength(32)]
        [MinLength(5)]
        public string? Username { get; set; }
        public string? LanguageCode { get; set; }

        bool ITelegramUser.IsBot => false;
    }
}
