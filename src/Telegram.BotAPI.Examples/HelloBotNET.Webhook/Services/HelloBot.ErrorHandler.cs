// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;

namespace HelloBotNET.Webhook.Services
{
	/// <summary>
	/// It contains the main functionality of the telegram bot. <br />
	/// The application creates a new instance of this class to process each update received.
	/// </summary>
	public partial class HelloBot : TelegramBotBase<HelloBotProperties>
	{
		protected override void OnBotException(BotRequestException exp)
		{
			this._logger.LogError("BotRequestException: {Message}", exp.Message);
		}

		protected override void OnException(Exception exp)
		{
			this._logger.LogError("Exception: {Message}", exp.Message);
		}
	}
}
