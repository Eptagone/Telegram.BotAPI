// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about a chat boost.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ChatBoost
{
	/// <summary>
	/// Unique identifier of the boost
	/// </summary>
	[JsonPropertyName(PropertyNames.BoostId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string BoostId { get; set; }
	/// <summary>
	/// Point in time (Unix timestamp) when the chat was boosted
	/// </summary>
	[JsonPropertyName(PropertyNames.AddDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint AddDate { get; set; }
	/// <summary>
	/// Point in time (Unix timestamp) when the boost will automatically expire, unless the booster's Telegram Premium subscription is prolonged
	/// </summary>
	[JsonPropertyName(PropertyNames.ExpirationDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint ExpirationDate { get; set; }
	/// <summary>
	/// Source of the added boost
	/// </summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatBoostSource Source { get; set; }
}
