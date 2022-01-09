// Copyright (c) 2022 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Telegram.BotAPI.AvailableTypes;

#nullable enable

namespace Telegram.BotAPI.Payments
{
    /// <summary>SendInvoice method arguments.</summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn, NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public sealed class SendInvoiceArgs : SendMessageBase, ICustomizableReplyMarkup<InlineKeyboardMarkup>
    {
        /// <summary>
        /// Initialize a new instance of <see cref="SendInvoiceArgs"/>.
        /// </summary>
        /// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target private chat.</param>
        /// <param name="title">Product name, 1-32 characters.</param>
        /// <param name="description">Product description, 1-255 characters.</param>
        /// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
        /// <param name="providerToken">Payments provider token, obtained via Botfather.</param>
        /// <param name="currency">Three-letter ISO 4217 currency code, see more <a href="https://core.telegram.org/bots/payments#supported-currencies">on currencies</a>.</param>
        /// <param name="prices">Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendInvoiceArgs(long chatId, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices) : base(chatId)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Payload = payload ?? throw new ArgumentNullException(nameof(payload));
            ProviderToken = providerToken ?? throw new ArgumentNullException(nameof(providerToken));
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
            Prices = prices ?? throw new ArgumentNullException(nameof(prices));
        }
        /// <summary>
        /// Initialize a new instance of <see cref="SendInvoiceArgs"/>.
        /// </summary>
        /// <param name="chatId"><see cref="long"/> or <see cref="string"/>. Unique identifier for the target private chat.</param>
        /// <param name="title">Product name, 1-32 characters.</param>
        /// <param name="description">Product description, 1-255 characters.</param>
        /// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
        /// <param name="providerToken">Payments provider token, obtained via Botfather.</param>
        /// <param name="currency">Three-letter ISO 4217 currency code, see more <a href="https://core.telegram.org/bots/payments#supported-currencies">on currencies</a>.</param>
        /// <param name="prices">Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</param>
        /// <exception cref="ArgumentNullException"></exception>
        public SendInvoiceArgs(string chatId, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices) : base(chatId)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Payload = payload ?? throw new ArgumentNullException(nameof(payload));
            ProviderToken = providerToken ?? throw new ArgumentNullException(nameof(providerToken));
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
            Prices = prices ?? throw new ArgumentNullException(nameof(prices));
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
        /// <summary>Payments provider token, obtained via Botfather.</summary>
        [JsonPropertyName(PropertyNames.ProviderToken)]
        public string ProviderToken { get; }
        /// <summary>Three-letter ISO 4217 currency code, see more <a href="https://core.telegram.org/bots/payments#supported-currencies">on currencies</a>.</summary>
        [JsonPropertyName(PropertyNames.Currency)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string Currency { get; }
        /// <summary>Price breakdown, a list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.)</summary>
        [JsonPropertyName(PropertyNames.Prices)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<LabeledPrice> Prices { get; }
        ///<summary>Optional. The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in <a href="https://core.telegram.org/bots/payments/currencies.json">currencies.json</a>, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</summary>
        [JsonPropertyName(PropertyNames.MaxTipAmount)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? MaxTipAmount { get; set; }
        ///<summary>Optional. An array of suggested amounts of tip in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</summary>
        [JsonPropertyName(PropertyNames.SuggestedTipAmounts)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public IEnumerable<uint>? SuggestedTipAmounts { get; set; }
        /// <summary>Optional. Unique deep-linking parameter. If left empty, forwarded copies of the sent message will have a Pay button, allowing multiple users to pay directly from the forwarded message, using the same invoice. If non-empty, forwarded copies of the sent message will have a URL button with a deep link to the bot (instead of a Pay button), with the value used as the start parameter</summary>
        [JsonPropertyName(PropertyNames.StartParameter)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? StartParameter { get; set; }
        /// <summary>Optional. JSON-encoded data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</summary>
        [JsonPropertyName(PropertyNames.ProviderData)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? ProviderData { get; set; }
        /// <summary>Optional. URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</summary>
        [JsonPropertyName(PropertyNames.PhotoUrl)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public string? PhotoUrl { get; set; }
        /// <summary>Optional. Photo size.</summary>
        [JsonPropertyName(PropertyNames.PhotoSize)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? PhotoSize { get; set; }
        /// <summary>Optional. Photo width.</summary>
        [JsonPropertyName(PropertyNames.PhotoWidth)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? PhotoWidth { get; set; }
        /// <summary>Optional. Photo height.</summary>
        [JsonPropertyName(PropertyNames.PhotoHeight)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public uint? PhotoHeight { get; set; }
        /// <summary>Optional. Pass True, if you require the user's full name to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedName)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? NeedName { get; set; }
        /// <summary>Optional. Pass True, if you require the user's phone number to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedPhoneNumber)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? NeedPhoneNumber { get; set; }
        /// <summary>Optional. Pass True, if you require the user's email address to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedEmail)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? NeedEmail { get; set; }
        /// <summary>Optional. Pass True, if you require the user's shipping address to complete the order.</summary>
        [JsonPropertyName(PropertyNames.NeedShippingAddress)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? NeedShippingAddress { get; set; }
        /// <summary>Optional. Pass True, if user's phone number should be sent to provider.</summary>
        [JsonPropertyName(PropertyNames.SendPhoneNumberToProvider)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SendPhoneNumberToProvider { get; set; }
        /// <summary>Optional. Pass True, if user's email address should be sent to provider.</summary>
        [JsonPropertyName(PropertyNames.SendEmailToProvider)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? SendEmailToProvider { get; set; }
        /// <summary>Optional. Pass True, if the final price depends on the shipping method.</summary>
        [JsonPropertyName(PropertyNames.IsFlexible)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public bool? IsFlexible { get; set; }
        /// <summary>Optional. A <see cref="InlineKeyboardMarkup"/> object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</summary>
        [JsonPropertyName(PropertyNames.ReplyMarkup)]
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.Ignore)]
        public InlineKeyboardMarkup? ReplyMarkup { get; set; }
    }
}
