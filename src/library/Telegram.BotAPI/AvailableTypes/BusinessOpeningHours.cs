// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the opening hours of a business.
/// </summary>
public class BusinessOpeningHours
{
    /// <summary>
    /// Unique name of the time zone for which the opening hours are defined
    /// </summary>
    [JsonPropertyName(PropertyNames.TimeZoneName)]
    public string TimeZoneName { get; set; } = null!;

    /// <summary>
    /// List of time intervals describing business opening hours
    /// </summary>
    [JsonPropertyName(PropertyNames.OpeningHours)]
    public IEnumerable<BusinessOpeningHoursInterval> OpeningHours { get; set; } = null!;
}
