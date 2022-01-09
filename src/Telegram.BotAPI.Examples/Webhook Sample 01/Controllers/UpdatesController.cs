using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Telegram.BotAPI.GettingUpdates;
using WebhookSample01.Services;

namespace WebhookSample01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BotController : ControllerBase
    {
        private readonly MyBot _bot;
        public BotController(MyBot bot) : base()
        {
            _bot = bot;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] Update update, [Optional] CancellationToken cancellationToken)
        {
            if (update == default)
            {
                return BadRequest();
            }
            await _bot.OnUpdateAsync(update, cancellationToken).ConfigureAwait(false);
            return Ok();
        }
    }
}
