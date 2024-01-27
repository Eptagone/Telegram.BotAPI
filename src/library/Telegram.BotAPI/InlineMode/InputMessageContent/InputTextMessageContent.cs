// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.InlineMode;

/// <summary>
/// Represents the content of a text message to be sent as the result of an inline query.
/// </summary>
/// <param name="messageText">Text of the message to be sent, 1-4096 characters.</param>
/// <exception cref="ArgumentNullException"></exception>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InputTextMessageContent(string messageText) : InputMessageContent
{
	/// <summary>
	/// Text of the message to be sent, 1-4096 characters
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageText)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string MessageText { get; set; } = messageText ?? throw new ArgumentNullException(nameof(messageText));
	/// <summary>
	/// Optional. Mode for parsing entities in the message text. See formatting options for more details.
	/// </summary>
	[JsonPropertyName(PropertyNames.ParseMode)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? ParseMode { get; set; }
	/// <summary>
	/// Optional. List of special entities that appear in message text, which can be specified instead of parse_mode
	/// </summary>
	[JsonPropertyName(PropertyNames.Entities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? Entities { get; set; }
	/// <summary>
	/// Optional. Link preview generation options for the message
	/// </summary>
	[JsonPropertyName(PropertyNames.LinkPreviewOptions)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public LinkPreviewOptions? LinkPreviewOptions { get; set; }
}
