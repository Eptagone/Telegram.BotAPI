﻿// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using IKB = Telegram.BotAPI.AvailableTypes.InlineKeyboardButton;

namespace TelegramCalendar;

public static class Calendar
{
    public static IKB[][] New(DateTime dateTime)
    {
        var year = dateTime.Year;
        var keyboard = new IKB[6][];
        keyboard[0] = [new IKB($"{year}") { CallbackData = $"Year {year}" }];
        for (int i = 1, n = 0; i < 5; i++)
        {
            keyboard[i] = new IKB[3];
            for (int j = 0; j < 3; j++, n++)
            {
                var month = (MonthName)n;
                keyboard[i][j] = new IKB($"{month}") { CallbackData = $"month {year} {n}" };
            }
        }
        keyboard[5] =
        [
            new IKB($"{year - 1}") { CallbackData = $"year {year - 1}" },
            new IKB($"{year + 1}") { CallbackData = $"year {year + 1}" },
        ];
        return keyboard;
    }

    public static IKB[][] New(Month mon)
    {
        var calendar = new IKB[mon.Weeks + 3][];
        var pos = 0;
        calendar[0] = [new IKB($"{mon.Name} {mon.Year}") { CallbackData = $"year {mon.Year}" }];
        var days = new[] { "Su", "Mo", "Tu", "We", "Th", "Fr", "Sa" };
        calendar[1] = new IKB[7];
        for (int i = 0; i < 7; i++)
        {
            calendar[1][i] = new IKB(days[i]) { CallbackData = $"{((DayOfWeek)i)}" };
        }
        for (int i = 2; i < mon.Weeks + 2; i++)
        {
            calendar[i] = new IKB[7];
            for (int j = 0; j < 7; j++)
            {
                if (pos < mon.Days.Length)
                {
                    if ((int)mon.Days[pos].Name == j)
                    {
                        calendar[i][j] = new IKB($"{mon.Days[pos].Number}")
                        {
                            CallbackData =
                                $"{mon.Days[pos].Name}, {mon.Name} {mon.Days[pos].Number}",
                        };
                        pos++;
                    }
                    else
                    {
                        calendar[i][j] = new IKB("*") { CallbackData = "Empty day" };
                    }
                }
                else
                {
                    calendar[i][j] = new IKB("*") { CallbackData = "Empty day" };
                }
            }
        }
        calendar[^1] = new IKB[2];
        var previousMonth = mon.Name == MonthName.January ? MonthName.December : mon.Name - 1;
        var nextMonth = mon.Name == MonthName.December ? MonthName.January : mon.Name + 1;
        var previousYear = previousMonth == MonthName.December ? mon.Year - 1 : mon.Year;
        var nextYear = nextMonth == MonthName.January ? mon.Year + 1 : mon.Year;
        calendar[^1][0] = new IKB($"{previousMonth}")
        {
            CallbackData = $"month {previousYear} {(ushort)previousMonth}",
        };
        calendar[^1][1] = new IKB($"{nextMonth}")
        {
            CallbackData = $"month {nextYear} {(ushort)nextMonth}",
        };
        return calendar;
    }

    public static IKB[][] New(uint year)
    {
        var keyboard = new IKB[6][];
        keyboard[0] = [new IKB($"{year}") { CallbackData = $"Year {year}" }];
        for (int i = 1, n = 0; i < 5; i++)
        {
            keyboard[i] = new IKB[3];
            for (int j = 0; j < 3; j++, n++)
            {
                var month = (MonthName)n;
                keyboard[i][j] = new IKB($"{month}") { CallbackData = $"month {year} {n}" };
            }
        }
        keyboard[5] =
        [
            new IKB($"{year - 1}") { CallbackData = $"year {year - 1}" },
            new IKB($"{year + 1}") { CallbackData = $"year {year + 1}" },
        ];
        return keyboard;
    }
}
