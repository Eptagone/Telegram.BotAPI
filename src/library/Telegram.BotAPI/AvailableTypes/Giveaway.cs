// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a message about a scheduled giveaway.
/// </summary>
public class Giveaway
{
    /// <summary>
    /// The list of chats which the user must join to participate in the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.Chats)]
    public IEnumerable<Chat> Chats { get; set; } = null!;

    /// <summary>
    /// Point in time (Unix timestamp) when winners of the giveaway will be selected
    /// </summary>
    [JsonPropertyName(PropertyNames.WinnersSelectionDate)]
    public int WinnersSelectionDate { get; set; }

    /// <summary>
    /// The number of users which are supposed to be selected as winners of the giveaway
    /// </summary>
    [JsonPropertyName(PropertyNames.WinnerCount)]
    public int WinnerCount { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if only users who join the chats after the giveaway started should be eligible to win
    /// </summary>
    [JsonPropertyName(PropertyNames.OnlyNewMembers)]
    public bool? OnlyNewMembers { get; set; }

    /// <summary>
    /// Optional. <em>True</em>, if the list of giveaway winners will be visible to everyone
    /// </summary>
    [JsonPropertyName(PropertyNames.HasPublicWinners)]
    public bool? HasPublicWinners { get; set; }

    /// <summary>
    /// Optional. Description of additional giveaway prize
    /// </summary>
    [JsonPropertyName(PropertyNames.PrizeDescription)]
    public string? PrizeDescription { get; set; }

    /// <summary>
    /// Optional. A list of two-letter <a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO 3166-1 alpha-2</a> country codes indicating the countries from which eligible users for the giveaway must come. If empty, then all users can participate in the giveaway. Users with a phone number that was bought on Fragment can always participate in giveaways.
    /// </summary>
    [JsonPropertyName(PropertyNames.CountryCodes)]
    public IEnumerable<string>? CountryCodes { get; set; }

    /// <summary>
    /// Optional. The number of months the Telegram Premium subscription won from the giveaway will be active for
    /// </summary>
    [JsonPropertyName(PropertyNames.PremiumSubscriptionMonthCount)]
    public int? PremiumSubscriptionMonthCount { get; set; }
}
