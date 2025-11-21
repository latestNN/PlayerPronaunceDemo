using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminAddSound : ViewComponent
    {
        public readonly PPContext _context;

        public AdminAddSound(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int playerId, string playerName)
        {
            var countries = _context.Sounds
                                        .Select(c => new SelectListItem
                                        {
                                            Value = c.SoundNation.ToString(),
                                            Text = c.SoundNation.ToString()
                                        }).ToList();
            ViewBag.counteries = countries;
            ViewBag.playerId = playerId;
            ViewBag.playerName = playerName;
            return View();
        }
    }
}
