// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents reaction changes on a message with anonymous reactions.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class MessageReactionCountUpdated
{
	/// <summary>
	/// The chat containing the message
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
	/// Date of the change in Unix time
	/// </summary>
	[JsonPropertyName(PropertyNames.Date)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint Date { get; set; }
	/// <summary>
	/// List of reactions that are present on the message
	/// </summary>
	[JsonPropertyName(PropertyNames.Reactions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<ReactionCount> Reactions { get; set; }
}
