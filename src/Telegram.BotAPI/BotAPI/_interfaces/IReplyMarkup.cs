// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects with reply_markup property.</summary>
    public interface IReplyMarkup<T>
        where T : ReplyMarkup
    {
        /// <summary>Optional. Additional interface options.</summary>
        public T ReplyMarkup { get; set; }
    }

}
