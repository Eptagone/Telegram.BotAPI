// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a payment refund for a suggested post.
/// </summary>
public class SuggestedPostRefunded
{
    /// <summary>
    /// Optional. Message containing the suggested post. Note that the <see cref="Message"/> object in this field will not contain the <em>reply_to_message</em> field even if it itself is a reply.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedPostMessage)]
    public Message? SuggestedPostMessage { get; set; }

    /// <summary>
    /// Reason for the refund. Currently, one of “post_deleted” if the post was deleted within 24 hours of being posted or removed from scheduled messages without being posted, or “payment_refunded” if the payer refunded their payment.
    /// </summary>
    [JsonPropertyName(PropertyNames.Reason)]
    public string Reason { get; set; } = null!;
}
