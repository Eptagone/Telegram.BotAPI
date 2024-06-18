// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a transaction with an unknown source or recipient.
/// </summary>
public class TransactionPartnerOther : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “other”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "other";
}
