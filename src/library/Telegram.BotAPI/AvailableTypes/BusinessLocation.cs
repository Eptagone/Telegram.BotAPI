// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Contains information about the location of a Telegram Business account.
/// </summary>
public class BusinessLocation
{
    /// <summary>
    /// Address of the business
    /// </summary>
    [JsonPropertyName(PropertyNames.Address)]
    public string Address { get; set; } = null!;

    /// <summary>
    /// Optional. Location of the business
    /// </summary>
    [JsonPropertyName(PropertyNames.Location)]
    public Location? Location { get; set; }
}
