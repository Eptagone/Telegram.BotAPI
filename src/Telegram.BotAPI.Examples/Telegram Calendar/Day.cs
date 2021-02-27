namespace Telegram_Calendar
{
    public class Day
    {
        public Day(DayName name, ushort number)
        {
            Name = name; Number = number;
        }
        public DayName Name { get; set; }
        public ushort Number { get; set; }
    }
}
