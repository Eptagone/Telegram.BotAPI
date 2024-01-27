// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent by a known user.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class MessageOriginUser : MessageOrigin
{
	/// <summary>
	/// Type of the message origin, always “user”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>
	/// User that sent the message originally
	/// </summary>
	[JsonPropertyName(PropertyNames.SenderUser)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User SenderUser { get; set; }
}
