// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.AvailableTypes;

/// <summary>This object represents an animated emoji that displays a random value.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class Dice : IEquatable<Dice>
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Dice"/> class.
	/// </summary>
	public Dice()
	{
		this.Emoji = null!;
	}

	/// <summary>Emoji on which the dice throw animation is based.</summary>
	[JsonPropertyName(PropertyNames.Emoji)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Emoji { get; set; }
	/// <summary>Value of the dice, 1-6 for “🎲”, “🎯” and “🎳” base emoji, 1-5 for “🏀” and “⚽” base emoji, 1-64 for “🎰” base emoji.</summary>
	[JsonPropertyName(PropertyNames.Value)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ushort Value { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as Dice);
	}
	/// <inheritdoc/>
	public bool Equals(Dice? other)
	{
		return other != null &&
			   this.Emoji == other.Emoji &&
			   this.Value == other.Value;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1365940687;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Emoji);
		hashCode = hashCode * -1521134295 + this.Value.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(Dice? left, Dice? right)
	{
#pragma warning disable CS8604 // Possible null reference argument.
		return EqualityComparer<Dice>.Default.Equals(left!, right!);
#pragma warning restore CS8604 // Possible null reference argument.
	}
	/// <inheritdoc/>
	public static bool operator !=(Dice? left, Dice? right)
	{
		return !(left == right);
	}

}

/// <summary>Dice base emojis. Choose between different animations (dice, darts, basketball, football, bowling, slot machine) by specifying the emoji parameter in the method sendDice.</summary>
public sealed class DiceValue
{
	/// <summary>Dice: 🎲 1 - 6 </summary>
	public const string Dice = "🎲";
	/// <summary>Darts: 🎯 </summary>
	public const string Darts = "🎯";
	/// <summary>Basketball: 🏀 </summary>
	public const string Basketball = "🏀";
	/// <summary>Football: 🏀 </summary>
	public const string Football = "⚽";
	/// <summary>Bowling: 🎳 </summary>
	public const string Bowling = "🎳";
	/// <summary>Slot machine: 🏀 </summary>
	public const string SlotMachine = "🎰";
}
