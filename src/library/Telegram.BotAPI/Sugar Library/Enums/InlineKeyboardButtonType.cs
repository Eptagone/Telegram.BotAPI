// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Inlinekeyboardbutton Type
/// </summary>
[Obsolete("Use InlineKeyboardButtonTypes instead.")]
public enum InlineKeyboardButtonType
{
	/// <summary>Unknown button.</summary>
	Unknown,
	/// <summary>Url button.</summary>
	Url,
	/// <summary>CallbackData button.</summary>
	CallbackData,
	/// <summary>WebApp button.</summary>
	WebApp,
	/// <summary>Login Url button.</summary>
	LoginUrl,
	/// <summary>SwitchInlineQuery button.</summary>
	SwitchInlineQuery,
	/// <summary>SwitchInlineQueryCurrentChat button.</summary>
	SwitchInlineQueryCurrentChat,
	/// <summary>SwitchInlineQueryChosenChat button.</summary>
	SwitchInlineQueryChosenChat,
	/// <summary>CallbackGame button.</summary>
	CallbackGame,
	/// <summary>Pay button.</summary>
	Pay
}
