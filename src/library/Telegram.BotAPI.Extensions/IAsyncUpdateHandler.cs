// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents an interface for handling incoming updates asynchronously.
/// </summary>
public interface IAsyncUpdateHandler
{
    /// <summary>
    /// Receives and processes an incoming update.
    /// </summary>
    /// <param name="update">The incoming update.</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    Task OnUpdateAsync(Update update, CancellationToken cancellationToken = default);
}
