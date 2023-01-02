// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments
{
	/// <summary>This object contains information about an incoming shipping query.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class ShippingQuery : IEquatable<ShippingQuery>
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ShippingQuery"/> class.
		/// </summary>
		public ShippingQuery()
		{
			this.Id = null!;
			this.From = null!;
			this.InvoicePayload = null!;
			this.ShippingAddress = null!;
		}

		/// <summary>Unique query identifier</summary>
		[JsonPropertyName(PropertyNames.Id)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Id { get; set; }
		/// <summary>User who sent the query</summary>
		[JsonPropertyName(PropertyNames.From)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public AvailableTypes.User From { get; set; }
		/// <summary>Bot specified invoice payload</summary>
		[JsonPropertyName(PropertyNames.InvoicePayload)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string InvoicePayload { get; set; }
		/// <summary>User specified shipping address</summary>
		[JsonPropertyName(PropertyNames.ShippingAddress)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public ShippingAddress ShippingAddress { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as ShippingQuery);
		}
		/// <inheritdoc/>
		public bool Equals(ShippingQuery? other)
		{
			return other != null &&
				   this.Id == other.Id &&
				   EqualityComparer<User>.Default.Equals(this.From, other.From) &&
				   this.InvoicePayload == other.InvoicePayload &&
				   EqualityComparer<ShippingAddress>.Default.Equals(this.ShippingAddress, other.ShippingAddress);
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -837343580;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
			hashCode = hashCode * -1521134295 + EqualityComparer<User>.Default.GetHashCode(this.From);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.InvoicePayload);
			hashCode = hashCode * -1521134295 + EqualityComparer<ShippingAddress>.Default.GetHashCode(this.ShippingAddress);
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(ShippingQuery? left, ShippingQuery? right)
		{
			return EqualityComparer<ShippingQuery>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(ShippingQuery? left, ShippingQuery? right)
		{
			return !(left == right);
		}

	}
}
