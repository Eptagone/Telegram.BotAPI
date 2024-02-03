// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI;
using Telegram.BotAPI.Extensions;

namespace HelloBotNET.AppService.Services;

/// <summary>
/// It contains the main functionality of the telegram bot. <br />
/// The application creates a new instance of this class to process each update received.
/// </summary>
public partial class HelloBot : SimpleTelegramBotBase
{
    protected override void OnBotException(BotRequestException exp)
    {
        this.logger.LogError("BotRequestException: {Message}", exp.Message);
    }

    protected override void OnException(Exception exp)
    {
        this.logger.LogError("Exception: {Message}", exp.Message);
    }
}
