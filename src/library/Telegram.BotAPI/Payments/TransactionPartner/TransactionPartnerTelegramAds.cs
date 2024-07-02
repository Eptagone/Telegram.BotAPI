// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a withdrawal transaction to the Telegram Ads platform.
/// </summary>
public class TransactionPartnerTelegramAds : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “telegram_ads”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "telegram_ads";
}
