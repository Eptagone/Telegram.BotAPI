// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Extensions;
using Telegram.BotAPI.UpdatingMessages;

namespace TelegramCalendar;

public sealed class CalendarBot : SimpleUpdateHandlerBase
{
    public TelegramBotClient Client { get; } = new("<your bot token>");

    protected override void OnMessage(Message message)
    {
        var text = message.Text;
        if (string.IsNullOrEmpty(text) || !text.Contains("/calendar"))
        {
            return;
        }

        var rm = new InlineKeyboardMarkup(Calendar.New(DateTime.Now));
        this.Client.SendMessage(
            message.Chat.Id,
            "🗓 <b>Telegram Bot Calendar</b> 🗓",
            parseMode: FormatStyles.HTML,
            replyMarkup: rm
        );
    }

    protected override void OnCallbackQuery(CallbackQuery query)
    {
        if (query.Message is null || string.IsNullOrEmpty(query.Data))
        {
            return;
        }
        var queryArgs = query.Data.Split(' ');
        switch (queryArgs.ElementAt(0))
        {
            case "month":
                var month = new Month(
                    (MonthName)Enum.Parse(typeof(MonthName), queryArgs[2]),
                    uint.Parse(queryArgs[1])
                );
                this.Client.EditMessageReplyMarkup(
                    query.Message.Chat.Id,
                    query.Message.MessageId,
                    replyMarkup: new InlineKeyboardMarkup(Calendar.New(month))
                );
                break;
            case "year":
                this.Client.EditMessageReplyMarkup(
                    query.Message.Chat.Id,
                    query.Message.MessageId,
                    replyMarkup: new InlineKeyboardMarkup(Calendar.New(uint.Parse(queryArgs[1])))
                );
                break;
            default:
                this.Client.AnswerCallbackQuery(query.Id, query.Data, true);
                break;
        }
    }

    protected override void OnException(Exception exp)
    {
        if (exp is BotRequestException)
        {
            Console.WriteLine("Bot Exception: {0}.", exp.Message);
        }
        else
        {
            Console.WriteLine("Exception: {0}.", exp.Message);
        }
    }
}
