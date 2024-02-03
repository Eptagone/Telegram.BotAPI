// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;

namespace TelegramCalendar
{
    public sealed class Month
    {
        public Month(MonthName monthName, uint year)
        {
            this.Name = monthName;
            this.Year = year;
            var leapyear = this.Year % 4 == 0;
            var days =
                this.Name == MonthName.February
                    ? (leapyear ? 29 : 28)
                    : (
                        this.Name == MonthName.April
                        || this.Name == MonthName.June
                        || this.Name == MonthName.September
                        || this.Name == MonthName.November
                            ? 30
                            : 31
                    );
            this.Days = new Day[days];
            var firstday =
                year * 365
                + (leapyear ? -1 : 0)
                + ((year - (year % 4)) / 4)
                - ((year - (year % 400)) / 400)
                + 4;
            var month = (int)monthName;
            firstday += month < 1 ? 0 : 31;
            firstday += month < 2 ? 0 : (leapyear ? 29 : 28);
            firstday += month < 3 ? 0 : 31;
            firstday += month < 4 ? 0 : 30;
            firstday += month < 5 ? 0 : 31;
            firstday += month < 6 ? 0 : 30;
            firstday += month < 7 ? 0 : 31;
            firstday += month < 8 ? 0 : 31;
            firstday += month < 9 ? 0 : 30;
            firstday += month < 10 ? 0 : 31;
            firstday += month < 11 ? 0 : 30;
            firstday %= 7;
            for (int i = 0; i < this.Days.Length; i++)
                this.Days[i] = new Day((DayOfWeek)((i + firstday) % 7), (ushort)(i + 1));
        }

        public uint Year { get; set; }
        public MonthName Name { get; set; }
        public Day[] Days { get; set; }
        public ushort Weeks
        {
            get
            {
                var days = (int)this.Days[0].Name + this.Days.Length - 1;
                return (ushort)(((days - (days % 7)) / 7) + (days % 7 > 0 ? 1 : 0));
            }
        }
    }
}
