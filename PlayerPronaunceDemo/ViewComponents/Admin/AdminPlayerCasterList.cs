using Microsoft.AspNetCore.Mvc;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminPlayerCasterList : ViewComponent
    {
        private readonly PPContext _context;

        public AdminPlayerCasterList(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int playerId)
        {
            var values = _context.Sounds.Where(x => x.FootballPlayerId == playerId).ToList();
            return View(values);
        }
    }
}
