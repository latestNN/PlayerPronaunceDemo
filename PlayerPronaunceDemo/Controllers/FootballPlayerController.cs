using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballPlayerController : Controller
    {
        private readonly PPContext _context;

        public FootballPlayerController(PPContext context)
        {
            _context = context;
        }

        [HttpGet("{playerId}")]
        public IActionResult Index(int playerId)
        {
            ViewBag.playerImage = _context.FootbalPlayers.Where(x => x.FootbalPlayerId == playerId).Select(y => y.ImageUrl).FirstOrDefault();
            ViewBag.playerName = _context.FootbalPlayers.Where(x => x.FootbalPlayerId == playerId).Select(y => y.Name).FirstOrDefault();
            ViewBag.playerNation = _context.FootbalPlayers.Where(x => x.FootbalPlayerId == playerId).Select(y => y.Nation).FirstOrDefault();
            ViewBag.playerTeam = _context.FootbalPlayers.Include(z => z.footballTeam).Where(x => x.FootbalPlayerId == playerId).Select(y => y.footballTeam.Name).FirstOrDefault();
            ViewBag.playerNationFlag = _context.FootbalPlayers.Where(x => x.FootbalPlayerId == playerId).Select(y => y.NationFlagImageUrl).FirstOrDefault();
            ViewBag.playerTeamImage = _context.FootbalPlayers.Include(x => x.footballTeam).Where(y => y.FootbalPlayerId == playerId).Select(z => z.NationFlagImageUrl).FirstOrDefault();
            var values = _context.Sounds.Where(x => x.FootballPlayerId == playerId).ToList();

            if (values != null)
            {
                return View(values);
            }
            else
            {
                return View();
            }
            

        }
    }
}
