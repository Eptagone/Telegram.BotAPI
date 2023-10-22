// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace HelloBotNET.Webhook
{
	/// <summary>
	/// This class defines all the necessary settings and properties for the bot to work. <br />
	/// The application uses a single instance of this class.
	/// </summary>
	public sealed class HelloBotProperties : IBotProperties
	{
		private readonly BotCommandHelper _commandHelper;

		public HelloBotProperties(IConfiguration configuration)
		{
			var telegram = configuration.GetSection("Telegram"); // JSON: "Telegram"
			var botToken = telegram["BotToken"]; // ENV: Telegram__BotToken, JSON: "Telegram:BotToken"
			this.Api = new BotClient(botToken);
			this.User = this.Api.GetMe();

			this._commandHelper = new BotCommandHelper(this);
		}

		public BotClient Api { get; }
		public User User { get; }

		IBotCommandHelper IBotProperties.CommandHelper => this._commandHelper;
	}
}
