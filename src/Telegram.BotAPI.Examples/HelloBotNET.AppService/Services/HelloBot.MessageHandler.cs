// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.AvailableTypes;

namespace HelloBotNET.AppService.Services
{
	/// <summary>
	/// It contains the main functionality of the telegram bot. <br />
	/// The application creates a new instance of this class to process each update received.
	/// </summary>
	public partial class HelloBot : TelegramBotBase<HelloBotProperties>
	{
		protected override void OnMessage(Message message)
		{
			// Ignore user 777000 (Telegram)
			if (message!.From?.Id == TelegramConstants.TelegramId)
			{
				return;
			}

			var hasText = !string.IsNullOrEmpty(message.Text); // True if message has text;

#if DEBUG
			this._logger.LogInformation("New message from chat id: {ChatId}", message!.Chat.Id);
			this._logger.LogInformation("Message: {MessageContent}", hasText ? message.Text : "No text");
#endif

			base.OnMessage(message);
		}
	}
}
