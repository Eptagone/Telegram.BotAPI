// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Payments
{
	/// <summary>This object represents a shipping address.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ShippingAddress : IEquatable<ShippingAddress>
	{
		/// <summary>ISO 3166-1 alpha-2 country code</summary>
		[JsonPropertyName(PropertyNames.CountryCode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string CountryCode { get; set; }
		/// <summary>State, if applicable</summary>
		[JsonPropertyName(PropertyNames.State)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string State { get; set; }
		/// <summary>City</summary>
		[JsonPropertyName(PropertyNames.City)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string City { get; set; }
		/// <summary>First line for the address</summary>
		[JsonPropertyName(PropertyNames.StreetLine1)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string StreetLine1 { get; set; }
		/// <summary>Second line for the address</summary>
		[JsonPropertyName(PropertyNames.StreetLine2)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string StreetLine2 { get; set; }
		/// <summary>Address post code</summary>
		[JsonPropertyName(PropertyNames.PostCode)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string PostCode { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ShippingAddress);
		}
		/// <inheritdoc/>
		public bool Equals(ShippingAddress? other)
		{
			return other != null &&
				   this.CountryCode == other.CountryCode &&
				   this.State == other.State &&
				   this.City == other.City &&
				   this.StreetLine1 == other.StreetLine1 &&
				   this.StreetLine2 == other.StreetLine2 &&
				   this.PostCode == other.PostCode;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -702260041;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.CountryCode);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.State);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.City);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.StreetLine1);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.StreetLine2);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PostCode);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ShippingAddress? left, ShippingAddress? right)
		{
			return EqualityComparer<ShippingAddress>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ShippingAddress? left, ShippingAddress? right)
		{
			return !(left == right);
		}

	}
}
