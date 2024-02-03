// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

public partial class TelegramBotClient : ITelegramBotClient
{
	/// <inheritdoc/>
	TelegramBotClientOptions ITelegramBotClient.Options => this.options;

	/// <inheritdoc/>
	public TResult CallMethod<TResult>(string method, object? args = null) =>
		this.CallApiMethodAndGetResultAsync<TResult>(method, args).GetAwaiter().GetResult()!;

	/// <inheritdoc/>
	public Task<TResult> CallMethodAsync<TResult>(
		string method,
		object? args = null,
		CancellationToken cancellationToken = default
	) => this.CallApiMethodAndGetResultAsync<TResult>(method, args, cancellationToken)!;

	/// <inheritdoc/>
	public BotResponse<TReturn> CallMethodDirect<TReturn>(string method, object? args = null) =>
		this.CallApiMethodAsync<TReturn>(method, args).GetAwaiter().GetResult();

	/// <inheritdoc/>
	public Task<BotResponse<TReturn>> CallMethodDirectAsync<TReturn>(
		string method,
		object? args = null,
		CancellationToken cancellationToken = default
	) => this.CallApiMethodAsync<TReturn>(method, args, cancellationToken);
}
