// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI
{
    /// <summary>Defines the OnUpdate method, used by basic Telegram bots.</summary>
    public interface ITelegramBot
    {
        /// <summary>Call the corresponding method according to the type of update provided.</summary>
        /// <param name="update">Update</param>
        void OnUpdate(Update update);
    }
}
