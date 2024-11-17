// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;

namespace TelegramCalendar;

public sealed class Day(DayOfWeek name, ushort number)
{
    public DayOfWeek Name { get; set; } = name;
    public ushort Number { get; set; } = number;
}
