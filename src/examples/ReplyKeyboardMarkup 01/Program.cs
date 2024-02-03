// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

Console.WriteLine("Start!");

var client = new TelegramBotClient("<your bot token>");
client.SetMyCommands([new BotCommand("reply", "ReplyMarkup"), new BotCommand("del", "Delete")]);

// Long Polling
var updates = client.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (var update in updates)
        {
            if (update.Message != null)
            {
                if (update.Message.Text.Contains("/reply"))
                {
                    var keyboard = new ReplyKeyboardMarkup(
                        new KeyboardButton[][]
                        {
                            new KeyboardButton[]
                            {
                                new("Button 1"), //column 1 row 1
                                new("Button 2") //column 1 row 2
                            }, // column 1
                            new KeyboardButton[]
                            {
                                new("Button 3") //col 2 row 1
                            } // column 2
                        }
                    )
                    {
                        ResizeKeyboard = true
                    };
                    ;
                    client.SendMessage(
                        update.Message.Chat.Id,
                        "new keyboard",
                        replyMarkup: keyboard
                    );
                }
                if (update.Message.Text.Contains("/del"))
                {
                    client.SendMessage(
                        update.Message.Chat.Id,
                        "remove reply keyboard",
                        replyMarkup: new ReplyKeyboardRemove()
                    );
                }
            }
        }
        updates = client.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
    }
    else
    {
        updates = client.GetUpdates();
    }
}
