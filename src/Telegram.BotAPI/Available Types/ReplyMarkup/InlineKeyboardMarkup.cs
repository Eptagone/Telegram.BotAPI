// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class InlineKeyboardMarkup : ReplyMarkup, IEquatable<InlineKeyboardMarkup>
{
	/// <summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
	public InlineKeyboardMarkup() { }
	/// <summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
	///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
	public InlineKeyboardMarkup(params IEnumerable<InlineKeyboardButton>[] inlineKeyboard)
	{
		this.InlineKeyboard = inlineKeyboard;
	}
	/// <summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
	///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
	public InlineKeyboardMarkup(params InlineKeyboardButton[][] inlineKeyboard)
	{
		this.InlineKeyboard = inlineKeyboard;
	}
	/// <summary>This object represents an inline keyboard that appears right next to the message it belongs to.</summary>
	///<param name="inlineKeyboard">Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</param>
	public InlineKeyboardMarkup(IEnumerable<IEnumerable<InlineKeyboardButton>> inlineKeyboard)
	{
		this.InlineKeyboard = inlineKeyboard;
	}

	/// <summary>Array of button rows, each represented by an Array of <see cref="InlineKeyboardButton"/> objects.</summary>
	[JsonPropertyName(PropertyNames.InlineKeyboard)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public IEnumerable<IEnumerable<InlineKeyboardButton>> InlineKeyboard { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as InlineKeyboardMarkup);
	}
	/// <inheritdoc/>
	public bool Equals(InlineKeyboardMarkup? other)
	{
		return other != null && EqualityComparer<IEnumerable<IEnumerable<InlineKeyboardButton>>>.Default.Equals(this.InlineKeyboard, other.InlineKeyboard);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		return 1862756913 + EqualityComparer<IEnumerable<IEnumerable<InlineKeyboardButton>>>.Default.GetHashCode(this.InlineKeyboard);
	}
	/// <inheritdoc/>
	public static bool operator ==(InlineKeyboardMarkup? left, InlineKeyboardMarkup? right)
	{
		return EqualityComparer<InlineKeyboardMarkup>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(InlineKeyboardMarkup? left, InlineKeyboardMarkup? right)
	{
		return !(left == right);
	}

}
