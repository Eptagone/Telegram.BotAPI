// Copyright (c) 2023 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using System.Linq;
using System.Text.RegularExpressions;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace BotTemplateSample
{
	public sealed class MyBot : TelegramBotBase
	{
		public static readonly BotClient Bot = new("<BOT TOKEN>");
		public static readonly User Me = Bot.GetMe();

		private Message message;
		private bool hasText;
		private User appUser;

		public override void OnUpdate(Update update)
		{
			Console.WriteLine("New update with id: {0}. Type: {1}", update?.UpdateId, update?.Type.ToString("F"));
			base.OnUpdate(update);
		}

		protected override void OnMessage(Message message)
		{
			// Ignore user 777000 (Telegram)
			if (message?.From.Id == TelegramConstants.TelegramId)
			{
				return;
			}
			Console.WriteLine("New message from chat id: {0}", message.Chat.Id);

			this.appUser = message.From; // Save current user;
			this.message = message; // Save current message;
			this.hasText = !string.IsNullOrEmpty(message.Text); // True if message has text;

			Console.WriteLine("Message Text: {0}", this.hasText ? message.Text : "|:O");

			if (message.Chat.Type == ChatType.Private) // Private Chats
			{
			}
			else // Group chats
			{

			}
			if (this.hasText)
			{
				if (message.Text.StartsWith('/')) // New commands
				{
					// If the command includes a mention, you should verify that it is for your bot, otherwise you will need to ignore the command.
					var pattern = string.Format(@"^\/(?<COMMAND>\w*)(?:|@{0})(?:$|\s(?<PARAMETERS>.*))", Me.Username);
					var match = Regex.Match(message.Text, pattern, RegexOptions.IgnoreCase);
					if (match.Success)
					{
						var command = match.Groups.Values.Single(v => v.Name == "COMMAND").Value; // Get command name
						var @params = match.Groups.Values.SingleOrDefault(v => v.Name == "PARAMETERS")?.Value; // Get command params
						var parameters = @params?.Split(' ').Where(s => !string.IsNullOrEmpty(s)).ToArray();

						Console.WriteLine("New command: {0}", command);
						this.OnCommand(command, parameters);
					}
				}
			}
		}

		private void OnCommand(string cmd, string[] args)
		{
			Console.WriteLine("Params: {0}", args.Length);
			switch (cmd)
			{
				case "hello":
					var hello = string.Format("Hello World, {0}!", this.appUser.FirstName);
					Bot.SendMessage(this.message.Chat.Id, hello);
					break;
			}
		}

		protected override void OnBotException(BotRequestException exp)
		{
			Console.WriteLine("New BotException: {0}", exp?.Message);
			Console.WriteLine("Error Code: {0}", exp.ErrorCode);
			Console.WriteLine();
		}

		protected override void OnException(Exception exp)
		{
			Console.WriteLine("New Exception: {0}", exp?.Message);
			Console.WriteLine();
		}
	}
}
