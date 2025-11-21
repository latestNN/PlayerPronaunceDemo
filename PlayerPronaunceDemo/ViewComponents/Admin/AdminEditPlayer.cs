using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminEditPlayer : ViewComponent
    {
        private readonly PPContext _context;

        public AdminEditPlayer(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var countries = _context.FootbalPlayers
                                    .Select(c => new SelectListItem
                                    {
                                        Value = c.Nation.ToString(),
                                        Text = c.Nation.ToString()
                                    }).ToList();
            
            var teams = _context.FootbalPlayers
                                    .Select(c => new SelectListItem
                                    {
                                        Value = c.FootballTeamId.ToString(),
                                        Text = c.footballTeam.Name.ToString()
                                    }).ToList();
            ViewBag.countries = countries;
            ViewBag.teams = teams;
            return View();
        }
    }
}
