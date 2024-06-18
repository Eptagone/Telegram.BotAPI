// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// The withdrawal succeeded.
/// </summary>
public class RevenueWithdrawalStateSucceeded : RevenueWithdrawalState
{
    /// <summary>
    /// Type of the state, always “succeeded”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "succeeded";

    /// <summary>
    /// Date the withdrawal was completed in Unix time
    /// </summary>
    [JsonPropertyName(PropertyNames.Date)]
    public int Date { get; set; }

    /// <summary>
    /// An HTTPS URL that can be used to see transaction details
    /// </summary>
    [JsonPropertyName(PropertyNames.Url)]
    public string Url { get; set; } = null!;
}
