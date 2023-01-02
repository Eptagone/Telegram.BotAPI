// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace HelloBotNET.Webhook.Services
{
	/// <summary>
	/// It contains the main functionality of the telegram bot. <br />
	/// The application creates a new instance of this class to process each update received.
	/// </summary>
	public partial class HelloBot : TelegramBotBase<HelloBotProperties>
	{
		protected override void OnCommand(Message message, string commandName, string commandParameters)
		{
			var args = commandParameters.Split(' ');
#if DEBUG
			this._logger.LogInformation("Params: {0}", args.Length);
#endif

			switch (commandName)
			{
				case "hello": // Reply to /hello command
					var hello = string.Format("Hello World, {0}!", message.From!.FirstName);
					this.Api.SendMessage(message.Chat.Id, hello);
					break;
				/*
                case "command1":
                    // ...
                    break;
                case "command2":
                    // ...
                    break;
                */
				default:
					if (message.Chat.Type == ChatType.Private)
					{
						this.Api.SendMessage(message.Chat.Id, "Unrecognized command.");
					}
					break;
			}
		}
	}
}
