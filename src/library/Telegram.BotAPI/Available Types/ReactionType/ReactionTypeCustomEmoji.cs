// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The reaction is based on a custom emoji.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ReactionTypeCustomEmoji : ReactionType
{
	/// <summary>
	/// Type of the reaction, always “custom_emoji”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>
	/// Custom emoji identifier
	/// </summary>
	[JsonPropertyName(PropertyNames.CustomEmoji)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string CustomEmoji { get; set; }
}
