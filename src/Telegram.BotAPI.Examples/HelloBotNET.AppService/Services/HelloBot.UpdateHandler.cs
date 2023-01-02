// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.AppService.Services
{
	/// <summary>
	/// It contains the main functionality of the telegram bot. <br />
	/// The application creates a new instance of this class to process each update received.
	/// </summary>
	public partial class HelloBot : TelegramBotBase<HelloBotProperties>
	{
		public override void OnUpdate(Update update)
		{
#if DEBUG
			this._logger.LogInformation("New update with id: {0}. Type: {1}", update?.UpdateId, update?.Type.ToString("F"));
#endif

			base.OnUpdate(update);
		}
	}
}
