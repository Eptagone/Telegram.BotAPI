// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a message about the completion of a giveaway with public winners.
/// </summary>
public class GiveawayWinners
{
    /// <summary>
    /// The chat that created the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.Chat)]
    public Chat Chat { get; set; } = null!;

    /// <summary>
    /// Identifier of the message with the giveaway in the chat
    /// </summary>
    [JsonPropertyName(PropertyNames.GiveawayMessageId)]
    public int GiveawayMessageId { get; set; }

    /// <summary>
    /// Point in time (Unix timestamp) when winners of the giveaway were selected
    /// </summary>
    [JsonPropertyName(PropertyNames.WinnersSelectionDate)]
    public int WinnersSelectionDate { get; set; }

    /// <summary>
    /// Total number of winners in the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.WinnerCount)]
    public int WinnerCount { get; set; }

    /// <summary>
    /// List of up to 100 winners of the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.Winners)]
    public IEnumerable<User> Winners { get; set; } = null!;

    /// <summary>
    /// Optional. The number of other chats the user had to join in order to be eligible for the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.AdditionalChatCount)]
    public int? AdditionalChatCount { get; set; }

    /// <summary>
    /// Optional. The number of months the Telegram Premium subscription won from the giveaway will be active for
    /// </summary>
    [JsonPropertyName(PropertyNames.PremiumSubscriptionMonthCount)]
    public int? PremiumSubscriptionMonthCount { get; set; }

    /// <summary>
    /// Optional. Number of undistributed prizes
    /// </summary>
    [JsonPropertyName(PropertyNames.UnclaimedPrizeCount)]
    public int? UnclaimedPrizeCount { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if only users who had joined the chats after the giveaway started were eligible to win
    /// </summary>
    [JsonPropertyName(PropertyNames.OnlyNewMembers)]
    public bool? OnlyNewMembers { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the giveaway was canceled because the payment for it was refunded
    /// </summary>
    [JsonPropertyName(PropertyNames.WasRefunded)]
    public bool? WasRefunded { get; set; }

    /// <summary>
    /// Optional. Description of additional giveaway prize
    /// </summary>
    [JsonPropertyName(PropertyNames.PrizeDescription)]
    public string? PrizeDescription { get; set; }
}
