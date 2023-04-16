// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.IO;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Telegram.BotAPI.Payments;

/// <summary>Payments</summary>
public static partial class PaymentsExtensions
{
	/// <summary>Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an Update with the field pre_checkout_query. Use this method to respond to such pre-checkout queries. On success, True is returned. Note: The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.</summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="preCheckoutQueryId">Unique identifier for the query to be answered.</param>
	/// <param name="ok">Specify True if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use False if there are any problems.</param>
	/// <param name="errorMessage">Required if ok is False. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	/// <returns>On success, True is returned.</returns>
	public static bool AnswerPreCheckoutQuery(this BotClient? bot, string preCheckoutQueryId, bool ok, [Optional] string errorMessage)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString("pre_checkout_query_id", preCheckoutQueryId);
		json.WriteBoolean("ok", ok);
		if (!ok)
		{
			if (errorMessage == default)
			{
				throw new ArgumentNullException(nameof(errorMessage));
			}

			json.WriteString("error_message", errorMessage);
		}
		json.WriteEndObject();
		json.Flush(); json.Dispose();
		stream.Seek(0, SeekOrigin.Begin);
		return bot.RPC<bool>(MethodNames.AnswerPreCheckoutQuery, stream);
	}
	/// <summary>Once the user has confirmed their payment and shipping details, the Bot API sends the final confirmation in the form of an Update with the field pre_checkout_query. Use this method to respond to such pre-checkout queries. On success, True is returned. Note: The Bot API must receive an answer within 10 seconds after the pre-checkout query was sent.</summary>
	/// <param name="bot">Bot Client</param>
	/// <param name="preCheckoutQueryId">Unique identifier for the query to be answered.</param>
	/// <param name="ok">Specify True if everything is alright (goods are available, etc.) and the bot is ready to proceed with the order. Use False if there are any problems.</param>
	/// <param name="errorMessage">Required if ok is False. Error message in human readable form that explains the reason for failure to proceed with the checkout (e.g. "Sorry, somebody just bought the last of our amazing black T-shirts while you were busy filling out your payment details. Please choose a different color or garment!"). Telegram will display this message to the user.</param>
	/// <returns>On success, True is returned.</returns>
	/// <param name="cancellationToken">The cancellation token to cancel operation.</param>
	/// <exception cref="BotRequestException">Thrown when a request to Telegram Bot API got an error response.</exception>
	/// <exception cref="ArgumentNullException">Thrown when a required parameter is null.</exception>
	public static async Task<bool> AnswerPreCheckoutQueryAsync(this BotClient? bot, string preCheckoutQueryId, bool ok, [Optional] string errorMessage, [Optional] CancellationToken cancellationToken)
	{
		if (bot == default)
		{
			throw new ArgumentNullException(nameof(bot));
		}

		var stream = new MemoryStream();
		using var json = new Utf8JsonWriter(stream);
		json.WriteStartObject();
		json.WriteString("pre_checkout_query_id", preCheckoutQueryId);
		json.WriteBoolean("ok", ok);
		if (!ok)
		{
			if (errorMessage == default)
			{
				throw new ArgumentNullException(nameof(errorMessage));
			}

			json.WriteString("error_message", errorMessage);
		}
		json.WriteEndObject();
		await json.FlushAsync(cancellationToken).ConfigureAwait(false);
		await json.DisposeAsync().ConfigureAwait(false);
		stream.Seek(0, SeekOrigin.Begin);
		return await bot.RPCA<bool>(MethodNames.AnswerPreCheckoutQuery, stream, cancellationToken).ConfigureAwait(false);
	}
}
