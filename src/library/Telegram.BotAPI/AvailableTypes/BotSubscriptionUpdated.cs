// Copyright (c) 2026 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about changes to a user payment subscription toward the current bot.
/// </summary>
public class BotSubscriptionUpdated
{
    /// <summary>
    /// User who subscribed for payments toward the bot
    /// </summary>
    [JsonPropertyName(PropertyNames.User)]
    public User User { get; set; } = null!;

    /// <summary>
    /// Bot-specified invoice payload
    /// </summary>
    [JsonPropertyName(PropertyNames.InvoicePayload)]
    public string InvoicePayload { get; set; } = null!;

    /// <summary>
    /// The new state of the subscription. Currently, it can be one of “canceled” if the user canceled the subscription, “active” if the user re-enabled a previously canceled subscription, or “failed” if payment for the subscription failed.
    /// </summary>
    [JsonPropertyName(PropertyNames.State)]
    public string State { get; set; } = null!;
}
