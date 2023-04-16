// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents an incoming callback query from a callback button in an inline keyboard. If the button that originated the query was attached to a message sent by the bot, the field message will be present. If the button was attached to a message sent via the bot (in inline mode), the field inline_message_id will be present. Exactly one of the fields data or game_short_name will be present.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class CallbackQuery : IEquatable<CallbackQuery?>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="CallbackQuery"/> class.
	/// </summary>
	public CallbackQuery()
	{
		this.Id = null!;
		this.From = null!;
		this.ChatInstance = null!;
	}

	/// <summary>Unique identifier for this query.</summary>
	[JsonPropertyName(PropertyNames.Id)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Id { get; set; }
	/// <summary>Sender.</summary>
	[JsonPropertyName(PropertyNames.From)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User From { get; set; }
	/// <summary>Optional. Message with the callback button that originated the query. Note that message content and message date will not be available if the message is too old.</summary>
	[JsonPropertyName(PropertyNames.Message)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public Message? Message { get; set; }
	/// <summary>Optional. Identifier of the message sent via the bot in inline mode, that originated the query.</summary>
	[JsonPropertyName(PropertyNames.InlineMessageId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? InlineMessageId { get; set; }
	/// <summary>Global identifier, uniquely corresponding to the chat to which the message with the callback button was sent. Useful for high scores in games.</summary>
	[JsonPropertyName(PropertyNames.ChatInstance)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ChatInstance { get; set; }
	/// <summary>Optional. Data associated with the callback button. Be aware that a bad client can send arbitrary data in this field.</summary>
	[JsonPropertyName(PropertyNames.Data)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Data { get; set; }
	/// <summary>Optional. Short name of a Game to be returned, serves as the unique identifier for the game.</summary>
	[JsonPropertyName(PropertyNames.GameShortName)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? GameShortName { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object? obj)
	{
		return this.Equals(obj as CallbackQuery);
	}
	/// <inheritdoc/>
	public bool Equals(CallbackQuery? other)
	{
		return other is not null &&
			   this.Id == other.Id &&
			   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
			   EqualityComparer<Message?>.Default.Equals(this.Message, other.Message) &&
			   this.InlineMessageId == other.InlineMessageId &&
			   this.ChatInstance == other.ChatInstance &&
			   this.Data == other.Data &&
			   this.GameShortName == other.GameShortName;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = -1057610016;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
		hashCode = hashCode * -1521134295 + EqualityComparer<Message?>.Default.GetHashCode(this.Message);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.InlineMessageId);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ChatInstance);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Data);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.GameShortName);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(CallbackQuery? left, CallbackQuery? right)
	{
		return EqualityComparer<CallbackQuery>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(CallbackQuery? left, CallbackQuery? right)
	{
		return !(left == right);
	}

}
