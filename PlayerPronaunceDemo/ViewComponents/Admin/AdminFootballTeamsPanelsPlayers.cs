using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminFootballTeamsPanelsPlayers : ViewComponent
    {
        private readonly PPContext _context;

        public AdminFootballTeamsPanelsPlayers(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int id)
        {
            //ViewBag.playerId = _context.FootbalPlayers.Where(x => x.FootballTeamId == id).Select(y => y.FootbalPlayerId).FirstOrDefault();
            //ViewBag.playerName = _context.FootbalPlayers.Where(x => x.FootballTeamId == id).Select(y => y.Name).FirstOrDefault();
            //ViewBag.playerImage = _context.FootbalPlayers.Include(k => k.footballTeam).Where(x => x.FootballTeamId == id).Select(y => y.ImageUrl).FirstOrDefault();
            //ViewBag.playerNation = _context.FootbalPlayers.Include(k => k.footballTeam).Where(x => x.FootballTeamId == id).Select(y => y.Nation).FirstOrDefault();
            //ViewBag.playerNationImage = _context.FootbalPlayers.Where(x => x.FootballTeamId == id).Select(y => y.NationFlagImageUrl).FirstOrDefault();
            //ViewBag.soundCount = _context.Sounds.Include(x => x.footballPlayer).Where(y => y.footballPlayer.FootbalPlayerId == id).Count();

            var values = _context.FootbalPlayers.Include(x => x.footballTeam).Include(y => y.Sounds).Where(z => z.footballTeam.FootballTeamId == id).ToList();
            
            return View(values);
        }
    }
}
