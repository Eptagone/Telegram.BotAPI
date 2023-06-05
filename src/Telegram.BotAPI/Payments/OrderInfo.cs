// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// This object represents information about an order.
/// </summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class OrderInfo : IEquatable<OrderInfo>
{
	/// <summary>Optional. User name</summary>
	[JsonPropertyName(PropertyNames.Name)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Name { get; set; }
	/// <summary>Optional. User's phone number</summary>
	[JsonPropertyName(PropertyNames.PhoneNumber)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? PhoneNumber { get; set; }
	/// <summary>Optional. User email</summary>
	[JsonPropertyName(PropertyNames.Email)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string? Email { get; set; }
	/// <summary>Optional. User shipping address</summary>
	[JsonPropertyName(PropertyNames.ShippingAddress)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public ShippingAddress? ShippingAddress { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as OrderInfo);
	}
	/// <inheritdoc/>
	public bool Equals(OrderInfo? other)
	{
		return other != null &&
			   this.Name == other.Name &&
			   this.PhoneNumber == other.PhoneNumber &&
			   this.Email == other.Email &&
			   EqualityComparer<ShippingAddress?>.Default.Equals(this.ShippingAddress, other.ShippingAddress);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 814573844;
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Name);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.PhoneNumber);
		hashCode = hashCode * -1521134295 + EqualityComparer<string?>.Default.GetHashCode(this.Email);
		hashCode = hashCode * -1521134295 + EqualityComparer<ShippingAddress?>.Default.GetHashCode(this.ShippingAddress);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(OrderInfo? left, OrderInfo? right)
	{
		return EqualityComparer<OrderInfo>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(OrderInfo? left, OrderInfo? right)
	{
		return !(left == right);
	}

}
