// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents an incoming callback query from a callback button in an inline keyboard. If the button that originated the query was attached to a message sent by the bot, the field message will be present. If the button was attached to a message sent via the bot (in inline mode), the field inline_message_id will be present. Exactly one of the fields data or game_short_name will be present.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class CallbackQuery
{
	/// <summary>
	/// Unique identifier for this query
	/// </summary>
	[JsonPropertyName(PropertyNames.Id)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Id { get; set; }
	/// <summary>
	/// Sender
	/// </summary>
	[JsonPropertyName(PropertyNames.From)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User From { get; set; }
	/// <summary>
	/// Global identifier, uniquely corresponding to the chat to which the message with the callback button was sent. Useful for high scores in games.
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatInstance)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ChatInstance { get; set; }
	/// <summary>
	/// Optional. Message sent by the bot with the callback button that originated the query
	/// </summary>
	[JsonPropertyName(PropertyNames.Message)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public MaybeInaccessibleMessage? Message { get; set; }
	/// <summary>
	/// Optional. Identifier of the message sent via the bot in inline mode, that originated the query.
	/// </summary>
	[JsonPropertyName(PropertyNames.InlineMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? InlineMessageId { get; set; }
	/// <summary>
	/// Optional. Data associated with the callback button. Be aware that the message originated the query can contain no callback buttons with this data.
	/// </summary>
	[JsonPropertyName(PropertyNames.Data)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Data { get; set; }
	/// <summary>
	/// Optional. Short name of a Game to be returned, serves as the unique identifier for the game
	/// </summary>
	[JsonPropertyName(PropertyNames.GameShortName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? GameShortName { get; set; }
}
