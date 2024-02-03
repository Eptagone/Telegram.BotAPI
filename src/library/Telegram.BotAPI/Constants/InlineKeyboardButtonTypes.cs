// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Defines all available button types.
/// </summary>
public static class InlineKeyboardButtonTypes
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public const string Url = PropertyNames.Url;
	public const string CallbackData = PropertyNames.CallbackData;
	public const string WebApp = PropertyNames.WebApp;
	public const string LoginUrl = PropertyNames.LoginUrl;
	public const string SwitchInlineQuery = PropertyNames.SwitchInlineQuery;
	public const string SwitchInlineQueryCurrentChat = PropertyNames.SwitchInlineQueryCurrentChat;
	public const string SwitchInlineQueryChosenChat = PropertyNames.SwitchInlineQueryChosenChat;
	public const string CallbackGame = PropertyNames.CallbackGame;
	public const string Pay = PropertyNames.Pay;
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
