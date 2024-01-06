# Hello World - Sample

## Description
.NET Core console app

The bot sends "Hello World!" when it receives a message

## Preview
![hello world gif](/docs/media/samples/HelloWorld.gif)

## Source Code
```CSharp
using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.GettingUpdates;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");
            var bot = new TelegramBotClient("<your bot token>");
            var updates = bot.GetUpdates();
            while (true)
            {
                if (updates.Length > 0)
                {
                    foreach (var update in updates)
                    {
                        if (update.Type == UpdateType.Message)
                        {
                            var message = update.Message;
                            //bot.SendChatAction(message.Chat.Id, ChatAction.Typing);
                            bot.SendMessage(message.Chat.Id, "Hello World!");
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