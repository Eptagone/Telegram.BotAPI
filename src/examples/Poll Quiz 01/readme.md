# Poll Quiz - Sample 01

## Description
.NET Core console app

Create a quiz from the new polls 2.0

## Preview
![quiz gif](/docs/media/samples/Quiz.gif)

## Source Code
```CSharp
using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace Poll_Quiz_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");
            var bot = new TelegramBotClient("<your bot token>");
            bot.SetMyCommands(new BotCommand("quiz", "New quiz"));
            var updates = bot.GetUpdates();
            while (true)
            {
                if (updates.Length > 0)
                {
                    foreach (var update in updates)
                    {
                        switch (update.Type)
                        {
                            case UpdateType.Message:
                                if (update.Message.Text.Contains("/quiz"))
                                {
                                    bot.SendPoll(new SendPollArgs
                                    {
                                        ChatId = update.Message.Chat.Id,
                                        Question = "¿5 + 5?",
                                        Options = new string[]{
                                            "56", "7", "10", "-4"
                                        },
                                        Type = "quiz",
                                        CorrectOptionId = 2
                                    });
                                }
                                break;
                        }
                    }
                    updates = bot.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
                }
                else
                {
                    updates = bot.GetUpdates();
                }
            }
        }
    }
}
```