// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

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
    /// Type of the transaction, currently one of “invoice_payment” for payments via invoices, “paid_media_payment” for payments for paid media, “gift_purchase” for gifts sent by the bot, “premium_purchase” for Telegram Premium subscriptions gifted by the bot, “business_account_transfer” for direct transfers from managed business accounts
    /// </summary>
    [JsonPropertyName(PropertyNames.TransactionType)]
    public string TransactionType { get; set; } = null!;

    /// <summary>
    /// Information about the user
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Optional. Information about the affiliate that received a commission via this transaction. Can be available only for “invoice_payment” and “paid_media_payment” transactions.
    /// </summary>
    [JsonPropertyName(PropertyNames.Affiliate)]
    public AffiliateInfo? Affiliate { get; set; }

    /// <summary>
    /// Optional. Bot-specified invoice payload. Can be available only for “invoice_payment” transactions.
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string? InvoicePayload { get; set; }

    /// <summary>
    /// Optional. The duration of the paid subscription. Can be available only for “invoice_payment” transactions.
    /// </summary>
    [JsonPropertyName(PropertyNames.SubscriptionPeriod)]
    public int? SubscriptionPeriod { get; set; }

    /// <summary>
    /// Optional. Information about the paid media bought by the user; for “paid_media_payment” transactions only
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMedia)]
    public IEnumerable<PaidMedia>? PaidMedia { get; set; }

    /// <summary>
    /// Optional. Bot-specified paid media payload. Can be available only for “paid_media_payment” transactions.
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMediaPayload)]
    public string? PaidMediaPayload { get; set; }

    /// <summary>
    /// Optional. The gift sent to the user by the bot; for “gift_purchase” transactions only
    /// </summary>
    [JsonPropertyName(PropertyNames.Gift)]
    public Gift? Gift { get; set; }

    /// <summary>
    /// Optional. Number of months the gifted Telegram Premium subscription will be active for; for “premium_purchase” transactions only
    /// </summary>
    [JsonPropertyName(PropertyNames.PremiumSubscriptionDuration)]
    public int? PremiumSubscriptionDuration { get; set; }
}
