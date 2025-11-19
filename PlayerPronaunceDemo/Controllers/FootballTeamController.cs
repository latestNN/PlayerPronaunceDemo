using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Context;
using PlayerPronaunceDemo.Entities;

namespace PlayerPronaunceDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FootballTeamController : Controller
    {
        private readonly PPContext _context;

        public FootballTeamController(PPContext context)
        {
            _context = context;
        }

        [HttpGet("{teamId}")]
        public IActionResult GetTeamId(int teamId)
        {
            var values = _context.FootbalPlayers.Where(x => x.FootballTeamId == teamId).ToList();
            ViewBag.teamName = _context.FootbalPlayers.Include(z => z.footballTeam).Where(x => x.FootballTeamId == teamId).Select(y => y.footballTeam.Name).FirstOrDefault();
            return View(values);
        }
        

    }
}
