// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Telegram.BotAPI.Payments;

namespace Telegram.BotAPI.InlineMode
{
	/// <summary>Represents the content of an invoice message to be sent as the result of an inline query.</summary>
	[JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
	public sealed class InputInvoiceMessageContent : InputMessageContent, IEquatable<InputInvoiceMessageContent>
	{
		/// <summary>
		/// Initialize a new instance of <see cref="InputInvoiceMessageContent"/>.
		/// </summary>
		/// <param name="title">Product name, 1-32 characters.</param>
		/// <param name="description">Product description, 1-255 characters.</param>
		/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
		/// <param name="providerToken">Payment provider token, obtained via Botfather.</param>
		/// <param name="currency">Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>.</param>
		/// <param name="prices">Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
		/// <exception cref="ArgumentNullException"></exception>
		public InputInvoiceMessageContent(string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices)
		{
			this.Title = title ?? throw new ArgumentNullException(nameof(title));
			this.Description = description ?? throw new ArgumentNullException(nameof(description));
			this.Payload = payload ?? throw new ArgumentNullException(nameof(payload));
			this.ProviderToken = providerToken ?? throw new ArgumentNullException(nameof(providerToken));
			this.Currency = currency ?? throw new ArgumentNullException(nameof(currency));
			this.Prices = prices ?? throw new ArgumentNullException(nameof(prices));
		}

		/// <summary>Product name, 1-32 characters.</summary>
		[JsonPropertyName(PropertyNames.Title)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Title { get; }
		/// <summary>Product description, 1-255 characters.</summary>
		[JsonPropertyName(PropertyNames.Description)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Description { get; }
		/// <summary>Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</summary>
		[JsonPropertyName(PropertyNames.Payload)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Payload { get; }
		/// <summary>Payment provider token, obtained via Botfather.</summary>
		[JsonPropertyName(PropertyNames.ProviderToken)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string ProviderToken { get; }
		/// <summary>Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>.</summary>
		[JsonPropertyName(PropertyNames.Currency)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Currency { get; }
		/// <summary>Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</summary>
		[JsonPropertyName(PropertyNames.Prices)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<LabeledPrice> Prices { get; }
		/// <summary>Optional. The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</summary>
		[JsonPropertyName(PropertyNames.MaxTipAmount)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint MaxTipAmount { get; set; }
		/// <summary>Optional. An array of suggested amounts of tip in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</summary>
		[JsonPropertyName(PropertyNames.SuggestedTipAmounts)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public IEnumerable<uint> SuggestedTipAmounts { get; set; }
		/// <summary>Optional. A JSON-serialized object for data about the invoice, which will be shared with the payment provider. A detailed description of the required fields should be provided by the payment provider.</summary>
		[JsonPropertyName(PropertyNames.ProviderData)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string ProviderData { get; set; }
		/// <summary>Optional. URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</summary>
		[JsonPropertyName(PropertyNames.PhotoUrl)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string PhotoUrl { get; set; }
		/// <summary>Optional. Photo size.</summary>
		[JsonPropertyName(PropertyNames.PhotoSize)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint PhotoSize { get; set; }
		/// <summary>Optional. Photo width.</summary>
		[JsonPropertyName(PropertyNames.PhotoWidth)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint PhotoWidth { get; set; }
		/// <summary>Optional. Photo height.</summary>
		[JsonPropertyName(PropertyNames.PhotoHeight)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public uint PhotoHeight { get; set; }
		/// <summary>Optional. Pass True, if you require the user's full name to complete the order.</summary>
		[JsonPropertyName(PropertyNames.NeedName)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool NeedName { get; set; }
		/// <summary>Optional. Pass True, if you require the user's phone number to complete the order.</summary>
		[JsonPropertyName(PropertyNames.NeedPhoneNumber)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool NeedPhoneNumber { get; set; }
		/// <summary>Optional. Pass True, if you require the user's email address to complete the order.</summary>
		[JsonPropertyName(PropertyNames.NeedEmail)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool NeedEmail { get; set; }
		/// <summary>Optional. Pass True, if you require the user's shipping address to complete the order.</summary>
		[JsonPropertyName(PropertyNames.NeedShippingAddress)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool NeedShippingAddress { get; set; }
		/// <summary>Optional. Pass True, if user's phone number should be sent to provider.</summary>
		[JsonPropertyName(PropertyNames.SendPhoneNumberToProvider)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool SendPhoneNumberToProvider { get; set; }
		/// <summary>Optional. Pass True, if user's email address should be sent to provider.</summary>
		[JsonPropertyName(PropertyNames.SendEmailToProvider)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool SendEmailToProvider { get; set; }
		/// <summary>Optional. Pass True, if the final price depends on the shipping method.</summary>
		[JsonPropertyName(PropertyNames.IsFlexible)]
		[JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
		public bool IsFlexible { get; set; }
		/// <inheritdoc/>
		public override bool Equals(object obj)
		{
			return this.Equals(obj as InputInvoiceMessageContent);
		}
		/// <inheritdoc/>
		public bool Equals(InputInvoiceMessageContent? other)
		{
			return other != null &&
				   this.Title == other.Title &&
				   this.Description == other.Description &&
				   this.Payload == other.Payload &&
				   this.ProviderToken == other.ProviderToken &&
				   this.Currency == other.Currency &&
				   EqualityComparer<IEnumerable<LabeledPrice>>.Default.Equals(this.Prices, other.Prices) &&
				   this.MaxTipAmount == other.MaxTipAmount &&
				   EqualityComparer<IEnumerable<uint>>.Default.Equals(this.SuggestedTipAmounts, other.SuggestedTipAmounts) &&
				   this.ProviderData == other.ProviderData &&
				   this.PhotoUrl == other.PhotoUrl &&
				   this.PhotoSize == other.PhotoSize &&
				   this.PhotoWidth == other.PhotoWidth &&
				   this.PhotoHeight == other.PhotoHeight &&
				   this.NeedName == other.NeedName &&
				   this.NeedPhoneNumber == other.NeedPhoneNumber &&
				   this.NeedEmail == other.NeedEmail &&
				   this.NeedShippingAddress == other.NeedShippingAddress &&
				   this.SendPhoneNumberToProvider == other.SendPhoneNumberToProvider &&
				   this.SendEmailToProvider == other.SendEmailToProvider &&
				   this.IsFlexible == other.IsFlexible;
		}
		/// <inheritdoc/>
		public override int GetHashCode()
		{
			int hashCode = -54185413;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Title);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Description);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Payload);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ProviderToken);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Currency);
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<LabeledPrice>>.Default.GetHashCode(this.Prices);
			hashCode = hashCode * -1521134295 + this.MaxTipAmount.GetHashCode();
			hashCode = hashCode * -1521134295 + EqualityComparer<IEnumerable<uint>>.Default.GetHashCode(this.SuggestedTipAmounts);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.ProviderData);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.PhotoUrl);
			hashCode = hashCode * -1521134295 + this.PhotoSize.GetHashCode();
			hashCode = hashCode * -1521134295 + this.PhotoWidth.GetHashCode();
			hashCode = hashCode * -1521134295 + this.PhotoHeight.GetHashCode();
			hashCode = hashCode * -1521134295 + this.NeedName.GetHashCode();
			hashCode = hashCode * -1521134295 + this.NeedPhoneNumber.GetHashCode();
			hashCode = hashCode * -1521134295 + this.NeedEmail.GetHashCode();
			hashCode = hashCode * -1521134295 + this.NeedShippingAddress.GetHashCode();
			hashCode = hashCode * -1521134295 + this.SendPhoneNumberToProvider.GetHashCode();
			hashCode = hashCode * -1521134295 + this.SendEmailToProvider.GetHashCode();
			hashCode = hashCode * -1521134295 + this.IsFlexible.GetHashCode();
			return hashCode;
		}
		/// <inheritdoc/>
		public static bool operator ==(InputInvoiceMessageContent? left, InputInvoiceMessageContent? right)
		{
			return EqualityComparer<InputInvoiceMessageContent>.Default.Equals(left!, right!);
		}
		/// <inheritdoc/>
		public static bool operator !=(InputInvoiceMessageContent? left, InputInvoiceMessageContent? right)
		{
			return !(left == right);
		}

	}
}
