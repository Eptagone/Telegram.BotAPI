// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;

namespace TelegramCalendar
{
    public sealed class Day
    {
        public Day(DayOfWeek name, ushort number)
        {
            this.Name = name;
            this.Number = number;
        }

        public DayOfWeek Name { get; set; }
        public ushort Number { get; set; }
    }
}
