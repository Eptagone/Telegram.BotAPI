# Callback query button - Sample 01

## Description
.NET Core console app

Create a button with the /callback command
Pressing it edits the message, removing the button and typing new text.

## Preview
![callbacks gif](/docs/media/samples/CallbackButton.gif)

## Source Code
```CSharp
using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.UpdatingMessages;

namespace CallbackQueryButton01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Start!");
            var bot = new TelegramBotClient("<your bot token>");
            bot.SetMyCommands(new BotCommand("callback", "new callback"));
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
                                var message = update.Message;
                                if (message.Text.Contains("/callback"))
                                {
                                    var replyMarkup = new InlineKeyboardMarkup
                                    {
                                        InlineKeyboard = new InlineKeyboardButton[][]{
                                        new InlineKeyboardButton[]{
                                            InlineKeyboardButton.SetCallbackData("Callback", "callback_data")
                                            }
                                        }
                                    };
                                    bot.SendMessage(message.Chat.Id, "Message with callback data", replyMarkup: replyMarkup);
                                }
                                break;
                            case UpdateType.CallbackQuery:
                                var query = update.CallbackQuery;
                                bot.AnswerCallbackQuery(query.Id, "HELLO");
                                bot.EditMessageText(new EditMessageTextArgs
                                {
                                    ChatId = query.Message.Chat.Id,
                                    MessageId = query.Message.MessageId,
                                    Text = $"Click!\n\n{query.Data}"
                                });
                                break;
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
```