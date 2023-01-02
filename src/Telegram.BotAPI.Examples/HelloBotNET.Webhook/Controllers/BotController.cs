// Copyright (c) 2023 Quetzal Rivera.
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
		private readonly IConfiguration _configuration;
		private readonly ILogger<BotController> _logger;
		private readonly HelloBot _bot;

		public BotController(ILogger<BotController> logger, IConfiguration configuration, HelloBot bot) : base()
		{
			this._logger = logger;
			this._configuration = configuration;
			this._bot = bot;
		}

		[HttpGet("{webhookToken}")]
		public IActionResult Get(string webhookToken)
		{
			if (this._configuration["Telegram:WebhookToken"] != webhookToken)
			{
				this._logger.LogWarning("Failed access!");
				this.Unauthorized();
			}
			return this.Ok();
		}

		[HttpPost("{webhookToken}")]
		public async Task<IActionResult> PostAsync(string webhookToken, [FromBody] Update update, CancellationToken cancellationToken)
		{
			if (this._configuration["Telegram:WebhookToken"] != webhookToken)
			{
#if DEBUG
				this._logger.LogWarning("Failed access");
#endif
				this.Unauthorized();
			}
			if (update == default)
			{
#if DEBUG
				this._logger.LogWarning("Invalid update detected");
#endif
				return this.BadRequest();
			}
			this._bot.OnUpdate(update);

			return await Task.FromResult(this.Ok());
		}
	}
}
