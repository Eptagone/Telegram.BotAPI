// Copyright (c) 2021 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.InlineMode;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI
{
    /// <summary>Interface for Telegram Bots</summary>
    public interface ITelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        public void OnUpdate(Update update);
    }
}
