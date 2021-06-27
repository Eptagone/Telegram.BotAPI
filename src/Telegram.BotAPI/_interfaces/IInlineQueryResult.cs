// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.InlineMode;

namespace Telegram.BotAPI
{
    /// <summary>Interface for <see cref="InlineQueryResult"/> objects.</summary>
    public interface IInlineQueryResult
    {
        /// <summary>Type of the result.</summary>
        public string Type { get; }
        /// <summary>Unique identifier for this result, 1-64 Bytes.</summary>
        public string Id { get; set; }
        /// <summary>Optional. Inline keyboard attached to the message.</summary>
        public InlineKeyboardMarkup ReplyMarkup { get; set; }
    }
}
