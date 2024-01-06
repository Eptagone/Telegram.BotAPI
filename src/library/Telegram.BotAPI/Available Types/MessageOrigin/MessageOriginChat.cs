// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent on behalf of a chat to a group chat.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class MessageOriginChat : MessageOrigin
{
	/// <summary>
	/// Type of the message origin, always “chat”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>
	/// Chat that sent the message originally
	/// </summary>
	[JsonPropertyName(PropertyNames.SenderChat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat SenderChat { get; set; }
	/// <summary>
	/// Optional. For messages originally sent by an anonymous chat administrator, original message author signature
	/// </summary>
	[JsonPropertyName(PropertyNames.AuthorSignature)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? AuthorSignature { get; set; }
}
