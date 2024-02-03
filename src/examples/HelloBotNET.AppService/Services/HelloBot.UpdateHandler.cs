// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using Telegram.BotAPI.Extensions;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.AppService.Services;

/// <summary>
/// It contains the main functionality of the telegram bot. <br />
/// The application creates a new instance of this class to process each update received.
/// </summary>
public partial class HelloBot : SimpleTelegramBotBase
{
    public override void OnUpdate(Update update)
    {
#if DEBUG
        this.logger.LogInformation(
            "New update with id: {UpdateId}. Type: {UpdateType}",
            update.UpdateId,
            update.GetUpdateType()
        );
#endif

        base.OnUpdate(update);
    }
}
