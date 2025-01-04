// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Collections.Generic;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.UpdatingMessages;

Console.WriteLine("Start!");

TelegramBotClient bot = new("<your bot token>");
bot.SetMyCommands([new BotCommand("callback", "new callback")]);

// Long Polling
IEnumerable<Update> updates = bot.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (Update update in updates)
        {
            if (update.Message?.Chat is not null && !string.IsNullOrEmpty(update.Message.Text))
            {
                if (!update.Message.Text.Contains("/callback"))
                {
                    continue;
                }

                InlineKeyboardMarkup replyMarkup =
                    new(
                        new InlineKeyboardButton[][]
                        {

                            [
                                new InlineKeyboardButton("Callback")
                                {
                                    CallbackData = "callback_data",
                                },
                            ],
                        }
                    );
                bot.SendMessage(
                    update.Message.Chat.Id,
                    "Message with callback data",
                    replyMarkup: replyMarkup
                );
            }
            else if (update.CallbackQuery?.Message is not null)
            {
                bot.AnswerCallbackQuery(update.CallbackQuery.Id, "HELLO");
                bot.EditMessageText(
                    update.CallbackQuery.Message.Chat.Id,
                    update.CallbackQuery.Message.MessageId,
                    $"Click!\n\n{update.CallbackQuery.Data}"
                );
            }
        }

        updates = updates = bot.GetUpdates(updates.Max(u => u.UpdateId) + 1);
    }
    else
    {
        updates = bot.GetUpdates();
    }
}
