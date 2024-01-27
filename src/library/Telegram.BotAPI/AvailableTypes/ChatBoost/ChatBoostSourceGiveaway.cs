// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The boost was obtained by the creation of a Telegram Premium giveaway. This boosts the chat 4 times for the duration of the corresponding Telegram Premium subscription.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ChatBoostSourceGiveaway : ChatBoostSource
{
	/// <summary>
	/// Source of the boost, always “giveaway”
	/// </summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Source { get; set; }
	/// <summary>
	/// Identifier of a message in the chat with the giveaway; the message could have been deleted already. May be 0 if the message isn't sent yet.
	/// </summary>
	[JsonPropertyName(PropertyNames.GiveawayMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public long GiveawayMessageId { get; set; }
	/// <summary>
	/// Optional. User that won the prize in the giveaway if any
	/// </summary>
	[JsonPropertyName(PropertyNames.User)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User? User { get; set; }
	/// <summary>
	/// Optional. True, if the giveaway was completed, but there was no user to win the prize
	/// </summary>
	[JsonPropertyName(PropertyNames.IsUnclaimed)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsUnclaimed { get; set; }
}
