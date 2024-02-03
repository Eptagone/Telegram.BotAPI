// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.Extensions;

namespace HelloBotNET.AppService.Services;

/// <summary>
/// It contains the main functionality of the telegram bot. <br />
/// The application creates a new instance of this class to process each update received.
/// </summary>
public partial class HelloBot : SimpleTelegramBotBase
{
    private readonly ILogger<HelloBot> logger;
    public ITelegramBotClient Client { get; }

    public HelloBot(ILogger<HelloBot> logger, IConfiguration configuration)
    {
        this.logger = logger;

        var botToken = configuration.GetValue<string>("Telegram:BotToken");
        this.Client = new TelegramBotClient(botToken);

        var myUsername = this.Client.GetMe().Username!;
        // This will provide a better command filtering.
        this.SetCommandExtractor(myUsername, true);
    }
}
