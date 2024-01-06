// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object represents an inline button that switches the current user to inline mode in a chosen chat, with an optional default inline query.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class SwitchInlineQueryChosenChat
{
	/// <summary>
	/// Optional. The default inline query to be inserted in the input field. If left empty, only the bot's username will be inserted
	/// </summary>
	[JsonPropertyName(PropertyNames.Query)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Query { get; set; }
	/// <summary>
	/// Optional. True, if private chats with users can be chosen
	/// </summary>
	[JsonPropertyName(PropertyNames.AllowUserChats)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowUserChats { get; set; }
	/// <summary>
	/// Optional. True, if private chats with bots can be chosen
	/// </summary>
	[JsonPropertyName(PropertyNames.AllowBotChats)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowBotChats { get; set; }
	/// <summary>
	/// Optional. True, if group and supergroup chats can be chosen
	/// </summary>
	[JsonPropertyName(PropertyNames.AllowGroupChats)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowGroupChats { get; set; }
	/// <summary>
	/// Optional. True, if channel chats can be chosen
	/// </summary>
	[JsonPropertyName(PropertyNames.AllowChannelChats)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowChannelChats { get; set; }
}
