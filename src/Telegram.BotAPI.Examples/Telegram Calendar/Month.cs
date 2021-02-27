namespace Telegram_Calendar
{
    public class Month
    {
        public Month(MonthName monthName, uint year)
        {
            Name = monthName;
            Year = year;
            var leapyear = Year % 4 == 0;
            var days = Name == MonthName.February ? (leapyear ? 29 : 28) : (Name == MonthName.April || Name == MonthName.June || Name == MonthName.September || Name == MonthName.November ? 30 : 31);
            Days = new Day[days];
            var firstday = year * 365 + (leapyear ? -1 : 0) + (((year - (year % 4)) / 4)) - (((year - (year % 400)) / 400)) + 3;
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
            firstday = firstday % 7;
            for (int i = 0; i < Days.Length; i++)
                Days[i] = new Day((DayName)((i + firstday) % 7), (ushort)(i + 1));
        }
        public uint Year { get; set; }
        public MonthName Name { get; set; }
        public Day[] Days { get; set; }
        public ushort Weeks
        {
            get
            {
                var days = (int)Days[0].Name + Days.Length - 1;
                return (ushort)(((days - (days % 7)) / 7) + (days % 7 > 0 ? 1 : 0));
            }
        }
    }
}
