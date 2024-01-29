// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object represents information about an order.
/// </summary>
public class OrderInfo
{
    /// <summary>
    /// <em>Optional</em>. User name
    /// </summary>
    [JsonPropertyName(PropertyNames.Name)]
    public string? Name { get; set; }

    /// <summary>
    /// <em>Optional</em>. User's phone number
    /// </summary>
    [JsonPropertyName(PropertyNames.PhoneNumber)]
    public string? PhoneNumber { get; set; }

    /// <summary>
    /// <em>Optional</em>. User email
    /// </summary>
    [JsonPropertyName(PropertyNames.Email)]
    public string? Email { get; set; }

    /// <summary>
    /// <em>Optional</em>. User shipping address
    /// </summary>
    [JsonPropertyName(PropertyNames.ShippingAddress)]
    public ShippingAddress? ShippingAddress { get; set; }
}
