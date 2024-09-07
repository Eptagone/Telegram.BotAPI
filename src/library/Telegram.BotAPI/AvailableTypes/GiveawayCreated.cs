// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about the creation of a scheduled giveaway.
/// </summary>
public class GiveawayCreated
{
    /// <summary>
    /// Optional. The number of Telegram Stars to be split between giveaway winners; for Telegram Star giveaways only
    /// </summary>
    [JsonPropertyName(PropertyNames.PrizeStarCount)]
    public int? PrizeStarCount { get; set; }
}
