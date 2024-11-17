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

TelegramBotClient client = new("<your bot token>");
client.SetMyCommands([new BotCommand("reply", "ReplyMarkup"), new BotCommand("del", "Delete")]);

// Long Polling
IEnumerable<Update> updates = client.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (Update update in updates)
        {
            if (!string.IsNullOrEmpty(update.Message?.Text))
            {
                if (update.Message.Text.Contains("/reply"))
                {
                    ReplyKeyboardMarkup keyboard =
                        new(
                            [
                                [
                                    new KeyboardButton("Button 1"), //column 1 row 1
                                    new KeyboardButton(
                                        "Button 2"
                                    ) //column 1 row 2
                                    ,
                                ], // column 1
                                [
                                    new KeyboardButton(
                                        "Button 3"
                                    ) //col 2 row 1
                                    ,
                                ] // column 2
                                ,
                            ]
                        )
                        {
                            ResizeKeyboard = true,
                        };
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

        updates = client.GetUpdates(updates.Max(u => u.UpdateId) + 1);
    }
    else
    {
        updates = client.GetUpdates();
    }
}
