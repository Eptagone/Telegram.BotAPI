using System.Runtime.InteropServices;
using System;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;
using Microsoft.Extensions.Logging;

namespace WebhookSample01.Services
{
    public sealed class MyBot : AsyncTelegramBotBase
    {
        public static readonly BotClient Bot = new BotClient("<your bot token>");

        private readonly ILogger<MyBot> _logger;

        public MyBot(ILogger<MyBot> logger)
        {
            _logger = logger;
        }

        protected override async Task OnMessageAsync(Message message, [Optional] CancellationToken cancellationToken)
        {
            if (message is null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            await Bot.SendMessageAsync(message.Chat.Id, "Hello world!", cancellationToken: cancellationToken).ConfigureAwait(false);
        }

        protected override async Task OnBotExceptionAsync(BotRequestException exp, [Optional] CancellationToken cancellationToken)
        {
            _logger.LogError("Bot Exception: {0}", exp?.Message);
            await Task.CompletedTask;
        }

        protected override async Task OnExceptionAsync(Exception exp, [Optional] CancellationToken cancellationToken)
        {
            _logger.LogError("Exception: {0}", exp?.Message);
            await Task.CompletedTask;
        }

    }
}
