// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace BotTemplateSample
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");

            MyBot.Bot.SetMyCommands([new BotCommand("hello", "Hello World!!")]);
            MyBot.Bot.DeleteWebhook();
            // Long Polling: Start
            var updates = MyBot.Bot.GetUpdates();
            while (true)
            {
                if (updates.Any())
                {
                    foreach (var update in updates)
                    {
                        var botInstance = new MyBot();
                        botInstance.OnUpdate(update);
                    }
                    var offset = updates.Last().UpdateId + 1;
                    updates = MyBot.Bot.GetUpdates(offset);
                }
                else
                {
                    updates = MyBot.Bot.GetUpdates();
                }
            }
            // Long Polling: End
        }
    }
}
