using System.Threading.Tasks;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace WebhookSample01.Services
{
    public class MyBot
    {
        public static readonly BotClient Bot = new BotClient("<your bot token>");
        public async Task OnUpdateAsync(Update update)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    await OnMessageAsync(update.Message);
                    break;
            }
        }
        public async Task OnMessageAsync(Message message)
        {
            await Bot.SendMessageAsync(message.Chat.Id, "Hello world!");
        }
    }
}
