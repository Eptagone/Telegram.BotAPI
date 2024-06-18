// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object describes the state of a revenue withdrawal operation. Currently, it can be one of
/// <list type="bullet">
/// <item><description><see cref="RevenueWithdrawalStatePending"/></description></item>
/// <item><description><see cref="RevenueWithdrawalStateSucceeded"/></description></item>
/// <item><description><see cref="RevenueWithdrawalStateFailed"/></description></item>
/// </list>
/// </summary>
[JsonConverter(typeof(RevenueWithdrawalStateConverter))]
public abstract class RevenueWithdrawalState
{
    /// <summary>
    /// Type of the state
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public abstract string Type { get; }
}
