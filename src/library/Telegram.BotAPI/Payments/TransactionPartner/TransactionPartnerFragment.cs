// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a withdrawal transaction with Fragment.
/// </summary>
public class TransactionPartnerFragment : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “fragment”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "fragment";

    /// <summary>
    /// Optional. State of the transaction if the transaction is outgoing
    /// </summary>
    [JsonPropertyName(PropertyNames.WithdrawalState)]
    public RevenueWithdrawalState? WithdrawalState { get; set; }
}
