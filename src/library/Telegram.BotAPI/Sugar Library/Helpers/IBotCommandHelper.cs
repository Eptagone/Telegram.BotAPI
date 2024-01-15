// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Defines a method to match the bot command of a text.
/// </summary>
[Obsolete("Use Telegram.BotAPI.Extensions.BotCommandExtractor instead.")]
public interface IBotCommandHelper
{
	/// <summary>
	/// Extracts the command name and parameters from the specified input string using the following format:<br/><b>/commandName[@BotUsername] [Params]</b>.
	/// </summary>
	/// <param name="text">Input string. The message text.</param>
	/// <returns>A <see cref="BotCommandMatch"/> object with the result information.</returns>
	BotCommandMatch Match(string text);
}
