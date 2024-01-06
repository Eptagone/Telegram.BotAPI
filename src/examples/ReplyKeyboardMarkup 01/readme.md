# Reply keyboard markup - Sample 01

## Description
.NET Core console app

Create a reply keyboard

## Preview
![keyboard gif](/docs/media/samples/ReplyKeyboard.gif)

## Source Code
```CSharp
using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace ReplyKeyboardMarkup_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");
            var bot = new TelegramBotClient("<your bot token>");
            var updates = bot.GetUpdates();
            bot.SetMyCommands(new BotCommand("reply", "ReplyMarkup"), new BotCommand("del", "Delete"));
            while (true)
            {
                if (updates.Length > 0)
                {
                    foreach (var update in updates)
                    {
                        switch (update.Type)
                        {
                            case UpdateType.Message:
                                if (update.Message.Text.Contains("/reply"))
                                {
                                    var keyboard = new ReplyKeyboardMarkup
                                    {
                                        Keyboard = new KeyboardButton[][]{
                                            new KeyboardButton[]{
                                                new KeyboardButton("Button 1"), //column 1 row 1
                                                new KeyboardButton("Button 2") //column 1 row 2
                                                },// column 1
                                            new KeyboardButton[]{
                                                new KeyboardButton("Button 3") //col 2 row 1
                                                } // column 2
                                        },
                                        ResizeKeyboard = true
                                    }; ;
                                    bot.SendMessage(update.Message.Chat.Id, "new keyboard", replyMarkup: keyboard);
                                }
                                if (update.Message.Text.Contains("/del"))
                                {
                                    bot.SendMessage(update.Message.Chat.Id, "remove reply keyboard", replyMarkup: new ReplyKeyboardRemove());
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