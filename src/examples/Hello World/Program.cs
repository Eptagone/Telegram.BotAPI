// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

Console.WriteLine("Start!");

TelegramBotClient bot = new("<your bot token>");

// Long Polling
IEnumerable<Update> updates = bot.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (Update update in updates)
        {
            if (update.Message != null)
            {
                Message message = update.Message;
                //bot.SendChatAction(message.Chat.Id, ChatAction.Typing);
                bot.SendMessage(message.Chat.Id, "Hello World!");
            }
        }

        updates = bot.GetUpdates(updates.Max(u => u.UpdateId) + 1);
    }
    else
    {
        updates = bot.GetUpdates();
    }
}
