// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System.Net.Http;

namespace Telegram.BotAPI;

/// <summary>
/// Legacy Telegram Bot Client.
/// </summary>
[Obsolete("This class is obsolete. Use TelegramBotClient instead.")]
public sealed partial class BotClient : TelegramBotClient
{
	/// <summary>
	/// Initialize a Telegram Bot Client.
	/// </summary>
	/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
	/// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
	public BotClient(string botToken, HttpClient? httpClient = null) : base(botToken, httpClient)
	{
	}

	/// <summary>
	/// Initialize a Telegram Bot Client.
	/// </summary>
	/// <param name="options">Options for the <see cref="TelegramBotClient"/>.</param>
	/// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
	public BotClient(TelegramBotClientOptions options, HttpClient? httpClient = null) : base(options, httpClient)
	{
	}

	/// <summary>
	/// Initialize a Telegram Bot Client.
	/// </summary>
	/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
	/// <param name="httpClient">Provide a specific HttpClient for this instance of BotClient.</param>
	/// <param name="serverAddress">Optional. The server address to connect to. Default value is "https://api.telegram.org". Change this parameter if you're using a <a href="https://core.telegram.org/bots/api#using-a-local-bot-api-server">Local Bot API Server</a>.</param>
	/// <exception cref="ArgumentNullException">Thrown when accessToken is null or empty.</exception>
	[Obsolete("Use the constructor with BotClientOptions.")]
	public BotClient(string botToken, HttpClient? httpClient, string serverAddress = "https://api.telegram.org") : base(new TelegramBotClientOptions(botToken) { ServerAddress = serverAddress }, httpClient)
	{
	}

	/// <summary>Initialize a Telegram Bot Client.</summary>
	/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
	/// <param name="ignoreBotExceptions">Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/>.</param>
	/// <param name="httpClient">Optional. Provide a specific HttpClient for this instance of BotClient.</param>
	/// <param name="serverAddress">Optional. The server address to connect to. Default value is "https://api.telegram.org". Change this parameter if you're using a <a href="https://core.telegram.org/bots/api#using-a-local-bot-api-server">Local Bot API Server</a>.</param>
	/// <param name="useTestEnvironment">Optional. Set true if the new client will use the Test Environment. If true, all requests methods will be prefixed with "/test". Example: "/test/getMe".</param>
	/// <exception cref="ArgumentNullException">Thrown when accessToken is null or empty.</exception>
	[Obsolete("Use the constructor with BotClientOptions.")]
	public BotClient(string botToken, bool ignoreBotExceptions, HttpClient httpClient = null, string serverAddress = "https://api.telegram.org", bool useTestEnvironment = false) : base(new TelegramBotClientOptions(botToken) { IgnoreBotExceptions = ignoreBotExceptions, ServerAddress = serverAddress, UseTestEnvironment = useTestEnvironment }, httpClient)
	{
	}

	/// <summary>
	/// Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.
	/// </summary>
	public string Token => ((ITelegramBotClient)this).Options.BotToken;

	/// <summary>
	/// Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/>.
	/// </summary>
	public bool IgnoreBotExceptions => ((ITelegramBotClient)this).Options.IgnoreBotExceptions;

	/// <summary>
	/// The server address to send bot request.
	/// Default value is: https://api.telegram.org
	/// </summary>
	public string ServerAddress => ((ITelegramBotClient)this).Options.ServerAddress;

	/// <summary>
	/// True if the current client is using the Test Environment.
	/// If true, all requests methods will be prefixed with "/test".
	/// </summary>
	public bool UseTestEnvironment => ((ITelegramBotClient)this).Options.UseTestEnvironment;

	/// <summary>
	/// Bot base url for download files. {0} = BotToken, {1} = FilePath
	/// </summary>
	[Obsolete("Use FileUrlTemplate instead.")]
	public const string BaseFilesUrl = "https://api.telegram.org/file/bot{0}/{1}";
}