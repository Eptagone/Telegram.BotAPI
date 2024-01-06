// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Threading;
using System.Threading.Tasks;


namespace Telegram.BotAPI.Payments;

public static partial class PaymentsExtensions
{
	/// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="args">Parameters.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool AnswerShippingQuery(this ITelegramBotClient api, AnswerShippingQueryArgs args)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		if (args == default) { throw new ArgumentNullException(nameof(args)); }
		return api.CallMethod<bool>(MethodNames.AnswerShippingQuery, args);
	}

	/// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="args">Parameters.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> AnswerShippingQueryAsync(this ITelegramBotClient api, AnswerShippingQueryArgs args, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		if (args == default) { throw new ArgumentNullException(nameof(args)); }
		return await api.CallMethodAsync<bool>(MethodNames.AnswerShippingQuery, args, cancellationToken).ConfigureAwait(false);
	}

	/// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="shippingQueryId">Unique identifier for the query to be answered.</param>
	/// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
	/// <param name="shippingOptions">Required if ok is True. A JSON-serialized array of available shipping options.</param>
	/// <param name="errorMessage">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static bool AnswerShippingQuery(this ITelegramBotClient api, string shippingQueryId, bool ok, [Optional] IEnumerable<ShippingOption>? shippingOptions, [Optional] string? errorMessage)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new AnswerShippingQueryArgs(shippingQueryId, ok)
		{
			ShippingOptions = shippingOptions,
			ErrorMessage = errorMessage
		};
		return api.CallMethod<bool>(MethodNames.AnswerShippingQuery, args);
	}

	/// <summary>If you sent an invoice requesting a shipping address and the parameter is_flexible was specified, the Bot API will send an Update with a shipping_query field to the bot. Use this method to reply to shipping queries. On success, True is returned.</summary>
	/// <param name="api">The bot client.</param>
	/// <param name="shippingQueryId">Unique identifier for the query to be answered.</param>
	/// <param name="ok">Specify True if delivery to the specified address is possible and False if there are any problems (for example, if delivery to the specified address is not possible).</param>
	/// <param name="shippingOptions">Required if ok is True. A JSON-serialized array of available shipping options.</param>
	/// <param name="errorMessage">Required if ok is False. Error message in human readable form that explains why it is impossible to complete the order (e.g. "Sorry, delivery to your desired address is unavailable'). Telegram will display this message to the user.</param>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> AnswerShippingQueryAsync(this ITelegramBotClient api, string shippingQueryId, bool ok, [Optional] IEnumerable<ShippingOption>? shippingOptions, [Optional] string? errorMessage, CancellationToken cancellationToken = default)
	{
		if (api == null) { throw new ArgumentNullException(nameof(api)); }
		var args = new AnswerShippingQueryArgs(shippingQueryId, ok)
		{
			ShippingOptions = shippingOptions,
			ErrorMessage = errorMessage
		};
		return await api.CallMethodAsync<bool>(MethodNames.AnswerShippingQuery, args, cancellationToken).ConfigureAwait(false);
	}
}
