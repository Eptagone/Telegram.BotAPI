// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Defines the properties used in the basic configuration of a Telegram bot.
/// </summary>
[Obsolete("Use your own context and implement Telegram.BotAPI.Extensions.ContextTelegramBotBase")]
public interface IBotProperties
{
	/// <summary>
	/// Bot client instance to interact with the Telegram Bot API.
	/// </summary>
	BotClient Api { get; }

	/// <summary>
	/// The basic information about the bot.
	/// </summary>
	User User { get; }

	/// <summary>
	/// The bot command helper.
	/// </summary>
	IBotCommandHelper CommandHelper { get; }
}
