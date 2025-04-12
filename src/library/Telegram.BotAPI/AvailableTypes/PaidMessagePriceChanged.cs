// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes a service message about a change in the price of paid messages within a chat.
/// </summary>
public class PaidMessagePriceChanged
{
    /// <summary>
    /// The new number of Telegram Stars that must be paid by non-administrator users of the supergroup chat for each sent message
    /// </summary>
    [JsonPropertyName(PropertyNames.PaidMessageStarCount)]
    public int PaidMessageStarCount { get; set; }
}
