using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace SkinsBetApp.Controllers
{
    public class MainController : Controller
    {
        private readonly ISteamRepository _steamRepository;
        public MainController(ISteamRepository steamRepository)
        {
            _steamRepository = steamRepository;
        }
        // GET
        public async Task<IActionResult> Index()
        {
            var result = await _steamRepository.GetAllSkins();
            return View(result.ToArray());
        }
    }
}