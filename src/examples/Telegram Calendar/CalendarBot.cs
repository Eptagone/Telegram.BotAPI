// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using System;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableMethods.FormattingOptions;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.Extensions;
using Telegram.BotAPI.UpdatingMessages;

namespace TelegramCalendar
{
	public sealed class CalendarBot : SimpleTelegramBotBase
	{
		public TelegramBotClient Client { get; } = new("<your bot token>");

		protected override void OnMessage(Message message)
		{
			var text = message?.Text;
			if (!string.IsNullOrEmpty(text))
			{
				if (text.Contains("/calendar"))
				{
					var rm = new InlineKeyboardMarkup
					{
						InlineKeyboard = Calendar.New(DateTime.Now)
					};
					Client.SendMessage(message.Chat.Id, "🗓 <b>Telegram Bot Calendar</b> 🗓", parseMode: ParseMode.HTML, replyMarkup: rm);
				}
			}
		}

		protected override void OnCallbackQuery(CallbackQuery query)
		{
			var cbargs = query?.Data.Split(' ');
			switch (cbargs[0])
			{
				case "month":
					var month = new Month((MonthName)Enum.Parse(typeof(MonthName), cbargs[2]), uint.Parse(cbargs[1]));
					var mkeyboard = new InlineKeyboardMarkup
					{
						InlineKeyboard = Calendar.New(month)
					};
					Client.EditMessageReplyMarkup(query.Message.Chat.Id, query.Message.MessageId, mkeyboard);
					break;
				case "year":
					var ykeyboard = new InlineKeyboardMarkup
					{
						InlineKeyboard = Calendar.New(uint.Parse(cbargs[1]))
					};
					Client.EditMessageReplyMarkup(query.Message.Chat.Id, query.Message.MessageId, ykeyboard);
					break;
				default:
					Client.AnswerCallbackQuery(query.Id, query.Data, true);
					break;
			}
		}


		protected override void OnBotException(BotRequestException exp)
		{
			Console.WriteLine("Bot Exception: {0}.", exp?.Message);
		}

		protected override void OnException(Exception exp)
		{
			Console.WriteLine("Exception: {0}.", exp?.Message);
		}
	}
}
