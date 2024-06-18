// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Contains a list of Telegram Star transactions.
/// </summary>
public class StarTransactions
{
    /// <summary>
    /// The list of transactions
    /// </summary>
    [JsonPropertyName(PropertyNames.Transactions)]
    public IEnumerable<StarTransaction> Transactions { get; set; } = null!;
}
