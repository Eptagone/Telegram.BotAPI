// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object contains information about an incoming shipping query.
/// </summary>
public class ShippingQuery
{
    /// <summary>
    /// Unique query identifier
    /// </summary>
    [JsonPropertyName(PropertyNames.Id)]
    public string Id { get; set; } = null!;

    /// <summary>
    /// User who sent the query
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Bot-specified invoice payload
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string InvoicePayload { get; set; } = null!;

    /// <summary>
    /// User specified shipping address
    /// </summary>
    [JsonPropertyName(PropertyNames.ShippingAddress)]
    public ShippingAddress ShippingAddress { get; set; } = null!;
}
