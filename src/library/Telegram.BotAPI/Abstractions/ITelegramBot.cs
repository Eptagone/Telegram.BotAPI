// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI;

/// <summary>
/// Represents a Telegram Bot.
/// Defines methods for receiving and processing incoming updates.
/// </summary>
public interface ITelegramBot
{
	/// <summary>
	/// Receives and processes an incoming update.
	/// </summary>
	/// <param name="update">The incoming update.</param>
	void OnUpdate(Update update);

	/// <summary>
	/// Receives and processes an incoming update.
	/// </summary>
	/// <param name="update">The incoming update.</param>
	/// <param name="cancellationToken">A cancellation token.</param>
	/// <returns>A task that represents the asynchronous operation.</returns>
	/// <exception cref="OperationCanceledException"></exception>
	Task OnUpdateAsync(Update update, CancellationToken cancellationToken = default);
}
