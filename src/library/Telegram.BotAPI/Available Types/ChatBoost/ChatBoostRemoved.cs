// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a boost removed from a chat.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ChatBoostRemoved
{
	/// <summary>
	/// Chat which was boosted
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat Chat { get; set; }
	/// <summary>
	/// Unique identifier of the boost
	/// </summary>
	[JsonPropertyName(PropertyNames.BoostId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string BoostId { get; set; }
	/// <summary>
	/// Point in time (Unix timestamp) when the boost was removed
	/// </summary>
	[JsonPropertyName(PropertyNames.RemoveDate)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int RemoveDate { get; set; }
	/// <summary>
	/// Source of the removed boost
	/// </summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatBoostSource Source { get; set; }
}
