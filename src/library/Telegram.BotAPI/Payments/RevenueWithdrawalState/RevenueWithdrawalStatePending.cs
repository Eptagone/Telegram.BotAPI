// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// The withdrawal is in progress.
/// </summary>
public class RevenueWithdrawalStatePending : RevenueWithdrawalState
{
    /// <summary>
    /// Type of the state, always “pending”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "pending";
}
