// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI
{
    /// <summary>Defines a property that implements a class or value type to add additional interface options to messages.</summary>
    public interface ICustomizableReplyMarkup<TReplyMarkup>
        where TReplyMarkup : ReplyMarkup
    {
        /// <summary>Optional. Additional interface options.</summary>
        public TReplyMarkup ReplyMarkup { get; set; }
    }
}
