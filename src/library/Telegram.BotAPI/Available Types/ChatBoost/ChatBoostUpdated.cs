// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a boost added to a chat or changed.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ChatBoostUpdated
{
	/// <summary>
	/// Chat which was boosted
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat Chat { get; set; }
	/// <summary>
	/// Infomation about the chat boost
	/// </summary>
	[JsonPropertyName(PropertyNames.Boost)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ChatBoost Boost { get; set; }
}
