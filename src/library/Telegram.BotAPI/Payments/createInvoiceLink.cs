// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Extension methods for the Telegram Bot API.
/// </summary>
public static partial class PaymentsExtensions
{
    /// <summary>
    /// Use this method to create a link for an invoice. Returns the created invoice link as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "CreateInvoiceLink" method.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static string CreateInvoiceLink(this ITelegramBotClient client, CreateInvoiceLinkArgs args) =>
        client.CreateInvoiceLinkAsync(args).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create a link for an invoice. Returns the created invoice link as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="args">The arguments for the "CreateInvoiceLink" method.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<string> CreateInvoiceLinkAsync(this ITelegramBotClient client, CreateInvoiceLinkArgs args, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        return client.CallMethodAsync<string>(MethodNames.CreateInvoiceLink, args, cancellationToken);
    }

    /// <summary>
    /// Use this method to create a link for an invoice. Returns the created invoice link as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="title">Product name, 1-32 characters</param>
    /// <param name="description">Product description, 1-255 characters</param>
    /// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
    /// <param name="currency">Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>. Pass “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.). Must contain exactly one item for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="providerToken">Payment provider token, obtained via <a href="https://t.me/botfather">@BotFather</a>. Pass an empty string for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="maxTipAmount">The maximum accepted amount for tips in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). For example, for a maximum tip of <em>US$ 1.45</em> pass <em>max_tip_amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0. Not supported for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed <em>max_tip_amount</em>.</param>
    /// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
    /// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.</param>
    /// <param name="photoSize">Photo size in bytes</param>
    /// <param name="photoWidth">Photo width</param>
    /// <param name="photoHeight">Photo height</param>
    /// <param name="needName">Pass <em>True</em> if you require the user's full name to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="needPhoneNumber">Pass <em>True</em> if you require the user's phone number to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="needEmail">Pass <em>True</em> if you require the user's email address to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="needShippingAddress">Pass <em>True</em> if you require the user's shipping address to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="sendPhoneNumberToProvider">Pass <em>True</em> if the user's phone number should be sent to the provider. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="sendEmailToProvider">Pass <em>True</em> if the user's email address should be sent to the provider. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="isFlexible">Pass <em>True</em> if the final price depends on the shipping method. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static string CreateInvoiceLink(this ITelegramBotClient client, string title, string description, string payload, string currency, IEnumerable<LabeledPrice> prices, string? providerToken = null, int? maxTipAmount = null, IEnumerable<int>? suggestedTipAmounts = null, string? providerData = null, string? photoUrl = null, int? photoSize = null, int? photoWidth = null, int? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null) =>
        client.CreateInvoiceLinkAsync(title, description, payload, currency, prices, providerToken, maxTipAmount, suggestedTipAmounts, providerData, photoUrl, photoSize, photoWidth, photoHeight, needName, needPhoneNumber, needEmail, needShippingAddress, sendPhoneNumberToProvider, sendEmailToProvider, isFlexible).GetAwaiter().GetResult();

    /// <summary>
    /// Use this method to create a link for an invoice. Returns the created invoice link as <em>String</em> on success.
    /// </summary>
    /// <param name="client">The <see cref="ITelegramBotClient"/> instance.</param>
    /// <param name="title">Product name, 1-32 characters</param>
    /// <param name="description">Product description, 1-255 characters</param>
    /// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
    /// <param name="currency">Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>. Pass “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.). Must contain exactly one item for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="providerToken">Payment provider token, obtained via <a href="https://t.me/botfather">@BotFather</a>. Pass an empty string for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="maxTipAmount">The maximum accepted amount for tips in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). For example, for a maximum tip of <em>US$ 1.45</em> pass <em>max_tip_amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0. Not supported for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed <em>max_tip_amount</em>.</param>
    /// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
    /// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service.</param>
    /// <param name="photoSize">Photo size in bytes</param>
    /// <param name="photoWidth">Photo width</param>
    /// <param name="photoHeight">Photo height</param>
    /// <param name="needName">Pass <em>True</em> if you require the user's full name to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="needPhoneNumber">Pass <em>True</em> if you require the user's phone number to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="needEmail">Pass <em>True</em> if you require the user's email address to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="needShippingAddress">Pass <em>True</em> if you require the user's shipping address to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="sendPhoneNumberToProvider">Pass <em>True</em> if the user's phone number should be sent to the provider. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="sendEmailToProvider">Pass <em>True</em> if the user's email address should be sent to the provider. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="isFlexible">Pass <em>True</em> if the final price depends on the shipping method. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="cancellationToken">The cancellation token to cancel operation.</param>
    /// <exception cref="ArgumentNullException">Thrown if <paramref name="client"/> is <c>null</c>.</exception>
    /// <exception cref="BotRequestException">Thrown if the request to the Telegram Bot API fails.</exception>
    /// <returns></returns>
    public static Task<string> CreateInvoiceLinkAsync(this ITelegramBotClient client, string title, string description, string payload, string currency, IEnumerable<LabeledPrice> prices, string? providerToken = null, int? maxTipAmount = null, IEnumerable<int>? suggestedTipAmounts = null, string? providerData = null, string? photoUrl = null, int? photoSize = null, int? photoWidth = null, int? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null, CancellationToken cancellationToken = default)
    {
        if (client is null)
        {
            throw new ArgumentNullException(nameof(client));
        }

        var args = new Dictionary<string, object>()
        {
            { PropertyNames.Title, title ?? throw new ArgumentNullException(nameof(title)) },
            { PropertyNames.Description, description ?? throw new ArgumentNullException(nameof(description)) },
            { PropertyNames.Payload, payload ?? throw new ArgumentNullException(nameof(payload)) },
            { PropertyNames.Currency, currency ?? throw new ArgumentNullException(nameof(currency)) },
            { PropertyNames.Prices, prices ?? throw new ArgumentNullException(nameof(prices)) }
        };
        if (providerToken is not null)
        {
            args.Add(PropertyNames.ProviderToken, providerToken);
        }
        if (maxTipAmount is not null)
        {
            args.Add(PropertyNames.MaxTipAmount, maxTipAmount);
        }
        if (suggestedTipAmounts is not null)
        {
            args.Add(PropertyNames.SuggestedTipAmounts, suggestedTipAmounts);
        }
        if (providerData is not null)
        {
            args.Add(PropertyNames.ProviderData, providerData);
        }
        if (photoUrl is not null)
        {
            args.Add(PropertyNames.PhotoUrl, photoUrl);
        }
        if (photoSize is not null)
        {
            args.Add(PropertyNames.PhotoSize, photoSize);
        }
        if (photoWidth is not null)
        {
            args.Add(PropertyNames.PhotoWidth, photoWidth);
        }
        if (photoHeight is not null)
        {
            args.Add(PropertyNames.PhotoHeight, photoHeight);
        }
        if (needName is not null)
        {
            args.Add(PropertyNames.NeedName, needName);
        }
        if (needPhoneNumber is not null)
        {
            args.Add(PropertyNames.NeedPhoneNumber, needPhoneNumber);
        }
        if (needEmail is not null)
        {
            args.Add(PropertyNames.NeedEmail, needEmail);
        }
        if (needShippingAddress is not null)
        {
            args.Add(PropertyNames.NeedShippingAddress, needShippingAddress);
        }
        if (sendPhoneNumberToProvider is not null)
        {
            args.Add(PropertyNames.SendPhoneNumberToProvider, sendPhoneNumberToProvider);
        }
        if (sendEmailToProvider is not null)
        {
            args.Add(PropertyNames.SendEmailToProvider, sendEmailToProvider);
        }
        if (isFlexible is not null)
        {
            args.Add(PropertyNames.IsFlexible, isFlexible);
        }

        return client.CallMethodAsync<string>(MethodNames.CreateInvoiceLink, args, cancellationToken);
    }
}
