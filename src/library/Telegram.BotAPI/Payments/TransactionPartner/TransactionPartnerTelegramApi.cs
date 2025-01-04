// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a transaction with payment for <a href="https://core.telegram.org/bots/api#paid-broadcasts">paid broadcasting</a>.
/// </summary>
public class TransactionPartnerTelegramApi : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “telegram_api”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "telegram_api";

    /// <summary>
    /// The number of successful requests that exceeded regular limits and were therefore billed
    /// </summary>
    [JsonPropertyName(PropertyNames.RequestCount)]
    public int RequestCount { get; set; }
}
