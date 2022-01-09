// By Quetzal Rivera

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

            CalendarBot.Api.SetMyCommands(new BotCommand("calendar", "Telegram Calendar"));

            // Long Polling
            var updates = CalendarBot.Api.GetUpdates(allowedUpdates: new[] { AllowedUpdate.Message, AllowedUpdate.CallbackQuery });
            while (true)
            {
                if (updates.Length > 0)
                {
                    foreach (var update in updates)
                    {
                        var bot = new CalendarBot();
                        bot.OnUpdate(update);
                    }
                    updates = CalendarBot.Api.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
                }
                else
                {
                    updates = CalendarBot.Api.GetUpdates();
                }
            }
        }
        
    }
}
