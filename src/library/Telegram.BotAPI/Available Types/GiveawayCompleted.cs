// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a service message about the completion of a giveaway without public winners.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class GiveawayCompleted
{
	/// <summary>
	/// Number of winners in the giveaway
	/// </summary>
	[JsonPropertyName(PropertyNames.WinnerCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint WinnerCount { get; set; }
	/// <summary>
	/// Optional. Number of undistributed prizes
	/// </summary>
	[JsonPropertyName(PropertyNames.UnclaimedPrizeCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? UnclaimedPrizeCount { get; set; }
	/// <summary>
	/// Optional. Message with the giveaway that was completed, if it wasn't deleted
	/// </summary>
	[JsonPropertyName(PropertyNames.GiveawayMessage)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? GiveawayMessage { get; set; }
}
