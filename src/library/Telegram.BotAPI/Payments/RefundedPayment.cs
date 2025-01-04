// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object contains basic information about a refunded payment.
/// </summary>
public class RefundedPayment
{
    /// <summary>
    /// Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code, or “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>. Currently, always “XTR”
    /// </summary>
    [JsonPropertyName(PropertyNames.Currency)]
    public string Currency => "XTR";

    /// <summary>
    /// Total refunded price in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). For example, for a price of <em>US$ 1.45</em>, <em>total_amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).
    /// </summary>
    [JsonPropertyName(PropertyNames.TotalAmount)]
    public int TotalAmount { get; set; }

    /// <summary>
    /// Bot-specified invoice payload
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string InvoicePayload { get; set; } = null!;

    /// <summary>
    /// Telegram payment identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.TelegramPaymentChargeId)]
    public string TelegramPaymentChargeId { get; set; } = null!;

    /// <summary>
    /// Optional. Provider payment identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.ProviderPaymentChargeId)]
    public string? ProviderPaymentChargeId { get; set; }
}
