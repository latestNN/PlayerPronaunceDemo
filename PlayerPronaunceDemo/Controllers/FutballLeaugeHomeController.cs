using Microsoft.AspNetCore.Mvc;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.Controllers
{
    public class FutballLeaugeHomeController : Controller
    {
        private readonly PPContext _context;

        public FutballLeaugeHomeController(PPContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.FootballTeams.ToList();
            return View(values);
        }
    }
}
