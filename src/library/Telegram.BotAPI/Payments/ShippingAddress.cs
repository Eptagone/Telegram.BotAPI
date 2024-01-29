// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object represents a shipping address.
/// </summary>
public class ShippingAddress
{
    /// <summary>
    /// Two-letter <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a> country code
    /// </summary>
    [JsonPropertyName(PropertyNames.CountryCode)]
    public string CountryCode { get; set; } = null!;

    /// <summary>
    /// State, if applicable
    /// </summary>
    [JsonPropertyName(PropertyNames.State)]
    public string State { get; set; } = null!;

    /// <summary>
    /// City
    /// </summary>
    [JsonPropertyName(PropertyNames.City)]
    public string City { get; set; } = null!;

    /// <summary>
    /// First line for the address
    /// </summary>
    [JsonPropertyName(PropertyNames.StreetLine1)]
    public string StreetLine1 { get; set; } = null!;

    /// <summary>
    /// Second line for the address
    /// </summary>
    [JsonPropertyName(PropertyNames.StreetLine2)]
    public string StreetLine2 { get; set; } = null!;

    /// <summary>
    /// Address post code
    /// </summary>
    [JsonPropertyName(PropertyNames.PostCode)]
    public string PostCode { get; set; } = null!;
}
