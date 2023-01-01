// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;


namespace Telegram.BotAPI.Payments
{
	/// <summary>Payments</summary>
	public static partial class PaymentsExtensions
	{
		/// <summary>
		/// Use this method to create a link for an invoice. Returns the created invoice link as String on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="args">Parameters.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static string CreateInvoiceLink(this BotClient? api, CreateInvoiceLinkArgs args)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (args == default) { throw new ArgumentNullException(nameof(args)); }
			return api.RPC<string>(MethodNames.CreateInvoiceLink, args);
		}

		/// <summary>
		/// Use this method to create a link for an invoice. Returns the created invoice link as String on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="args">Parameters.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<string> CreateInvoiceLinkAsync(this BotClient? api, CreateInvoiceLinkArgs args, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			if (args == default) { throw new ArgumentNullException(nameof(args)); }
			return await api.RPCA<string>(MethodNames.CreateInvoiceLink, args, cancellationToken).ConfigureAwait(false);
		}

		/// <summary>
		/// Use this method to create a link for an invoice. Returns the created invoice link as String on success.
		/// </summary>
		/// <param name="api">The bot client.</param>
		/// <param name="title">Product name, 1-32 characters.</param>
		/// <param name="description">Product description, 1-255 characters.</param>
		/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
		/// <param name="providerToken">Payment provider token, obtained via BotFather.</param>
		/// <param name="currency">Three-letter ISO 4217 currency code, see more on currencies.</param>
		/// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
		/// <param name="maxTipAmount">The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</param>
		/// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</param>
		/// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
		/// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.</param>
		/// <param name="photoSize">Photo size in bytes.</param>
		/// <param name="photoWidth">Photo width.</param>
		/// <param name="photoHeight">Photo height.</param>
		/// <param name="needName">Pass True, if you require the user's full name to complete the order.</param>
		/// <param name="needPhoneNumber">Pass True, if you require the user's phone number to complete the order.</param>
		/// <param name="needEmail">Pass True, if you require the user's email address to complete the order.</param>
		/// <param name="needShippingAddress">Pass True, if you require the user's shipping address to complete the order.</param>
		/// <param name="sendPhoneNumberToProvider">Pass True, if the user's phone number should be sent to the provider.</param>
		/// <param name="sendEmailToProvider">Pass True, if the user's email address should be sent to the provider.</param>
		/// <param name="isFlexible">Pass True, if the final price depends on the shipping method.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static string CreateInvoiceLink(this BotClient? api, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices, [Optional] uint? maxTipAmount, [Optional] IEnumerable<uint>? suggestedTipAmounts, [Optional] string? providerData, [Optional] string? photoUrl, [Optional] uint? photoSize, [Optional] uint? photoWidth, [Optional] uint? photoHeight, [Optional] bool? needName, [Optional] bool? needPhoneNumber, [Optional] bool? needEmail, [Optional] bool? needShippingAddress, [Optional] bool? sendPhoneNumberToProvider, [Optional] bool? sendEmailToProvider, [Optional] bool? isFlexible)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new CreateInvoiceLinkArgs(title, description, payload, providerToken, currency, prices)
			{
				MaxTipAmount = maxTipAmount,
				SuggestedTipAmounts = suggestedTipAmounts,
				ProviderData = providerData,
				PhotoUrl = photoUrl,
				PhotoSize = photoSize,
				PhotoWidth = photoWidth,
				PhotoHeight = photoHeight,
				NeedName = needName,
				NeedPhoneNumber = needPhoneNumber,
				NeedEmail = needEmail,
				NeedShippingAddress = needShippingAddress,
				SendPhoneNumberToProvider = sendPhoneNumberToProvider,
				SendEmailToProvider = sendEmailToProvider,
				IsFlexible = isFlexible
			};
			return api.RPC<string>(MethodNames.CreateInvoiceLink, args);
		}

		/// <summary>Use this method to create a link for an invoice. Returns the created invoice link as String on success.</summary>
		/// <param name="api">The bot client.</param>
		/// <param name="title">Product name, 1-32 characters.</param>
		/// <param name="description">Product description, 1-255 characters.</param>
		/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
		/// <param name="providerToken">Payment provider token, obtained via BotFather.</param>
		/// <param name="currency">Three-letter ISO 4217 currency code, see more on currencies.</param>
		/// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
		/// <param name="maxTipAmount">The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</param>
		/// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</param>
		/// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
		/// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.</param>
		/// <param name="photoSize">Photo size in bytes.</param>
		/// <param name="photoWidth">Photo width.</param>
		/// <param name="photoHeight">Photo height.</param>
		/// <param name="needName">Pass True, if you require the user's full name to complete the order.</param>
		/// <param name="needPhoneNumber">Pass True, if you require the user's phone number to complete the order.</param>
		/// <param name="needEmail">Pass True, if you require the user's email address to complete the order.</param>
		/// <param name="needShippingAddress">Pass True, if you require the user's shipping address to complete the order.</param>
		/// <param name="sendPhoneNumberToProvider">Pass True, if the user's phone number should be sent to the provider.</param>
		/// <param name="sendEmailToProvider">Pass True, if the user's email address should be sent to the provider.</param>
		/// <param name="isFlexible">Pass True, if the final price depends on the shipping method.</param>
		/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
		/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
		/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
		public static async Task<string> CreateInvoiceLinkAsync(this BotClient? api, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices, [Optional] uint? maxTipAmount, [Optional] IEnumerable<uint>? suggestedTipAmounts, [Optional] string? providerData, [Optional] string? photoUrl, [Optional] uint? photoSize, [Optional] uint? photoWidth, [Optional] uint? photoHeight, [Optional] bool? needName, [Optional] bool? needPhoneNumber, [Optional] bool? needEmail, [Optional] bool? needShippingAddress, [Optional] bool? sendPhoneNumberToProvider, [Optional] bool? sendEmailToProvider, [Optional] bool? isFlexible, [Optional] CancellationToken cancellationToken)
		{
			if (api == null) { throw new ArgumentNullException(nameof(api)); }
			var args = new CreateInvoiceLinkArgs(title, description, payload, providerToken, currency, prices)
			{
				MaxTipAmount = maxTipAmount,
				SuggestedTipAmounts = suggestedTipAmounts,
				ProviderData = providerData,
				PhotoUrl = photoUrl,
				PhotoSize = photoSize,
				PhotoWidth = photoWidth,
				PhotoHeight = photoHeight,
				NeedName = needName,
				NeedPhoneNumber = needPhoneNumber,
				NeedEmail = needEmail,
				NeedShippingAddress = needShippingAddress,
				SendPhoneNumberToProvider = sendPhoneNumberToProvider,
				SendEmailToProvider = sendEmailToProvider,
				IsFlexible = isFlexible
			};
			return await api.RPCA<string>(MethodNames.CreateInvoiceLink, args, cancellationToken).ConfigureAwait(false);
		}
	}
}
