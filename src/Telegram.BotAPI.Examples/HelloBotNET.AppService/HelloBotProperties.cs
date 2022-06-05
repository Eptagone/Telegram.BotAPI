using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.AppService
{
    /// <summary>
    /// This class defines all the necessary settings and properties for the bot to work. <br />
    /// The application uses a single instance of this class.
    /// </summary>
    public sealed class HelloBotProperties : IBotProperties
    {
        private readonly BotCommandHelper _commandHelper;

        public HelloBotProperties(IConfiguration configuration)
        {
            var telegram = configuration.GetSection("Telegram"); // JSON: "Telegram"
            var botToken = telegram["BotToken"]; // ENV: Telegram__BotToken, JSON: "Telegram:BotToken"

            Api = new BotClient(botToken);
            User = Api.GetMe();

            _commandHelper = new BotCommandHelper(this);

            // Delete my old commands
            Api.DeleteMyCommands();
            // Set my commands
            Api.SetMyCommands(
                new BotCommand("hello", "Hello world!"));

            // Delete webhook to use Long Polling
            Api.DeleteWebhook();
        }

        public BotClient Api { get; }
        public User User { get; }

        IBotCommandHelper IBotProperties.CommandHelper => _commandHelper;
    }
}
