using Microsoft.Extensions.Logging;
using System;
using Telegram.BotAPI;

namespace HelloBotNET.Webhook.Services
{
    /// <summary>
    /// It contains the main functionality of the telegram bot. <br />
    /// The application creates a new instance of this class to process each update received.
    /// </summary>
    public partial class HelloBot : TelegramBotBase<HelloBotProperties>
    {
        protected override void OnBotException(BotRequestException exp)
        {
            _logger.LogError("BotRequestException: {Message}", exp.Message);
        }

        protected override void OnException(Exception exp)
        {
            _logger.LogError("Exception: {Message}", exp.Message);
        }
    }
}
