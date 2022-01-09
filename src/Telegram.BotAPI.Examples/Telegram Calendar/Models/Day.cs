using System;

namespace TelegramCalendar
{
    public sealed class Day
    {
        public Day(DayOfWeek name, ushort number)
        {
            Name = name; Number = number;
        }
        public DayOfWeek Name { get; set; }
        public ushort Number { get; set; }
    }
}
