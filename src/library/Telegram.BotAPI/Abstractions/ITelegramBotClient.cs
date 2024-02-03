// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Net.Http;
using System.Text.Json;

namespace Telegram.BotAPI;

/// <summary>
/// Defines methods to make requests to the Telegram Bot API.
/// </summary>
public interface ITelegramBotClient
{
	/// <summary>
	/// Options used to configure the client.
	/// </summary>
	TelegramBotClientOptions Options { get; }

	/// <summary>
	/// Calls a method of the Telegram Bot API and returns the result.
	/// </summary>
	/// <typeparam name="TResult">Result type.</typeparam>
	/// <param name="method">Method name.</param>
	/// <param name="args">Method arguments.</param>
	/// <returns>An object containing the result of the API call.</returns>
	/// <exception cref="ArgumentException">The method arguments are invalid.</exception>
	/// <exception cref="BotRequestException">The request failed and the Bot API returned an error.</exception>
	/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
	/// <exception cref="JsonException">The response could not be deserialized.</exception>
	TResult CallMethod<TResult>(string method, object? args = null);

	/// <summary>
	/// Calls a method of the Telegram Bot API and returns the result.
	/// </summary>
	/// <typeparam name="TResult">Result type.</typeparam>
	/// <param name="method">Method name.</param>
	/// <param name="args">Method arguments.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the request.</param>
	/// <returns>An object containing the result of the API call.</returns>
	/// <exception cref="ArgumentException">The method arguments are invalid.</exception>
	/// <exception cref="BotRequestException">The request failed and the Bot API returned an error.</exception>
	/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
	/// <exception cref="JsonException">The response could not be deserialized.</exception>
	/// <exception cref="OperationCanceledException">The request was canceled.</exception>
	Task<TResult> CallMethodAsync<TResult>(
		string method,
		object? args = null,
		CancellationToken cancellationToken = default
	);

	/// <summary>
	/// Calls a method of the Telegram Bot API and returns the response.
	/// </summary>
	/// <typeparam name="TReturn">Response type.</typeparam>
	/// <param name="method">Method name.</param>
	/// <param name="args">Method arguments.</param>
	/// <returns>A <see cref="BotResponse{T}"/> object containing the response.</returns>
	/// <exception cref="ArgumentException">The method arguments are invalid.</exception>
	/// <exception cref="BotRequestException">The request failed and the Bot API returned an error.</exception>
	/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
	/// <exception cref="JsonException">The response could not be deserialized.</exception>
	BotResponse<TReturn> CallMethodDirect<TReturn>(string method, object? args = null);

	/// <summary>
	/// Calls a method of the Telegram Bot API and returns the response.
	/// </summary>
	/// <typeparam name="TReturn">Response type.</typeparam>
	/// <param name="method">Method name.</param>
	/// <param name="args">Method arguments.</param>
	/// <param name="cancellationToken">A <see cref="CancellationToken"/> to cancel the request.</param>
	/// <returns>A <see cref="BotResponse{T}"/> object containing the response.</returns>
	/// <exception cref="ArgumentException">The method arguments are invalid.</exception>
	/// <exception cref="BotRequestException">The request failed and the Bot API returned an error.</exception>
	/// <exception cref="HttpRequestException">The request failed due to an underlying issue such as network connectivity, DNS failure, server certificate validation or timeout.</exception>
	/// <exception cref="JsonException">The response could not be deserialized.</exception>
	/// <exception cref="OperationCanceledException">The request was canceled.</exception>
	Task<BotResponse<TReturn>> CallMethodDirectAsync<TReturn>(
		string method,
		object? args = null,
		CancellationToken cancellationToken = default
	);
}
