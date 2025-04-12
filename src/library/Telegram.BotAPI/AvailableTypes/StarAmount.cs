// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes an amount of Telegram Stars.
/// </summary>
public class StarAmount
{
    /// <summary>
    /// Integer amount of Telegram Stars, rounded to 0; can be negative
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public int Amount { get; set; }

    /// <summary>
    /// Optional. The number of 1/1000000000 shares of Telegram Stars; from -999999999 to 999999999; can be negative if and only if <em>amount</em> is non-positive
    /// </summary>
    [JsonPropertyName(PropertyNames.NanostarAmount)]
    public int? NanostarAmount { get; set; }
}
