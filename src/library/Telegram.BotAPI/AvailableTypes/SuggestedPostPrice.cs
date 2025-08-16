// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Desribes price of a suggested post.
/// </summary>
public class SuggestedPostPrice
{
    /// <summary>
    /// Currency in which the post will be paid. Currently, must be one of “XTR” for Telegram Stars or “TON” for toncoins
    /// </summary>
    [JsonPropertyName(PropertyNames.Currency)]
    public string Currency { get; set; } = null!;

    /// <summary>
    /// The amount of the currency that will be paid for the post in the <em>smallest units</em> of the currency, i.e. Telegram Stars or nanotoncoins. Currently, price in Telegram Stars must be between 5 and 100000, and price in nanotoncoins must be between 10000000 and 10000000000000.
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public int Amount { get; set; }
}
