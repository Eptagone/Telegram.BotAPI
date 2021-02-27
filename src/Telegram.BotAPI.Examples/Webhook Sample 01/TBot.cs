using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.GettingUpdates;
using System.Threading;
using System.Threading.Tasks;

namespace WebhookSample01
{
    public class TBot
    {
        public static readonly BotClient Bot = new BotClient("<your bot token>");
        public async Task OnUpdateAsync(Update update)
        {
            switch (update.Type)
            {
                case UpdateType.Message:
                    await TBot.Bot.SendMessageAsync(update.Message.Chat.Id, "Hello world!");
                    break;
            }
        }
    }
}
