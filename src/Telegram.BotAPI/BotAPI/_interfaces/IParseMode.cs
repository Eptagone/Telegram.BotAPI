// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI
{
    /// <summary>Interface for objects that includes the parse_mode property.</summary>
    public interface IParseMode
    {
        ///<summary>Optional. Mode for parsing. See <a href="https://core.telegram.org/bots/api#formatting-options">formatting options</a> for more details.</summary>
        public string ParseMode { get; set; }
    }
}
