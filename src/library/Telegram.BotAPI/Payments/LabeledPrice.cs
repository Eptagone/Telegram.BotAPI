// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object represents a portion of the price for goods or services.
/// </summary>
public class LabeledPrice
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LabeledPrice"/> class.
    /// </summary>
    /// <param name="label">Portion label</param>
    /// <param name="amount">Price of the product in the <em>smallest units</em> of the <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> (integer, <strong>not</strong> float/double). For example, for a price of <em>US$ 1.45</em> pass <em>amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</param>
    public LabeledPrice(string label, int amount)
    {
        this.Label = label ?? throw new ArgumentNullException(nameof(label));
        this.Amount = amount;
    }

    /// <summary>
    /// Portion label
    /// </summary>
    [JsonPropertyName(PropertyNames.Label)]
    public string Label { get; set; }

    /// <summary>
    /// Price of the product in the <em>smallest units</em> of the <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> (integer, <strong>not</strong> float/double). For example, for a price of <em>US$ 1.45</em> pass <em>amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public int Amount { get; set; }
}
