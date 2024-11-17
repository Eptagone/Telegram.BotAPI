// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using TelegramCalendar;

Console.WriteLine("Start!");
CalendarBot bot = new();
bot.Client.SetMyCommands([new BotCommand("calendar", "Telegram Calendar")]);

// Long Polling
IEnumerable<Update> updates = bot.Client.GetUpdates(
    allowedUpdates: [UpdateTypes.Message, UpdateTypes.CallbackQuery]
);
while (true)
{
    if (updates.Any())
    {
        foreach (Update update in updates)
        {
            bot.OnUpdate(update);
        }

        updates = bot.Client.GetUpdates(updates.Max(u => u.UpdateId) + 1);
    }
    else
    {
        updates = bot.Client.GetUpdates();
    }
}
