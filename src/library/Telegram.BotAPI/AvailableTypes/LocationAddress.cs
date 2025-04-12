// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes the physical address of a location.
/// </summary>
public class LocationAddress
{
    /// <summary>
    /// The two-letter ISO 3166-1 alpha-2 country code of the country where the location is located
    /// </summary>
    [JsonPropertyName(PropertyNames.CountryCode)]
    public string CountryCode { get; set; } = null!;

    /// <summary>
    /// Optional. State of the location
    /// </summary>
    [JsonPropertyName(PropertyNames.State)]
    public string? State { get; set; }

    /// <summary>
    /// Optional. City of the location
    /// </summary>
    [JsonPropertyName(PropertyNames.City)]
    public string? City { get; set; }

    /// <summary>
    /// Optional. Street address of the location
    /// </summary>
    [JsonPropertyName(PropertyNames.Street)]
    public string? Street { get; set; }
}
