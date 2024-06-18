// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a Telegram Star transaction.
/// </summary>
public class StarTransaction
{
    /// <summary>
    /// Unique identifier of the transaction. Coincides with the identifer of the original transaction for refund transactions. Coincides with <em>SuccessfulPayment.telegram_payment_charge_id</em> for successful incoming payments from users.
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// Number of Telegram Stars transferred by the transaction
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public int Amount { get; set; }

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
