using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminPanelAddTeamPage : ViewComponent
    {
        private readonly PPContext _context;

        public AdminPanelAddTeamPage(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var origins = _context.FootballTeams
                                        .Select(c => new SelectListItem
                                        {
                                            Value = c.Origin,
                                            Text = c.Origin
                                        }).ToList();
            ViewBag.origin = origins;
            return View();
        }
    }
}
