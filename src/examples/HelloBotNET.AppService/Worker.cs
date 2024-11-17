// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.AppService.Services;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.AppService;

public class Worker(ILogger<Worker> logger, HelloBot bot) : BackgroundService
{
    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        logger.LogInformation("Worker running at: {Time}", DateTimeOffset.Now);

        ITelegramBotClient client = bot.Client;

        // Long Polling
        IEnumerable<Update> updates = await client.GetUpdatesAsync(
            cancellationToken: stoppingToken
        );
        while (!stoppingToken.IsCancellationRequested)
        {
            if (updates.Any())
            {
                Parallel.ForEach(updates, this.ProcessUpdate);

                updates = await client
                    .GetUpdatesAsync(updates.Last().UpdateId + 1, cancellationToken: stoppingToken)
                    .ConfigureAwait(false);
            }
            else
            {
                updates = await client
                    .GetUpdatesAsync(cancellationToken: stoppingToken)
                    .ConfigureAwait(false);
            }
        }
    }

    private void ProcessUpdate(Update update) => bot.OnUpdate(update);

    public override Task StopAsync(CancellationToken cancellationToken)
    {
        logger.LogInformation("Worker stopping at: {Time}", DateTimeOffset.Now);
        return base.StopAsync(cancellationToken);
    }
}
