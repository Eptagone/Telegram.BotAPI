// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// Describes reply parameters for the message that is being sent.
/// </summary>
/// <param name="messageId">Identifier of the message that will be replied to in the current chat, or in the chat chat_id if it is specified</param>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class ReplyParameters(int messageId)
{
	/// <summary>
	/// Identifier of the message that will be replied to in the current chat, or in the chat chat_id if it is specified
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int MessageId { get; } = messageId;
	/// <summary>
	/// Optional. If the message to be replied to is from a different chat, unique identifier for the chat or username of the channel (in the format @channelusername)
	/// </summary>
	[JsonPropertyName(PropertyNames.ChatId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public object? ChatId { get; set; }
	/// <summary>
	/// Optional. Pass True if the message should be sent even if the specified message to be replied to is not found; can be used only for replies in the same chat and forum topic.
	/// </summary>
	[JsonPropertyName(PropertyNames.AllowSendingWithoutReply)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? AllowSendingWithoutReply { get; set; }
	/// <summary>
	/// Optional. Quoted part of the message to be replied to; 0-1024 characters after entities parsing. The quote must be an exact substring of the message to be replied to, including bold, italic, underline, strikethrough, spoiler, and custom_emoji entities. The message will fail to send if the quote isn't found in the original message.
	/// </summary>
	[JsonPropertyName(PropertyNames.Quote)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Quote { get; set; }
	/// <summary>
	/// Optional. Mode for parsing entities in the quote. See formatting options for more details.
	/// </summary>
	[JsonPropertyName(PropertyNames.QuoteParseMode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? QuoteParseMode { get; set; }
	/// <summary>
	/// Optional. A JSON-serialized list of special entities that appear in the quote. It can be specified instead of quote_parse_mode.
	/// </summary>
	[JsonPropertyName(PropertyNames.QuoteEntities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? QuoteEntities { get; set; }
	/// <summary>
	/// Optional. Position of the quote in the original message in UTF-16 code units
	/// </summary>
	[JsonPropertyName(PropertyNames.QuotePosition)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint? QuotePosition { get; set; }
}
