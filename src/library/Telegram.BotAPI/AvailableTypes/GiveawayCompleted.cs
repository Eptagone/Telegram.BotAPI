// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about the completion of a giveaway without public winners.
/// </summary>
public class GiveawayCompleted
{
    /// <summary>
    /// Number of winners in the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.WinnerCount)]
    public int WinnerCount { get; set; }

    /// <summary>
    /// Optional. Number of undistributed prizes
    /// </summary>
    [JsonPropertyName(PropertyNames.UnclaimedPrizeCount)]
    public int? UnclaimedPrizeCount { get; set; }

    /// <summary>
    /// Optional. Message with the giveaway that was completed, if it wasn't deleted
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayMessage)]
    public Message? GiveawayMessage { get; set; }
}
