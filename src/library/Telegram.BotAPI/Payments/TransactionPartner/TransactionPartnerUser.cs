// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Stickers;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Describes a transaction with a user.
/// </summary>
public class TransactionPartnerUser : TransactionPartner
{
    /// <summary>
    /// Type of the transaction partner, always “user”
    /// </summary>
    [JsonPropertyName(PropertyNames.Type)]
    public override string Type => "user";

    /// <summary>
    /// Information about the user
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Optional. Information about the affiliate that received a commission via this transaction
    /// </summary>
    [JsonPropertyName(PropertyNames.Affiliate)]
    public AffiliateInfo? Affiliate { get; set; }

    /// <summary>
    /// Optional. Bot-specified invoice payload
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string? InvoicePayload { get; set; }

    /// <summary>
    /// Optional. The duration of the paid subscription
    /// </summary>
    [JsonPropertyName(PropertyNames.SubscriptionPeriod)]
    public int? SubscriptionPeriod { get; set; }

    /// <summary>
    /// Optional. Information about the paid media bought by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMedia)]
    public IEnumerable<PaidMedia>? PaidMedia { get; set; }

    /// <summary>
    /// Optional. Bot-specified paid media payload
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMediaPayload)]
    public string? PaidMediaPayload { get; set; }

    /// <summary>
    /// Optional. The gift sent to the user by the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public Gift? Gift { get; set; }
}
