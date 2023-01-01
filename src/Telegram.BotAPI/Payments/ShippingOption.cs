// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
	/// <summary>This object represents one shipping option.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ShippingOption : IEquatable<ShippingOption>
	{
		/// <summary>Shipping option identifier</summary>
		[JsonPropertyName(PropertyNames.Id)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Id { get; set; }
		/// <summary>Option title</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Title { get; set; }
		/// <summary>List of price portions</summary>
		[JsonPropertyName(PropertyNames.Prices)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<LabeledPrice> Prices { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ShippingOption);
		}
		/// <inheritdoc/>
		public bool Equals(ShippingOption? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   this.Title == other.Title &&
				   EqualityComparer<IEnumerable<LabeledPrice>>.Default.Equals(this.Prices, other.Prices);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = 46498380;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<LabeledPrice>>.Default.GetHashCode(this.Prices);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ShippingOption? left, ShippingOption? right)
		{
			return EqualityComparer<ShippingOption>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ShippingOption? left, ShippingOption? right)
		{
			return !(left == right);
		}

	}
}
