using HelloBotNET.Webhook.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
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
            _logger = logger;
            _configuration = configuration;
            _bot = bot;
        }

        [HttpGet("{webhookToken}")]
        public IActionResult Get(string webhookToken)
        {
            if (_configuration["Telegram:WebhookToken"] != webhookToken)
            {
                _logger.LogWarning("Failed access!");
                Unauthorized();
            }
            return Ok();
        }

        [HttpPost("{webhookToken}")]
        public async Task<IActionResult> PostAsync(string webhookToken, [FromBody] Update update, CancellationToken cancellationToken)
        {
            if (_configuration["Telegram:WebhookToken"] != webhookToken)
            {
#if DEBUG
                _logger.LogWarning("Failed access");
#endif
                Unauthorized();
            }
            if (update == default)
            {
#if DEBUG
                _logger.LogWarning("Invalid update detected");
#endif
                return BadRequest();
            }
            _bot.OnUpdate(update);

            return await Task.FromResult(Ok());
        }
    }
}
