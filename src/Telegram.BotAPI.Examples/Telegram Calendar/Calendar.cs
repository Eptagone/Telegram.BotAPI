using System;
using Telegram.BotAPI.AvailableTypes;

namespace TelegramCalendar
{
    public static class Calendar
    {
        public static InlineKeyboardButton[][] New(DateTime dateTime)
        {
            var year = dateTime.Year;
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
        public static InlineKeyboardButton[][] New(Month mon)
        {
            var calendar = new InlineKeyboardButton[mon.Weeks + 3][];
            var pos = 0;
            calendar[0] = new InlineKeyboardButton[1]
            {
                InlineKeyboardButton.SetCallbackData($"{mon.Name} {mon.Year}", $"year {mon.Year}")
            };
            var days = new[] { "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" };
            calendar[1] = new InlineKeyboardButton[7];
            for (int i = 0; i < 7; i++)
            {
                calendar[1][i] = InlineKeyboardButton.SetCallbackData(days[i], $"{((DayOfWeek)i)}");
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
        public static InlineKeyboardButton[][] New(uint year)
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
