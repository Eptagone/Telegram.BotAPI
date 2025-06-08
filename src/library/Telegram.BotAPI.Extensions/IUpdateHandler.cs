// Copyright (c) 2025 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.GettingUpdates;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Represents an interface for handling incoming updates.
/// </summary>
public interface IUpdateHandler
{
    /// <summary>
    /// Receives and processes an incoming update.
    /// </summary>
    /// <param name="update">The incoming update.</param>
    void OnUpdate(Update update);
}
