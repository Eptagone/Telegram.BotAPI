// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace TelegramCalendar
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");
            var bot = new CalendarBot();
            bot.Client.SetMyCommands([new BotCommand("calendar", "Telegram Calendar")]);

            // Long Polling
            var updates = bot.Client.GetUpdates(
                allowedUpdates: new[] { UpdateTypes.Message, UpdateTypes.CallbackQuery }
            );
            while (true)
            {
                if (updates.Any())
                {
                    foreach (var update in updates)
                    {
                        bot.OnUpdate(update);
                    }
                    updates = bot.Client.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
                }
                else
                {
                    updates = bot.Client.GetUpdates();
                }
            }
        }
    }
}
