// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;

namespace Telegram.BotAPI;

/// <summary>
/// Extensions for InlineKeyboardButton
/// </summary>
public static partial class InlineKeyboardButtonExtensions
{
	/// <summary>
	/// Get the button type.
	/// </summary>
	/// <returns><see cref="InlineKeyboardButtonType"/></returns>
	[Obsolete("Use Telegram.BotAPI.Extensions for alternative methods.")]
	public static InlineKeyboardButtonType GetButtonType(this InlineKeyboardButton button)
	{
		if (button.Url != default)
		{
			return InlineKeyboardButtonType.Url;
		}

		if (button.CallbackData != default)
		{
			return InlineKeyboardButtonType.CallbackData;
		}

		if (button.WebApp != default)
		{
			return InlineKeyboardButtonType.WebApp;
		}

		if (button.LoginUrl != default)
		{
			return InlineKeyboardButtonType.LoginUrl;
		}

		if (button.SwitchInlineQuery != default)
		{
			return InlineKeyboardButtonType.SwitchInlineQuery;
		}

		if (button.SwitchInlineQueryCurrentChat != default)
		{
			return InlineKeyboardButtonType.SwitchInlineQueryCurrentChat;
		}

		if (button.SwitchInlineQueryChosenChat != default)
		{
			return InlineKeyboardButtonType.SwitchInlineQueryChosenChat;
		}

		if (button.CallbackGame != default)
		{
			return InlineKeyboardButtonType.CallbackGame;
		}

		if (button.Pay != default)
		{
			return InlineKeyboardButtonType.Pay;
		}

		return InlineKeyboardButtonType.Unknown;
	}
}
