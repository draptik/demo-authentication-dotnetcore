using API.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading;
using System.Threading.Tasks;

namespace API.Controllers
{
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
            });

            return Ok("ok");
        }
    }
}
