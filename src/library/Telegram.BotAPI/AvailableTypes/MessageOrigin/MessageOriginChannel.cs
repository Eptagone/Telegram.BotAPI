// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// The message was originally sent to a channel chat.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class MessageOriginChannel : MessageOrigin
{
	/// <summary>
	/// Type of the message origin, always “channel”
	/// </summary>
	[JsonPropertyName(PropertyNames.Type)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override string Type { get; set; }
	/// <summary>
	/// Channel chat to which the message was originally sent
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat Chat { get; set; }
	/// <summary>
	/// Unique message identifier inside the chat
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int MessageId { get; set; }
	/// <summary>
	/// Optional. Signature of the original post author
	/// </summary>
	[JsonPropertyName(PropertyNames.AuthorSignature)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? AuthorSignature { get; set; }
}
