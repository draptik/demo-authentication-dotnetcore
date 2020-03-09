using Microsoft.AspNetCore.Mvc;
using Gateway.Core.Models;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Gateway.Controllers
{
    [Authorize]
    [ApiController]
    [Route("api/[controller]")]
    public class BestellungController : ControllerBase
    {
        /// <summary>
        /// Bestellung aufgeben
        /// </summary>
        /// <param name="bestellungAufgegeben"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> BestellungAufgegebenAsync([FromBody] BestellungAufgegeben bestellungAufgegeben)
        {
            var result = await Task.Run(() =>
            {
                Thread.Sleep(10);
                return true;
            }).ConfigureAwait(false);

            return Ok("ok");
        }
    }
}
