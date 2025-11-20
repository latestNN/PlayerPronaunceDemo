using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Context;
using PlayerPronaunceDemo.Entities;

namespace PlayerPronaunceDemo.Controllers
{
    public class AdminController : Controller
    {
        private readonly PPContext _context;

        public AdminController(PPContext context)
        {
            _context = context;
        }

        public IActionResult FootballPlayersList()
        {
            var values = _context.FootbalPlayers.Include(x => x.footballTeam).Include(y => y.Sounds).ToList();
            return View(values);
        }
        public IActionResult FootballTeamsList()
        {
            var values = _context.FootballTeams.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddPlayer()
        {
            var teams = _context.FootballTeams
                                        .Select(c => new SelectListItem
                                        {
                                            Value = c.FootballTeamId.ToString(),
                                            Text = c.Name.ToString()
                                        }).ToList();
            var countries = _context.FootbalPlayers
                                    .Select(c => new SelectListItem
                                    {
                                        Value = c.Nation.ToString(),
                                        Text = c.Nation.ToString()
                                    }).ToList();
            ViewBag.teams = teams;
            ViewBag.countries = countries;

            return View();
        }
        [HttpPost]
        public IActionResult AddPlayer(FootbalPlayer player)
        {
            _context.FootbalPlayers.Add(player);
            _context.SaveChanges();
            return RedirectToAction("FootballPlayersList");
        }

        [HttpGet]
        public IActionResult AddTeam()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTeam(FootballTeam team)
        {
            _context.FootballTeams.Add(team);
            _context.SaveChanges();
            return RedirectToAction("FootballTeamsList");
        }
        public IActionResult SportsCategoriesList()
        {
            return View();
        }
    }
}
