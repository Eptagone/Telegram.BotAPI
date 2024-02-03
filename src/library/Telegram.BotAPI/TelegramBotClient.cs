// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

#region AUTHOR
/*
 * ┌────────────────────────────────────────────────────────────────────────────┐
 * │   █████████████████████████████████████████████████████████████████████	│
 * │  =======================================================================	│
 * │   Author: Quetzal Rivera                                             		│
 * │   Email: QuetzalDeveloper@outlook.com                               		│
 * │   Project: Telegram.BotAPI                                           		│
 * │   Creation Date: 13-12-2019                                           		│
 * │   Description: Library to access and interact with the Telegram Bot API. 	│
 * │  =======================================================================	│
 * └────────────────────────────────────────────────────────────────────────────┘
 */
#endregion

using System.Net.Http;

namespace Telegram.BotAPI;

/// <summary>
/// Provides a class for sending requests to the Telegram Bot API.
/// </summary>
public partial class TelegramBotClient : ITelegramBotClient
{
	private readonly TelegramBotClientOptions options;
	internal readonly HttpClient httpClient;

	/// <summary>
	/// Initialize a new instance of the <see cref="TelegramBotClient"/> class.
	/// </summary>
	/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
	/// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
	public TelegramBotClient(string botToken, HttpClient? httpClient = null)
		: this(new TelegramBotClientOptions(botToken), httpClient) { }

	/// <summary>
	/// Initialize a new instance of the <see cref="TelegramBotClient"/> class.
	/// </summary>
	/// <param name="options">Options for the <see cref="TelegramBotClient"/>.</param>
	/// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
	public TelegramBotClient(TelegramBotClientOptions options, HttpClient? httpClient = null)
	{
		this.options = options;
		this.httpClient =
			httpClient ?? new HttpClient() { BaseAddress = new Uri(options.ServerAddress) };
	}
}
