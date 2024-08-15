// Copyright (c) 2024 Quetzal Rivera.
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
    /// Information about the user
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Optional. Bot-specified invoice payload
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string? InvoicePayload { get; set; }

    /// <summary>
    /// Optional. Information about the paid media bought by the user
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMedia)]
    public IEnumerable<PaidMedia>? PaidMedia { get; set; }
}
