using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SkinsBetWebApp.Controllers
{
    [Produces("application/json")]
    public class Betting : Controller
    {
        private readonly ISteamRepository _steamRepository;

        public Betting(ISteamRepository steamRepository)
        {
            this._steamRepository = steamRepository;
        }
        [HttpPost]
        public async Task<IActionResult> TakeResult([FromBody]Skin[] skins)
        {
            var result = (await _steamRepository.GetAllSkins()).ToList();
            if (skins.Length != result.Count)
            {
                return BadRequest();
            }

            for (int i = 0; i < skins.Length; i++)
            {
                var current = result[i];
                if (current.Id != skins[i].Id || current.ClassId != skins[i].ClassId )
                {
                    return BadRequest();
                }
            }

            var totalSkins = result.Count - 1;
            var random = new Random();
            Thread.Sleep(random.Next(3000, 8000));
            var numEnd = random.Next(0, totalSkins);
            if (numEnd == 32)
            {
                numEnd = 34;
            }
            
            return Ok(skins[numEnd]);
        }
    }
}