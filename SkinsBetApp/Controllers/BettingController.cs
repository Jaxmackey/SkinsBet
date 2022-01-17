using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace SkinsBetApp.Controllers
{
    [Produces("application/json")]
    public class Betting : Controller
    {
        [HttpPost]
        public async Task<IActionResult> TakeResult([FromBody]Skin[] skins)
        {
            return Ok(skins);
        }
    }
}