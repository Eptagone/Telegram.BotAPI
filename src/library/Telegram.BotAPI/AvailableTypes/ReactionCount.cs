// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Represents a reaction added to a message along with the number of times it was added.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ReactionCount
{
	/// <summary>
	/// Type of the reaction
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ReactionType Type { get; set; }
	/// <summary>
	/// Number of times the reaction was added
	/// </summary>
	[JsonPropertyName(PropertyNames.TotalCount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint TotalCount { get; set; }
}
