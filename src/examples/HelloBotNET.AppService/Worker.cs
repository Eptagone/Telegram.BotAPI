// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.AppService.Services;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.AppService
{
    public class Worker(ILogger<Worker> logger, HelloBot bot) : BackgroundService
    {
        private readonly ILogger<Worker> logger = logger;
        private readonly HelloBot bot = bot;

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            this.logger.LogInformation("Worker running at: {Time}", DateTimeOffset.Now);

            var client = this.bot.Client;

            // Long Polling
            var updates = await client
                .GetUpdatesAsync(cancellationToken: stoppingToken)
                .ConfigureAwait(false);
            while (!stoppingToken.IsCancellationRequested)
            {
                if (updates.Any())
                {
                    Parallel.ForEach(updates, this.ProcessUpdate);

                    updates = await client
                        .GetUpdatesAsync(
                            updates.Last().UpdateId + 1,
                            cancellationToken: stoppingToken
                        )
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

        private void ProcessUpdate(Update update)
        {
            this.bot.OnUpdate(update);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            this.logger.LogInformation("Worker stopping at: {Time}", DateTimeOffset.Now);
            return base.StopAsync(cancellationToken);
        }
    }
}
