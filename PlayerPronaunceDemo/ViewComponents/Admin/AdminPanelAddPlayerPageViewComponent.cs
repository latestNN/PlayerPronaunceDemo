using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlayerPronaunceDemo.Context;
using PlayerPronaunceDemo.Entities;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminPanelAddPlayerPageViewComponent : ViewComponent
    {
        private readonly PPContext _context;

        public AdminPanelAddPlayerPageViewComponent(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
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
    }
}
