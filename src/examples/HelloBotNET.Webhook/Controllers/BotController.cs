// Copyright (c) 2024 Quetzal Rivera.
// Licensed under the MIT License, See LICENCE in the project root for license information.

using HelloBotNET.Webhook.Services;
using Microsoft.AspNetCore.Mvc;
using Telegram.BotAPI.GettingUpdates;

namespace HelloBotNET.Webhook.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<BotController> logger;
        private readonly HelloBot bot;

        public BotController(
            ILogger<BotController> logger,
            IConfiguration configuration,
            HelloBot bot
        )
            : base()
        {
            this.logger = logger;
            this.configuration = configuration;
            this.bot = bot;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync(
            [FromHeader(Name = "X-Telegram-Bot-Api-Secret-Token")] string webhookToken,
            [FromBody] Update update,
            CancellationToken cancellationToken
        )
        {
            if (this.configuration["Telegram:WebhookToken"] != webhookToken)
            {
#if DEBUG
                this.logger.LogWarning("Failed access");
#endif
                this.Unauthorized();
            }
            if (update == default)
            {
#if DEBUG
                this.logger.LogWarning("Invalid update detected");
#endif
                return this.BadRequest();
            }
            this.bot.OnUpdate(update);

            return await Task.FromResult(this.Ok());
        }
    }
}
