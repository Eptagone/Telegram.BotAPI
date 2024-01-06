// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent by an unknown user.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class MessageOriginHiddenUser : MessageOrigin
{
	/// <summary>
	/// Type of the message origin, always “hidden_user”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>
	/// Name of the user that sent the message originally
	/// </summary>
	[JsonPropertyName(PropertyNames.SenderUserName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string SenderUserName { get; set; }
}
