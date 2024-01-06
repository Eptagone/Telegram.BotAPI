// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>This object contains information about an incoming pre-checkout query.</summary>
[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
public sealed class PreCheckoutQuery : IEquatable<PreCheckoutQuery>
{
	/// <summary>Unique query identifier</summary>
	[JsonPropertyName(PropertyNames.Id)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Id { get; set; }
	/// <summary>User who sent the query</summary>
	[JsonPropertyName(PropertyNames.From)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public User From { get; set; }
	/// <summary>Three-letter ISO 4217 <a href="https://core.telegram.org/bots/payments#supported-currencies">currency</a> code.</summary>
	[JsonPropertyName(PropertyNames.Currency)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string Currency { get; set; }
	/// <summary>Total price in the <i>smallest units</i> of the currency (integer, not float/double). For example, for a price of US$ 1.45 pass amount = 145. See the <i>exp</i> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies).</summary>
	[JsonPropertyName(PropertyNames.TotalAmount)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public uint TotalAmount { get; set; }
	/// <summary>Bot specified invoice payload.</summary>
	[JsonPropertyName(PropertyNames.InvoicePayload)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string InvoicePayload { get; set; }
	/// <summary>Optional. Identifier of the shipping option chosen by the user.</summary>
	[JsonPropertyName(PropertyNames.ShippingOptionId)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public string ShippingOptionId { get; set; }
	/// <summary>Optional. Order info provided by the user.</summary>
	[JsonPropertyName(PropertyNames.OrderInfo)]
	[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
	public OrderInfo OrderInfo { get; set; }
	/// <inheritdoc/>
	public override bool Equals(object obj)
	{
		return this.Equals(obj as PreCheckoutQuery);
	}
	/// <inheritdoc/>
	public bool Equals(PreCheckoutQuery? other)
	{
		return other != null &&
			   this.Id == other.Id &&
			   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
			   this.Currency == other.Currency &&
			   this.TotalAmount == other.TotalAmount &&
			   this.InvoicePayload == other.InvoicePayload &&
			   this.ShippingOptionId == other.ShippingOptionId &&
			   EqualityComparer<OrderInfo>.Default.Equals(this.OrderInfo, other.OrderInfo);
	}
	/// <inheritdoc/>
	public override int GetHashCode()
	{
		int hashCode = 2056600616;
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
		hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Currency);
		hashCode = hashCode * -1521134295 + this.TotalAmount.GetHashCode();
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.InvoicePayload);
		hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ShippingOptionId);
		hashCode = hashCode * -1521134295 + EqualityComparer<OrderInfo>.Default.GetHashCode(this.OrderInfo);
		return hashCode;
	}
	/// <inheritdoc/>
	public static bool operator ==(PreCheckoutQuery? left, PreCheckoutQuery? right)
	{
		return EqualityComparer<PreCheckoutQuery>.Default.Equals(left!, right!);
	}
	/// <inheritdoc/>
	public static bool operator !=(PreCheckoutQuery? left, PreCheckoutQuery? right)
	{
		return !(left == right);
	}

}
