// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes the affiliate program that issued the affiliate commission received via this transaction.
/// </summary>
public class TransactionPartnerAffiliateProgram : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “affiliate_program”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "affiliate_program";

    /// <summary>
    /// Optional. Information about the bot that sponsored the affiliate program
    /// </summary>
    [JsonPropertyName(PropertyNames.SponsorUser)]
    public User? SponsorUser { get; set; }

    /// <summary>
    /// The number of Telegram Stars received by the bot for each 1000 Telegram Stars received by the affiliate program sponsor from referred users
    /// </summary>
    [JsonPropertyName(PropertyNames.CommissionPerMille)]
    public int CommissionPerMille { get; set; }
}
