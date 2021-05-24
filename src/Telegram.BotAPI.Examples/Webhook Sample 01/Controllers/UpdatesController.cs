using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Telegram.BotAPI.GettingUpdates;
using WebhookSample01.Services;

namespace WebhookSample01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdatesController : ControllerBase
    {
        private readonly MyBot _bot;
        public UpdatesController() : base()
        {
            _bot = new MyBot();
        }
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if (update == default)
            {
                return BadRequest();
            }
            await _bot.OnUpdateAsync(update).ConfigureAwait(false);
            return Ok();
        }
    }
}
