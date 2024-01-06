// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object contains information about the quoted part of a message that is replied to by the given message.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class TextQuote
{
	/// <summary>
	/// Text of the quoted part of a message that is replied to by the given message
	/// </summary>
	[JsonPropertyName(PropertyNames.Text)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Text { get; set; }
	/// <summary>
	/// Approximate quote position in the original message in UTF-16 code units as specified by the sender
	/// </summary>
	[JsonPropertyName(PropertyNames.Position)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint Position { get; set; }
	/// <summary>
	/// Optional. Special entities that appear in the quote. Currently, only bold, italic, underline, strikethrough, spoiler, and custom_emoji entities are kept in quotes.
	/// </summary>
	[JsonPropertyName(PropertyNames.Entities)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<MessageEntity>? Entities { get; set; }
	/// <summary>
	/// Optional. True, if the quote was chosen manually by the message sender. Otherwise, the quote was added automatically by the server.
	/// </summary>
	[JsonPropertyName(PropertyNames.IsManual)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool? IsManual { get; set; }
}
