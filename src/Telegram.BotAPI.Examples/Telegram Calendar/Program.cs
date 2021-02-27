// By Quetzal Rivera

using System;
using System.Linq;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Telegram.BotAPI.UpdatingMessages;

namespace Telegram_Calendar
{
    class Program
    {
        private static BotClient bot = new BotClient("<your bot token>");
        static void Main()
        {
            Console.WriteLine("Start!");
            bot.SetMyCommands(new BotCommand("calendar", "Telegram Calendar"));
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
                                OnMessage(update.Message);
                                break;
                            case UpdateType.CallbackQuery:
                                OnCallbackQuery(update.CallbackQuery);
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
        private static void OnMessage(Message message)
        {
            if (message.Text.Contains("/calendar"))
            {
                var rm = new InlineKeyboardMarkup
                {
                    InlineKeyboard = CreateCalendar(2021)
                };
                bot.SendMessage(message.Chat.Id, "🗓 <b>Telegram Bot Calendar</b> 🗓", parseMode: ParseMode.HTML, replyMarkup: rm);
            }
        }
        private static void OnCallbackQuery(CallbackQuery query)
        {
            var cbargs = query.Data.Split(' ');
            switch (cbargs[0])
            {
                case "month":
                    var month = new Month((MonthName)Enum.Parse(typeof(MonthName), cbargs[2]), uint.Parse(cbargs[1]));
                    var mkeyboard = new InlineKeyboardMarkup
                    {
                        InlineKeyboard = CreateCalendar(month)
                    };
                    bot.EditMessageReplyMarkup<Message>(new EditMessageReplyMarkup
                    {
                        ChatId = query.Message.Chat.Id,
                        MessageId = query.Message.MessageId,
                        ReplyMarkup = mkeyboard
                    });
                    break;
                case "year":
                    var ykeyboard = new InlineKeyboardMarkup
                    {
                        InlineKeyboard = CreateCalendar(uint.Parse(cbargs[1]))
                    };
                    bot.EditMessageReplyMarkup<Message>(new EditMessageReplyMarkup
                    {
                        ChatId = query.Message.Chat.Id,
                        MessageId = query.Message.MessageId,
                        ReplyMarkup = ykeyboard
                    });
                    break;
                default:
                    bot.AnswerCallbackQuery(new AnswerCallbackQueryArgs
                    {
                        CallbackQueryId = query.Id,
                        Text = query.Data,
                        ShowAlert = true
                    });
                    break;
            }

        }
        public static InlineKeyboardButton[][] CreateCalendar(Month mon)
        {
            var calendar = new InlineKeyboardButton[mon.Weeks + 3][];
            var pos = 0;
            calendar[0] = new InlineKeyboardButton[1]
            {
                InlineKeyboardButton.SetCallbackData($"{mon.Name} {mon.Year}", $"year {mon.Year}")
            };
            var days = new[] { "Mo", "Tu", "We", "Th", "Fr", "Sa", "Su" };
            calendar[1] = new InlineKeyboardButton[7];
            for (int i = 0; i < 7; i++)
            {
                calendar[1][i] = InlineKeyboardButton.SetCallbackData(days[i], $"{((DayName)i)}");
            }
            for (int i = 2; i < mon.Weeks + 2; i++)
            {
                calendar[i] = new InlineKeyboardButton[7];
                for (int j = 0; j < 7; j++)
                {
                    if (pos < mon.Days.Length)
                    {
                        if ((int)mon.Days[pos].Name == j)
                        {
                            calendar[i][j] = InlineKeyboardButton.SetCallbackData($"{mon.Days[pos].Number}", $"{mon.Days[pos].Name}, {mon.Name} {mon.Days[pos].Number}");
                            pos++;
                        }
                        else
                        {
                            calendar[i][j] = InlineKeyboardButton.SetCallbackData("*", "Empty day");
                        }
                    }
                    else
                    {
                        calendar[i][j] = InlineKeyboardButton.SetCallbackData("*", "Empty day");
                    }
                }
            }
            calendar[calendar.Length - 1] = new InlineKeyboardButton[2];
            var previousmonth = mon.Name == MonthName.January ? MonthName.December : mon.Name - 1;
            var nextmonth = mon.Name == MonthName.December ? MonthName.January : mon.Name + 1;
            var previousyear = previousmonth == MonthName.December ? mon.Year - 1 : mon.Year;
            var nextyear = nextmonth == MonthName.January ? mon.Year + 1 : mon.Year;
            calendar[calendar.Length - 1][0] = InlineKeyboardButton.SetCallbackData($"{previousmonth}", $"month {previousyear} {((ushort)previousmonth)}");
            calendar[calendar.Length - 1][1] = InlineKeyboardButton.SetCallbackData($"{nextmonth}", $"month {nextyear} {((ushort)nextmonth)}");
            return calendar;
        }
        public static InlineKeyboardButton[][] CreateCalendar(uint year)
        {
            var keyboard = new InlineKeyboardButton[6][];
            keyboard[0] = new InlineKeyboardButton[1]{
                InlineKeyboardButton.SetCallbackData($"{year}", $"Year {year}")
            };
            for (int i = 1, n = 0; i < 5; i++)
            {
                keyboard[i] = new InlineKeyboardButton[3];
                for (int j = 0; j < 3; j++, n++)
                {
                    var month = (MonthName)n;
                    keyboard[i][j] = new InlineKeyboardButton
                    {
                        Text = $"{month}",
                        CallbackData = $"month {year} {n}"
                    };
                }
            }
            keyboard[5] = new InlineKeyboardButton[2]{
                InlineKeyboardButton.SetCallbackData($"{year - 1}",$"year {year - 1}"),
                InlineKeyboardButton.SetCallbackData($"{year + 1}",$"year {year + 1}")
            };
            return keyboard;
        }
    }
}
