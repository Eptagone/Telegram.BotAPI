using System;

namespace Telegram_Calendar
{
    public class Day
    {
        public Day(DayOfWeek name, ushort number)
        {
            Name = name; Number = number;
        }
        public DayOfWeek Name { get; set; }
        public ushort Number { get; set; }
    }
}
