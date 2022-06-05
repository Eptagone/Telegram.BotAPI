using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.AvailableTypes;

namespace HelloBotNET.AppService.Services
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
            _logger.LogInformation("Params: {0}", args.Length);
#endif

            switch (commandName)
            {
                case "hello": // Reply to /hello command
                    var hello = string.Format("Hello World, {0}!", message.From!.FirstName);
                    Api.SendMessage(message.Chat.Id, hello);
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
                        Api.SendMessage(message.Chat.Id, "Unrecognized command.");
                    }
                    break;
            }
        }
    }
}
