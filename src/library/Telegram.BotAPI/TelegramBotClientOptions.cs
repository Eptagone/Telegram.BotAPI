// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

namespace Telegram.BotAPI;

/// <summary>
/// Options for a <see cref="TelegramBotClient"/>.
/// </summary>
public record TelegramBotClientOptions
{
	/// <summary>
	/// Default server address to send bot request.
	/// </summary>
	public const string BaseServerAddress = "https://api.telegram.org";

	private string serverAddress = BaseServerAddress;

	/// <summary>
	/// Initialize a Telegram Bot Client.
	/// </summary>
	/// <param name="botToken">Token granted by <a href="https://t.me/BotFather">BotFather</a>. Required to access the Telegram bot API.</param>
	public TelegramBotClientOptions(string botToken) => this.BotToken = botToken;

	/// <summary>
	/// Set true if you want methods to automatically retry the request when the server returns a 429 (Too Many Requests) error.
	/// Default value is false.
	/// </summary>
	public bool AutoRetryOnRateLimit { get; set; }

	/// <summary>
	/// Token granted by <a href="https://t.me/BotFather">BotFather</a>.
	/// Required to access the Telegram bot API.
	/// </summary>
	public string BotToken { get; }

	/// <summary>
	/// Set true if you want methods to return a default value when bot requests are rejected instead of throwing a <see cref="BotRequestException"/>.
	/// Default value is false.
	/// </summary>
	/// <remarks>
	/// This feature was added for specific testing purposes. For example, running the bot in fairly unstable environments.
	/// It's not recommended to use this feature in production environments. All exceptions should be handled properly.
	/// </remarks>
	public bool IgnoreBotExceptions { get; set; }

	/// <summary>
	/// The server address to send bot request.
	/// Default value is: https://api.telegram.org
	/// </summary>
	/// <remarks>
	/// Change this parameter if you're using your own <a href="https://core.telegram.org/bots/api#using-a-local-bot-api-server">Local Bot API Server</a>.
	/// </remarks>
	public string ServerAddress
	{
		get => this.serverAddress;
		set
		{
			if (!Uri.TryCreate(value, UriKind.Absolute, out _))
			{
				throw new ArgumentException("The value must be a valid Uri.", nameof(value));
			}
			this.serverAddress = value;
		}
	}

	/// <summary>
	/// True if the current client is using the Test Environment.
	/// If true, all requests methods will be prefixed with "/test".
	/// Default value is false.
	/// </summary>
	public bool UseTestEnvironment { get; set; }
}
