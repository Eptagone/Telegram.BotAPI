// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Converters;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes the source of a chat boost. It can be one of
/// <list type="bullet">
/// <item><description><see cref="ChatBoostSourcePremium"/></description></item>
/// <item><description><see cref="ChatBoostSourceGiftCode"/></description></item>
/// <item><description><see cref="ChatBoostSourceGiveaway"/></description></item>
/// </list>
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
[System.Text.Json.Serialization.JsonConverter(typeof(ChatBoostSourceConverter))]
public abstract class ChatBoostSource
{
	/// <summary>
	/// Source of the boost
	/// </summary>
	[JsonPropertyName(PropertyNames.Source)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public abstract string Source { get; set; }
}
