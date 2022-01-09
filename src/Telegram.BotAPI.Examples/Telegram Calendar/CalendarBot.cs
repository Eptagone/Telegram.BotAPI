using System;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods.FormattingOptions;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.UpdatingMessages;

namespace TelegramCalendar
{
    public sealed class CalendarBot : TelegramBotBase
    {
        public static readonly BotClient Api = new BotClient("<BOT TOKEN>");

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
                    Api.SendMessage(message.Chat.Id, "🗓 <b>Telegram Bot Calendar</b> 🗓", parseMode: ParseMode.HTML, replyMarkup: rm);
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
                    Api.EditMessageReplyMarkup<Message>(new EditMessageReplyMarkup
                    {
                        ChatId = query.Message.Chat.Id,
                        MessageId = query.Message.MessageId,
                        ReplyMarkup = mkeyboard
                    });
                    break;
                case "year":
                    var ykeyboard = new InlineKeyboardMarkup
                    {
                        InlineKeyboard = Calendar.New(uint.Parse(cbargs[1]))
                    };
                    Api.EditMessageReplyMarkup<Message>(new EditMessageReplyMarkup
                    {
                        ChatId = query.Message.Chat.Id,
                        MessageId = query.Message.MessageId,
                        ReplyMarkup = ykeyboard
                    });
                    break;
                default:
                    Api.AnswerCallbackQuery(new AnswerCallbackQueryArgs
                    {
                        CallbackQueryId = query.Id,
                        Text = query.Data,
                        ShowAlert = true
                    });
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
