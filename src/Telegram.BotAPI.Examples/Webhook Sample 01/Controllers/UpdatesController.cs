using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Telegram.BotAPI.AvailableMethods;
using Telegram.BotAPI.GettingUpdates;

namespace WebhookSample01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UpdatesController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Update update)
        {
            if (update == default)
            {
                return BadRequest();
            }
            var bot = new TBot();
            await bot.OnUpdateAsync(update).ConfigureAwait(false);
            return Ok();
        }
    }
}
