// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>
/// This object describes a message that was deleted or is otherwise inaccessible to the bot.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public class InaccessibleMessage : MaybeInaccessibleMessage
{
	/// <summary>
	/// Chat the message belonged to
	/// </summary>
	[JsonPropertyName(PropertyNames.Chat)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override Chat Chat { get; set; }
	/// <summary>
	/// Unique message identifier inside the chat
	/// </summary>
	[JsonPropertyName(PropertyNames.MessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override int MessageId { get; set; }
	/// <summary>
	/// Always 0. The field can be used to differentiate regular and inaccessible messages.
	/// </summary>
	[JsonPropertyName(PropertyNames.Date)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public override uint Date { get; set; }
}
