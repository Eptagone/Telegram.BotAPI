// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Games;

namespace Telegram.BotAPI;

/// <summary>
/// This class define methods to build <see cref="InlineKeyboardButton"/> objects.
/// </summary>
[Obsolete]
public static class InlineButtonBuilder
{
	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a url.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="url">Url.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetUrl(string text, string url)
	{
		return new InlineKeyboardButton(text) { Url = url };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a WebApp.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="webApp">Description of the Web App that will be launched when the user presses the button. The Web App will be able to send an arbitrary message on behalf of the user using the method answerWebAppQuery. Available only in private chats between a user and the bot.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetWebApp(string text, WebAppInfo webApp)
	{
		return new InlineKeyboardButton(text) { WebApp = webApp };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a Callback data.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="callbackData">Callback data.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetCallbackData(string text, string callbackData)
	{
		return new InlineKeyboardButton(text) { CallbackData = callbackData };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a <see cref="LoginUrl"/>.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="loginUrl">A <see cref="LoginUrl"/></param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetLoginUrl(string text, LoginUrl loginUrl)
	{
		return new InlineKeyboardButton(text) { LoginUrl = loginUrl };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a inline query.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="switchInlineQuery">Inline query.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetSwitchInlineQuery(string text, string switchInlineQuery)
	{
		return new InlineKeyboardButton(text) { SwitchInlineQuery = switchInlineQuery };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a inline query for the current chat.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="switchInlineQueryCurrentChat">Inline query.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetSwitchInlineQueryCurrentChat(string text, string switchInlineQueryCurrentChat)
	{
		return new InlineKeyboardButton(text) { SwitchInlineQueryCurrentChat = switchInlineQueryCurrentChat };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a inline query for the chosen chat.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="switchInlineQueryChosenChat">Inline query chosen chat</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetSwitchInlineQueryChosenChat(string text, SwitchInlineQueryChosenChat switchInlineQueryChosenChat)
	{
		return new InlineKeyboardButton(text) { SwitchInlineQueryChosenChat = switchInlineQueryChosenChat };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> with a callback game.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <param name="callbackGame">Callback game.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetCallbackGame(string text, CallbackGame callbackGame)
	{
		return new InlineKeyboardButton(text) { CallbackGame = callbackGame };
	}

	/// <summary>
	/// Create a new <see cref="InlineKeyboardButton"/> for pay.
	/// </summary>
	/// <param name="text">Button text.</param>
	/// <returns><see cref="InlineKeyboardButton"/></returns>
	public static InlineKeyboardButton SetPay(string text)
	{
		return new InlineKeyboardButton(text) { Pay = true };
	}
}
