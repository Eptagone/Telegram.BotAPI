// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The boost was obtained by subscribing to Telegram Premium or by gifting a Telegram Premium subscription to another user.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ChatBoostSourcePremium : ChatBoostSource
{
	/// <summary>
	/// Source of the boost, always “premium”
	/// </summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Source { get; set; }
	/// <summary>
	/// User that boosted the chat
	/// </summary>
	[JsonPropertyName(PropertyNames.User)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User User { get; set; }
}
