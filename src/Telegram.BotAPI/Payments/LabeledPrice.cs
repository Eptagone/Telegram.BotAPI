// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Payments;

/// <summary>This object represents a portion of the price for goods or services.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class LabeledPrice : IEquatable<LabeledPrice>
{
	/// <summary>
	/// Initialize a new instance of <see cref="LabeledPrice"/>.
	/// </summary>
	/// <param name="label">Portion label.</param>
	/// <param name="amount">Price of the product in the smallest units of the <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</param>
	/// <exception cref="ArgumentNullException"></exception>
	public LabeledPrice(string label, int amount)
	{
		this.Label = label ?? throw new ArgumentNullException(nameof(label));
		this.Amount = amount;
	}

	/// <summary>Portion label.</summary>
	[JsonPropertyName(PropertyNames.Label)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Label { get; }
	/// <summary>Price of the product in the smallest units of the <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the exp parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
	[JsonPropertyName(PropertyNames.Amount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public int Amount { get; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as LabeledPrice);
	}
	/// <inheritdoc/>
	public bool Equals(LabeledPrice? other)
	{
		return other != null &&
			   this.Label == other.Label &&
			   this.Amount == other.Amount;
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 1590595470;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Label);
		hashCode = hashCode * -1521134295 + this.Amount.GetHashCode();
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(LabeledPrice? left, LabeledPrice? right)
	{
		return EqualityComparer<LabeledPrice>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(LabeledPrice? left, LabeledPrice? right)
	{
		return !(left == right);
	}

}
