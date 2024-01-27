// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a message about the completion of a giveaway with public winners.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class GiveawayWinners
{
	/// <summary>
	/// The chat that created the giveaway
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat Chat { get; set; }
	/// <summary>
	/// Identifier of the messsage with the giveaway in the chat
	/// </summary>
	[JsonPropertyName(PropertyNames.GiveawayMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long GiveawayMessageId { get; set; }
	/// <summary>
	/// Point in time (Unix timestamp) when winners of the giveaway were selected
	/// </summary>
	[JsonPropertyName(PropertyNames.WinnersSelectionDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint WinnersSelectionDate { get; set; }
	/// <summary>
	/// Total number of winners in the giveaway
	/// </summary>
	[JsonPropertyName(PropertyNames.WinnerCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint WinnerCount { get; set; }
	/// <summary>
	/// List of up to 100 winners of the giveaway
	/// </summary>
	[JsonPropertyName(PropertyNames.Winners)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<User> Winners { get; set; }
	/// <summary>
	/// Optional. The number of other chats the user had to join in order to be eligible for the giveaway
	/// </summary>
	[JsonPropertyName(PropertyNames.AdditionalChatCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? AdditionalChatCount { get; set; }
	/// <summary>
	/// Optional. The number of months the Telegram Premium subscription won from the giveaway will be active for
	/// </summary>
	[JsonPropertyName(PropertyNames.PremiumSubscriptionMonthCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? PremiumSubscriptionMonthCount { get; set; }
	/// <summary>
	/// Optional. Number of undistributed prizes
	/// </summary>
	[JsonPropertyName(PropertyNames.UnclaimedPrizeCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? UnclaimedPrizeCount { get; set; }
	/// <summary>
	/// Optional. True, if only users who had joined the chats after the giveaway started were eligible to win
	/// </summary>
	[JsonPropertyName(PropertyNames.OnlyNewMembers)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? OnlyNewMembers { get; set; }
	/// <summary>
	/// Optional. True, if the giveaway was canceled because the payment for it was refunded
	/// </summary>
	[JsonPropertyName(PropertyNames.WasRefunded)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? WasRefunded { get; set; }
	/// <summary>
	/// Optional. Description of additional giveaway prize
	/// </summary>
	[JsonPropertyName(PropertyNames.PrizeDescription)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? PrizeDescription { get; set; }
}
