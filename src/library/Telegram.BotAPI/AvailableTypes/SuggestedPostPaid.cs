// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a successful payment for a suggested post.
/// </summary>
public class SuggestedPostPaid
{
    /// <summary>
    /// Optional. Message containing the suggested post. Note that the <see cref="Message"/> object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedPostMessage)]
    public Message? SuggestedPostMessage { get; set; }

    /// <summary>
    /// Currency in which the payment was made. Currently, one of “XTR” for Telegram Stars or “TON” for toncoins
    /// </summary>
    [JsonPropertyName(PropertyNames.Currency)]
    public string Currency { get; set; } = null!;

    /// <summary>
    /// Optional. The amount of the currency that was received by the channel in nanotoncoins; for payments in toncoins only
    /// </summary>
    [JsonPropertyName(PropertyNames.Amount)]
    public int? Amount { get; set; }

    /// <summary>
    /// Optional. The amount of Telegram Stars that was received by the channel; for payments in Telegram Stars only
    /// </summary>
    [JsonPropertyName(PropertyNames.StarAmount)]
    public StarAmount? StarAmount { get; set; }
}
