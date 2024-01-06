// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableTypes;


namespace Telegram.BotAPI.Payments;

public static partial class PaymentsExtensions
{
	/// <summary>Use this method to send invoices. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendInvoice(this ITelegramBotClient bot, SendInvoiceArgs args)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return bot.CallMethod<Message>(MethodNames.SendInvoice, args);
	}
	/// <summary>Use this method to send invoices. On success, the sent Message is returned.</summary>
	/// <param name="bot">BotClient</param>
	/// <param name="args">Parameters</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendInvoiceAsync(this ITelegramBotClient bot, SendInvoiceArgs args, CancellationToken cancellationToken = default)
	{
		if (bot is null)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		if (args is null)
		{
			throw new ArgumentNullException(nameof(args));
		}

		return await bot.CallMethodAsync<Message>(MethodNames.SendInvoice, args, cancellationToken: cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send invoices. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="title">Product name, 1-32 characters.</param>
	/// <param name="description">Product description, 1-255 characters.</param>
	/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
	/// <param name="providerToken">Payment provider token, obtained via @BotFather.</param>
	/// <param name="currency">Three-letter ISO 4217 currency code, see more on currencies.</param>
	/// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="maxTipAmount">The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</param>
	/// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</param>
	/// <param name="startParameter">Unique deep-linking parameter. If left empty, forwarded copies of the sent message will have a Pay button, allowing multiple users to pay directly from the forwarded message, using the same invoice. If non-empty, forwarded copies of the sent message will have a URL button with a deep link to the bot (instead of a Pay button), with the value used as the start parameter.</param>
	/// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
	/// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</param>
	/// <param name="photoSize">Photo size in bytes.</param>
	/// <param name="photoWidth">Photo width.</param>
	/// <param name="photoHeight">Photo height.</param>
	/// <param name="needName">Pass True if you require the user's full name to complete the order.</param>
	/// <param name="needPhoneNumber">Pass True if you require the user's phone number to complete the order.</param>
	/// <param name="needEmail">Pass True if you require the user's email address to complete the order.</param>
	/// <param name="needShippingAddress">Pass True if you require the user's shipping address to complete the order.</param>
	/// <param name="sendPhoneNumberToProvider">Pass True if the user's phone number should be sent to provider.</param>
	/// <param name="sendEmailToProvider">Pass True if the user's email address should be sent to provider.</param>
	/// <param name="isFlexible">Pass True if the final price depends on the shipping method.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendInvoice(this ITelegramBotClient client, long chatId, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices, int? messageThreadId = null, uint? maxTipAmount = null, IEnumerable<uint>? suggestedTipAmounts = null, string? startParameter = null, string? providerData = null, string? photoUrl = null, uint? photoSize = null, uint? photoWidth = null, uint? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendInvoiceArgs(chatId, title, description, payload, providerToken, currency, prices)
		{
			MessageThreadId = messageThreadId,
			MaxTipAmount = maxTipAmount,
			SuggestedTipAmounts = suggestedTipAmounts,
			StartParameter = startParameter,
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
			IsFlexible = isFlexible,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendInvoice, args);
	}

	/// <summary>
	/// Use this method to send invoices. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="title">Product name, 1-32 characters.</param>
	/// <param name="description">Product description, 1-255 characters.</param>
	/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
	/// <param name="providerToken">Payment provider token, obtained via @BotFather.</param>
	/// <param name="currency">Three-letter ISO 4217 currency code, see more on currencies.</param>
	/// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="maxTipAmount">The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</param>
	/// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</param>
	/// <param name="startParameter">Unique deep-linking parameter. If left empty, forwarded copies of the sent message will have a Pay button, allowing multiple users to pay directly from the forwarded message, using the same invoice. If non-empty, forwarded copies of the sent message will have a URL button with a deep link to the bot (instead of a Pay button), with the value used as the start parameter.</param>
	/// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
	/// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</param>
	/// <param name="photoSize">Photo size in bytes.</param>
	/// <param name="photoWidth">Photo width.</param>
	/// <param name="photoHeight">Photo height.</param>
	/// <param name="needName">Pass True if you require the user's full name to complete the order.</param>
	/// <param name="needPhoneNumber">Pass True if you require the user's phone number to complete the order.</param>
	/// <param name="needEmail">Pass True if you require the user's email address to complete the order.</param>
	/// <param name="needShippingAddress">Pass True if you require the user's shipping address to complete the order.</param>
	/// <param name="sendPhoneNumberToProvider">Pass True if the user's phone number should be sent to provider.</param>
	/// <param name="sendEmailToProvider">Pass True if the user's email address should be sent to provider.</param>
	/// <param name="isFlexible">Pass True if the final price depends on the shipping method.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static Message SendInvoice(this ITelegramBotClient client, string chatId, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices, int? messageThreadId = null, uint? maxTipAmount = null, IEnumerable<uint>? suggestedTipAmounts = null, string? startParameter = null, string? providerData = null, string? photoUrl = null, uint? photoSize = null, uint? photoWidth = null, uint? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, InlineKeyboardMarkup? replyMarkup = null)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendInvoiceArgs(chatId, title, description, payload, providerToken, currency, prices)
		{
			MessageThreadId = messageThreadId,
			MaxTipAmount = maxTipAmount,
			SuggestedTipAmounts = suggestedTipAmounts,
			StartParameter = startParameter,
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
			IsFlexible = isFlexible,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return client.CallMethod<Message>(MethodNames.SendInvoice, args);
	}

	/// <summary>
	/// Use this method to send invoices. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="title">Product name, 1-32 characters.</param>
	/// <param name="description">Product description, 1-255 characters.</param>
	/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
	/// <param name="providerToken">Payment provider token, obtained via @BotFather.</param>
	/// <param name="currency">Three-letter ISO 4217 currency code, see more on currencies.</param>
	/// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="maxTipAmount">The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</param>
	/// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</param>
	/// <param name="startParameter">Unique deep-linking parameter. If left empty, forwarded copies of the sent message will have a Pay button, allowing multiple users to pay directly from the forwarded message, using the same invoice. If non-empty, forwarded copies of the sent message will have a URL button with a deep link to the bot (instead of a Pay button), with the value used as the start parameter.</param>
	/// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
	/// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</param>
	/// <param name="photoSize">Photo size in bytes.</param>
	/// <param name="photoWidth">Photo width.</param>
	/// <param name="photoHeight">Photo height.</param>
	/// <param name="needName">Pass True if you require the user's full name to complete the order.</param>
	/// <param name="needPhoneNumber">Pass True if you require the user's phone number to complete the order.</param>
	/// <param name="needEmail">Pass True if you require the user's email address to complete the order.</param>
	/// <param name="needShippingAddress">Pass True if you require the user's shipping address to complete the order.</param>
	/// <param name="sendPhoneNumberToProvider">Pass True if the user's phone number should be sent to provider.</param>
	/// <param name="sendEmailToProvider">Pass True if the user's email address should be sent to provider.</param>
	/// <param name="isFlexible">Pass True if the final price depends on the shipping method.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendInvoiceAsync(this ITelegramBotClient client, long chatId, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices, int? messageThreadId = null, uint? maxTipAmount = null, IEnumerable<uint>? suggestedTipAmounts = null, string? startParameter = null, string? providerData = null, string? photoUrl = null, uint? photoSize = null, uint? photoWidth = null, uint? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendInvoiceArgs(chatId, title, description, payload, providerToken, currency, prices)
		{
			MessageThreadId = messageThreadId,
			MaxTipAmount = maxTipAmount,
			SuggestedTipAmounts = suggestedTipAmounts,
			StartParameter = startParameter,
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
			IsFlexible = isFlexible,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendInvoice, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>
	/// Use this method to send invoices. On success, the sent Message is returned.
	/// </summary>
	/// <param name="client">The bot client.</param>
	/// <param name="chatId">Unique identifier for the target chat or username of the target channel (in the format @channelusername).</param>
	/// <param name="title">Product name, 1-32 characters.</param>
	/// <param name="description">Product description, 1-255 characters.</param>
	/// <param name="payload">Bot-defined invoice payload, 1-128 bytes. This will not be displayed to the user, use for your internal processes.</param>
	/// <param name="providerToken">Payment provider token, obtained via @BotFather.</param>
	/// <param name="currency">Three-letter ISO 4217 currency code, see more on currencies.</param>
	/// <param name="prices">Price breakdown, a JSON-serialized list of components (e.g. product price, tax, discount, delivery cost, delivery tax, bonus, etc.).</param>
	/// <param name="messageThreadId">Unique identifier for the target message thread (topic) of the forum; for forum supergroups only.</param>
	/// <param name="maxTipAmount">The maximum accepted amount for tips in the smallest units of the currency (integer, not float/double). For example, for a maximum tip of US$ 1.45 pass max_tip_amount = 145. See the exp parameter in currencies.json, it shows the number of digits past the decimal point for each currency (2 for the majority of currencies). Defaults to 0.</param>
	/// <param name="suggestedTipAmounts">A JSON-serialized array of suggested amounts of tips in the smallest units of the currency (integer, not float/double). At most 4 suggested tip amounts can be specified. The suggested tip amounts must be positive, passed in a strictly increased order and must not exceed max_tip_amount.</param>
	/// <param name="startParameter">Unique deep-linking parameter. If left empty, forwarded copies of the sent message will have a Pay button, allowing multiple users to pay directly from the forwarded message, using the same invoice. If non-empty, forwarded copies of the sent message will have a URL button with a deep link to the bot (instead of a Pay button), with the value used as the start parameter.</param>
	/// <param name="providerData">JSON-serialized data about the invoice, which will be shared with the payment provider. A detailed description of required fields should be provided by the payment provider.</param>
	/// <param name="photoUrl">URL of the product photo for the invoice. Can be a photo of the goods or a marketing image for a service. People like it better when they see what they are paying for.</param>
	/// <param name="photoSize">Photo size in bytes.</param>
	/// <param name="photoWidth">Photo width.</param>
	/// <param name="photoHeight">Photo height.</param>
	/// <param name="needName">Pass True if you require the user's full name to complete the order.</param>
	/// <param name="needPhoneNumber">Pass True if you require the user's phone number to complete the order.</param>
	/// <param name="needEmail">Pass True if you require the user's email address to complete the order.</param>
	/// <param name="needShippingAddress">Pass True if you require the user's shipping address to complete the order.</param>
	/// <param name="sendPhoneNumberToProvider">Pass True if the user's phone number should be sent to provider.</param>
	/// <param name="sendEmailToProvider">Pass True if the user's email address should be sent to provider.</param>
	/// <param name="isFlexible">Pass True if the final price depends on the shipping method.</param>
	/// <param name="disableNotification">Sends the message silently. Users will receive a notification with no sound.</param>
	/// <param name="protectContent">Protects the contents of the sent message from forwarding and saving.</param>
	/// <param name="replyParameters">Description of the message to reply to.</param>
	/// <param name="replyMarkup">A JSON-serialized object for an inline keyboard. If empty, one 'Pay total price' button will be shown. If not empty, the first button must be a Pay button.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<Message> SendInvoiceAsync(this ITelegramBotClient client, string chatId, string title, string description, string payload, string providerToken, string currency, IEnumerable<LabeledPrice> prices, int? messageThreadId = null, uint? maxTipAmount = null, IEnumerable<uint>? suggestedTipAmounts = null, string? startParameter = null, string? providerData = null, string? photoUrl = null, uint? photoSize = null, uint? photoWidth = null, uint? photoHeight = null, bool? needName = null, bool? needPhoneNumber = null, bool? needEmail = null, bool? needShippingAddress = null, bool? sendPhoneNumberToProvider = null, bool? sendEmailToProvider = null, bool? isFlexible = null, bool? disableNotification = null, bool? protectContent = null, ReplyParameters? replyParameters = null, InlineKeyboardMarkup? replyMarkup = null, CancellationToken cancellationToken = default)
	{
		if (client is null)
			throw new ArgumentNullException(nameof(client));
		var args = new SendInvoiceArgs(chatId, title, description, payload, providerToken, currency, prices)
		{
			MessageThreadId = messageThreadId,
			MaxTipAmount = maxTipAmount,
			SuggestedTipAmounts = suggestedTipAmounts,
			StartParameter = startParameter,
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
			IsFlexible = isFlexible,
			DisableNotification = disableNotification,
			ProtectContent = protectContent,
			ReplyParameters = replyParameters,
			ReplyMarkup = replyMarkup
		};
		return await client.CallMethodAsync<Message>(MethodNames.SendInvoice, args, cancellationToken).ConfigureAwait(false);
	}
}
