using Microsoft.Extensions.Logging;
using Telegram.BotAPI;

namespace HelloBotNET.Webhook.Services
{
    /// <summary>
    /// It contains the main functionality of the telegram bot. <br />
    /// The application creates a new instance of this class to process each update received.
    /// </summary>
    public partial class HelloBot : TelegramBotBase<HelloBotProperties>
    {
        private readonly ILogger<HelloBot> _logger;

        public HelloBot(ILogger<HelloBot> logger, HelloBotProperties botProperties) : base(botProperties)
        {
            _logger = logger;
        }
    }
}
