// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI.Extensions;

/// <summary>
/// Defines methods to extract commands from a message.
/// </summary>
public interface IBotCommandExtractor
{
    /// <summary>
    /// Checks if the message contains a command.
    /// </summary>
    /// <param name="message">The message to check.</param>
    /// <returns>True if the message contains a command; otherwise, false.</returns>
    public bool HasCommand(Message message);

    /// <summary>
    /// Extracts the command and its arguments from the message.
    /// </summary>
    /// <param name="message">The message to extract the command from.</param>
    /// <returns>A tuple containing the command and
    public (string commandName, string args) ExtractCommand(Message message);
}
