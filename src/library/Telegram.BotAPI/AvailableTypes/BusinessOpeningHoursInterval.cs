// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes an interval of time during which a business is open.
/// </summary>
public class BusinessOpeningHoursInterval
{
    /// <summary>
    /// The minute's sequence number in a week, starting on Monday, marking the start of the time interval during which the business is open; 0 - 7 * 24 * 60
    /// </summary>
    [JsonPropertyName(PropertyNames.OpeningMinute)]
    public int OpeningMinute { get; set; }

    /// <summary>
    /// The minute's sequence number in a week, starting on Monday, marking the end of the time interval during which the business is open; 0 - 8 * 24 * 60
    /// </summary>
    [JsonPropertyName(PropertyNames.ClosingMinute)]
    public int ClosingMinute { get; set; }
}
