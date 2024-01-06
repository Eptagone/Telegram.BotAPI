// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a change of a reaction on a message performed by a user.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class MessageReactionUpdated
{
	/// <summary>
	/// The chat containing the message the user reacted to
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat Chat { get; set; }
	/// <summary>
	/// Unique identifier of the message inside the chat
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
	/// Previous list of reaction types that were set by the user
	/// </summary>
	[JsonPropertyName(PropertyNames.OldReaction)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<ReactionType> OldReaction { get; set; }
	/// <summary>
	/// New list of reaction types that have been set by the user
	/// </summary>
	[JsonPropertyName(PropertyNames.NewReaction)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<ReactionType> NewReaction { get; set; }
	/// <summary>
	/// Optional. The user that changed the reaction, if the user isn't anonymous
	/// </summary>
	[JsonPropertyName(PropertyNames.User)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User? User { get; set; }
	/// <summary>
	/// Optional. The chat on behalf of which the reaction was changed, if the user is anonymous
	/// </summary>
	[JsonPropertyName(PropertyNames.ActorChat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Chat? ActorChat { get; set; }
}
