// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.
//* This file is auto-generated. Don't edit it manually!

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Payments;

/// <summary>
/// Represents the arguments of the "SendInvoice" method.
/// </summary>
public class SendInvoiceArgs
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SendInvoiceArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="title">Product name, 1-32 characters</param>
    /// <param name="description">Product description, 1-255 characters</param>
    /// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
    /// <param name="currency">Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>. Pass “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.). Must contain exactly one item for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    public SendInvoiceArgs(long chatId, string title, string description, string payload, string currency, IEnumerable<LabeledPrice> prices)
    {
        this.ChatId = chatId;
        this.Title = title ?? throw new ArgumentNullException(nameof(title));
        this.Description = description ?? throw new ArgumentNullException(nameof(description));
        this.Payload = payload ?? throw new ArgumentNullException(nameof(payload));
        this.Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        this.Prices = prices ?? throw new ArgumentNullException(nameof(prices));
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="SendInvoiceArgs"/> class.
    /// </summary>
    /// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)</param>
    /// <param name="title">Product name, 1-32 characters</param>
    /// <param name="description">Product description, 1-255 characters</param>
    /// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
    /// <param name="currency">Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>. Pass “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    /// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.). Must contain exactly one item for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.</param>
    public SendInvoiceArgs(string chatId, string title, string description, string payload, string currency, IEnumerable<LabeledPrice> prices)
    {
        this.ChatId = chatId ?? throw new ArgumentNullException(nameof(chatId));
        this.Title = title ?? throw new ArgumentNullException(nameof(title));
        this.Description = description ?? throw new ArgumentNullException(nameof(description));
        this.Payload = payload ?? throw new ArgumentNullException(nameof(payload));
        this.Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        this.Prices = prices ?? throw new ArgumentNullException(nameof(prices));
    }

    /// <summary>
    /// Unique identifier for the target chat or username of the target channel (in the format <em>@channelusername</em>)
    /// </summary>
    [JsonPropertyName(PropertyNames.ChatId)]
    public object ChatId { get; set; }

    /// <summary>
    /// Unique identifier for the target message thread (topic) of the forum; for forum supergroups only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageThreadId)]
    public int? MessageThreadId { get; set; }

    /// <summary>
    /// Product name, 1-32 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Title)]
    public string Title { get; set; }

    /// <summary>
    /// Product description, 1-255 characters
    /// </summary>
    [JsonPropertyName(PropertyNames.Description)]
    public string Description { get; set; }

    /// <summary>
    /// Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.
    /// </summary>
    [JsonPropertyName(PropertyNames.Payload)]
    public string Payload { get; set; }

    /// <summary>
    /// Payment provider token, obtained via <a href="https://t.me/botfather">@BotFather</a>. Pass an empty string for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.ProviderToken)]
    public string? ProviderToken { get; set; }

    /// <summary>
    /// Three-letter ISO 4217 currency code, see <a href="https://core.telegram.org/bots/payments#supported-currencies">more on currencies</a>. Pass “XTR” for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Currency)]
    public string Currency { get; set; }

    /// <summary>
    /// Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.). Must contain exactly one item for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.Prices)]
    public IEnumerable<LabeledPrice> Prices { get; set; }

    /// <summary>
    /// The maximum accepted amount for tips in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). For example, for a maximum tip of <em>US$ 1.45</em> pass <em>max_tip_amount = 145</em>. See the <em>exp</em> parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0. Not supported for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.MaxTipAmount)]
    public int? MaxTipAmount { get; set; }

    /// <summary>
    /// A JSON-serialized array of suggested amounts of tips in the <em>smallest units</em> of the currency (integer, <strong>not</strong> float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed <em>max_tip_amount</em>.
    /// </summary>
    [JsonPropertyName(PropertyNames.SuggestedTipAmounts)]
    public IEnumerable<int>? SuggestedTipAmounts { get; set; }

    /// <summary>
    /// Unique deep-linking parameter. If left empty, <strong>forwarded copies</strong> of the sent message will have a <em>Pay</em> button, allowing multiple users to pay directly from the forwarded message, using the same invoice. If non-empty, forwarded copies of the sent message will have a <em>URL</em> button with a deep link to the bot (instead of a <em>Pay</em> button), with the value used as the start parameter
    /// </summary>
    [JsonPropertyName(PropertyNames.StartParameter)]
    public string? StartParameter { get; set; }

    /// <summary>
    /// JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.
    /// </summary>
    [JsonPropertyName(PropertyNames.ProviderData)]
    public string? ProviderData { get; set; }

    /// <summary>
    /// URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.
    /// </summary>
    [JsonPropertyName(PropertyNames.PhotoUrl)]
    public string? PhotoUrl { get; set; }

    /// <summary>
    /// Photo size in bytes
    /// </summary>
    [JsonPropertyName(PropertyNames.PhotoSize)]
    public int? PhotoSize { get; set; }

    /// <summary>
    /// Photo width
    /// </summary>
    [JsonPropertyName(PropertyNames.PhotoWidth)]
    public int? PhotoWidth { get; set; }

    /// <summary>
    /// Photo height
    /// </summary>
    [JsonPropertyName(PropertyNames.PhotoHeight)]
    public int? PhotoHeight { get; set; }

    /// <summary>
    /// Pass <em>True</em> if you require the user's full name to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedName)]
    public bool? NeedName { get; set; }

    /// <summary>
    /// Pass <em>True</em> if you require the user's phone number to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedPhoneNumber)]
    public bool? NeedPhoneNumber { get; set; }

    /// <summary>
    /// Pass <em>True</em> if you require the user's email address to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedEmail)]
    public bool? NeedEmail { get; set; }

    /// <summary>
    /// Pass <em>True</em> if you require the user's shipping address to complete the order. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.NeedShippingAddress)]
    public bool? NeedShippingAddress { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the user's phone number should be sent to the provider. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.SendPhoneNumberToProvider)]
    public bool? SendPhoneNumberToProvider { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the user's email address should be sent to the provider. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.SendEmailToProvider)]
    public bool? SendEmailToProvider { get; set; }

    /// <summary>
    /// Pass <em>True</em> if the final price depends on the shipping method. Ignored for payments in <a href="https://t.me/BotNews/90">Telegram Stars</a>.
    /// </summary>
    [JsonPropertyName(PropertyNames.IsFlexible)]
    public bool? IsFlexible { get; set; }

    /// <summary>
    /// Sends the message <a href="https://telegram.org/blog/channels-2-0#silent-messages">silently</a>. Users will receive a notification with no sound.
    /// </summary>
    [JsonPropertyName(PropertyNames.DisableNotification)]
    public bool? DisableNotification { get; set; }

    /// <summary>
    /// Protects the contents of the sent message from forwarding and saving
    /// </summary>
    [JsonPropertyName(PropertyNames.ProtectContent)]
    public bool? ProtectContent { get; set; }

    /// <summary>
    /// Unique identifier of the message effect to be added to the message; for private chats only
    /// </summary>
    [JsonPropertyName(PropertyNames.MessageEffectId)]
    public string? MessageEffectId { get; set; }

    /// <summary>
    /// Description of the message to reply to
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyParameters)]
    public ReplyParameters? ReplyParameters { get; set; }

    /// <summary>
    /// A JSON-serialized object for an <a href="https://core.telegram.org/bots/features#inline-keyboards">inline keyboard</a>. If empty, one 'Pay <em>total price</em>' button will be shown. If not empty, the first button must be a Pay button.
    /// </summary>
    [JsonPropertyName(PropertyNames.ReplyMarkup)]
    public InlineKeyboardMarkup? ReplyMarkup { get; set; }
}
