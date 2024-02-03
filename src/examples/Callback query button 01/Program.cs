// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.UpdatingMessages;

namespace CallbackQueryButton01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");

            var bot = new TelegramBotClient("<your bot token>");
            bot.SetMyCommands([new BotCommand("callback", "new callback")]);

            // Long Polling
            var updates = bot.GetUpdates();
            while (true)
            {
                if (updates.Any())
                {
                    foreach (var update in updates)
                    {
                        if (update.Message != null)
                        {
                            var message = update.Message;
                            if (message.Text.Contains("/callback"))
                            {
                                var replyMarkup = new InlineKeyboardMarkup(
                                    new InlineKeyboardButton[][]
                                    {
                                        [new("Callback") { CallbackData = "callback_data" }]
                                    }
                                );
                                bot.SendMessage(
                                    message.Chat.Id,
                                    "Message with callback data",
                                    replyMarkup: replyMarkup
                                );
                            }
                        }
                        else if (update.CallbackQuery != null)
                        {
                            var query = update.CallbackQuery;
                            bot.AnswerCallbackQuery(query.Id, "HELLO");
                            bot.EditMessageText(
                                query.Message.Chat.Id,
                                query.Message.MessageId,
                                $"Click!\n\n{query.Data}"
                            );
                        }
                    }
                    updates = updates = bot.GetUpdates(offset: updates.Max(u => u.UpdateId) + 1);
                }
                else
                {
                    updates = bot.GetUpdates();
                }
            }
        }
    }
}
