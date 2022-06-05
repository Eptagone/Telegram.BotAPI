using HelloBotNET.AppService.Services;
using Telegram.BotAPI;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.AppService
{
    public class Worker : BackgroundService
    {
        private readonly BotClient _api;
        private readonly ILogger<Worker> _logger;
        private readonly IServiceProvider _serviceProvider;

        public Worker(ILogger<Worker> logger, HelloBotProperties botProperties, IServiceProvider serviceProvider)
        {
            _logger = logger;
            _api = botProperties.Api;
            _serviceProvider = serviceProvider;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            _logger.LogInformation("Worker running at: {Time}", DateTimeOffset.Now);

            // Long Polling
            var updates = await _api.GetUpdatesAsync(cancellationToken: stoppingToken).ConfigureAwait(false);
            while (!stoppingToken.IsCancellationRequested)
            {
                if (updates.Any())
                {
                    Parallel.ForEach(updates, (update) => ProcessUpdate(update));

                    updates = await _api.GetUpdatesAsync(updates[^1].UpdateId + 1, cancellationToken: stoppingToken).ConfigureAwait(false);
                }
                else
                {
                    updates = await _api.GetUpdatesAsync(cancellationToken: stoppingToken).ConfigureAwait(false);
                }
            }
        }

        private void ProcessUpdate(Update update)
        {
            using var scope = _serviceProvider.CreateScope();
            var bot = scope.ServiceProvider.GetRequiredService<HelloBot>();
            bot.OnUpdate(update);
        }

        public override Task StopAsync(CancellationToken cancellationToken)
        {
            _logger.LogInformation("Worker stopping at: {Time}", DateTimeOffset.Now);
            return base.StopAsync(cancellationToken);
        }
    }
}
