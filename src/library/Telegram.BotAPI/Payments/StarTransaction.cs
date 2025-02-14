// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a Telegram Star transaction. Note that if the buyer initiates a chargeback with the payment provider from whom they acquired Stars (e.g., Apple, Google) following this transaction, the refunded Stars will be deducted from the bot's balance. This is outside of Telegram's control.
/// </summary>
public class StarTransaction
{
    /// <summary>
    /// Unique identifier of the transaction. Coincides with the identifier of the original transaction for refund transactions. Coincides with <em>SuccessfulPayment.telegram_payment_charge_id</em> for successful incoming payments from users.
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Integer amount of Telegram Stars transferred by the transaction
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public int Amount { get; set; }

    /// <summary>
    /// Optional. The number of 1/1000000000 shares of Telegram Stars transferred by the transaction; from 0 to 999999999
    /// </summary>
    [JsonPropertyName(PropertyNames.NanostarAmount)]
    public int? NanostarAmount { get; set; }

    /// <summary>
    /// Date the transaction was created in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// Optional. Source of an incoming transaction (e.g., a user purchasing goods or services, Fragment refunding a failed withdrawal). Only for incoming transactions
    /// </summary>
    [JsonPropertyName(PropertyNames.Source)]
    public TransactionPartner? Source { get; set; }

    /// <summary>
    /// Optional. Receiver of an outgoing transaction (e.g., a user for a purchase refund, Fragment for a withdrawal). Only for outgoing transactions
    /// </summary>
    [JsonPropertyName(PropertyNames.Receiver)]
    public TransactionPartner? Receiver { get; set; }
}
