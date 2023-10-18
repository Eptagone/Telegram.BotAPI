// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents a forum topic.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ForumTopic
{
	/// <summary>
	/// Unique identifier of the forum topic
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageThreadId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int MessageThreadId { get; set; }
	/// <summary>
	/// Name of the topic
	/// </summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Name { get; set; }
	/// <summary>
	/// Color of the topic icon in RGB format
	/// </summary>
	[JsonPropertyName(PropertyNames.IconColor)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int IconColor { get; set; }
	/// <summary>
	/// Optional. Unique identifier of the custom emoji shown as the topic icon
	/// </summary>
	[JsonPropertyName(PropertyNames.IconCustomEmojiId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? IconCustomEmojiId { get; set; }
}
