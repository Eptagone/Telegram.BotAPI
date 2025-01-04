// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object contains information about a paid media purchase.
/// </summary>
public class PaidMediaPurchased
{
    /// <summary>
    /// User who purchased the media
    /// </summary>
    [JsonPropertyName(PropertyNames.From)]
    public User From { get; set; } = null!;

    /// <summary>
    /// Bot-specified paid media payload
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMediaPayload)]
    public string PaidMediaPayload { get; set; } = null!;
}
