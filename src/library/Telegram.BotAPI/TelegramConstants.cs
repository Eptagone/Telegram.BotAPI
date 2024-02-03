// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// This class contains some constant values used by Telegram.
/// </summary>
public static class TelegramConstants
{
	/// <summary>
	/// Unique identifier for the anonymous bot.
	/// </summary>
	public const long GroupAnonymousBotId = 1087968824;

	/// <summary>
	/// Unique identifier for the telegram user.
	/// </summary>
	public const long TelegramId = 777000;

	/// <summary>
	/// Header name for the telegram bot api token in the request.
	/// </summary>
	public const string XTelegramBotApiSecretToken = "X-Telegram-Bot-Api-Secret-Token";
}
