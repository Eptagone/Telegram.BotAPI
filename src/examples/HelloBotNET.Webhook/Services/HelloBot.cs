// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.Extensions;

namespace HelloBotNET.Webhook.Services;

/// <summary>
///     It contains the main functionality of the telegram bot. <br />
///     The application creates a new instance of this class to process each update received.
/// </summary>
public partial class HelloBot : SimpleTelegramBotBase
{
    private readonly ILogger<HelloBot> logger;

    public HelloBot(ILogger<HelloBot> logger, IConfiguration configuration)
    {
        this.logger = logger;

        string botToken =
            configuration.GetValue<string>("Telegram:BotToken")
            ?? throw new ArgumentNullException("Telegram:BotToken");
        this.Client = new TelegramBotClient(botToken);

        string myUsername = this.Client.GetMe().Username!;
        // This will provide a better command filtering.
        this.SetCommandExtractor(myUsername);
    }

    public ITelegramBotClient Client { get; }
}
