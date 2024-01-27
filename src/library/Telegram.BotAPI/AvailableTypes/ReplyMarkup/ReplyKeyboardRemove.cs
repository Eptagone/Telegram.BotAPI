// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>Upon receiving a message with this object, Telegram clients will remove the current custom keyboard and display the default letter-keyboard. By default, custom keyboards are displayed until a new keyboard is sent by a bot. An exception is made for one-time keyboards that are hidden immediately after the user presses a button (see <see cref="ReplyKeyboardMarkup"/>).</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class ReplyKeyboardRemove : ReplyMarkup, IEquatable<ReplyKeyboardRemove>
{
	/// <summary>Requests clients to remove the custom keyboard (user will not be able to summon this keyboard; if you want to hide the keyboard from sight but keep it accessible, use one_time_keyboard in ReplyKeyboardMarkup).</summary>
	[JsonPropertyName(PropertyNames.RemoveKeyboard)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool RemoveKeyboard => true;
	/// <summary>Optional. Use this parameter if you want to remove the keyboard for specific users only. Targets: 1) users that are @mentioned in the text of the Message object; 2) if the bot's message is a reply (has reply_to_message_id), sender of the original message.<para>Example: A user votes in a poll, bot returns confirmation message in reply to the vote and removes the keyboard for that user, while still showing the keyboard with poll options to users who haven't voted yet.</para></summary>
	[JsonPropertyName(PropertyNames.Selective)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public bool Selective { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as ReplyKeyboardRemove);
	}
	/// <inheritdoc/>
	public bool Equals(ReplyKeyboardRemove? other)
	{
		return other != null &&
			   this.Selective == other.Selective;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return 1578763193 + this.Selective.GetHashCode();
	}
	/// <inheritdoc/>
	public static bool operator ==(ReplyKeyboardRemove? left, ReplyKeyboardRemove? right)
	{
		return EqualityComparer<ReplyKeyboardRemove>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(ReplyKeyboardRemove? left, ReplyKeyboardRemove? right)
	{
		return !(left == right);
	}

}
