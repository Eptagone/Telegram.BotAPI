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

TelegramBotClient bot = new("<BOT TOKEN>");
bot.SetMyCommands([new BotCommand("quiz", "New quiz")]);

// Long Polling
IEnumerable<Update> updates = bot.GetUpdates();
while (true)
{
    if (updates.Any())
    {
        foreach (Update update in updates)
        {
            if (update.Message?.Text?.Contains("/quiz") is true)
            {
                bot.SendPoll(
                    new SendPollArgs(
                        update.Message.Chat.Id,
                        "¿5 + 5?",
                        [
                            new InputPollOption("56"),
                            new InputPollOption("7"),
                            new InputPollOption("10"),
                            new InputPollOption("-4"),
                        ]
                    )
                    {
                        Type = "quiz",
                        CorrectOptionId = 2,
                    }
                );
            }
        }

        updates = bot.GetUpdates(updates.Max(u => u.UpdateId) + 1);
    }
    else
    {
        updates = bot.GetUpdates();
    }
}
