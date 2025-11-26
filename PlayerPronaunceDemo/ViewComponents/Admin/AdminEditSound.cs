using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    public class AdminEditSound : ViewComponent
    {
        public readonly PPContext _context;

        public AdminEditSound(PPContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke(int soundId , string playerName, int playerId)
        {
            var counteries = _context.Sounds
                                        .Select(c => new SelectListItem
                                        {
                                            Value = c.SoundNation.ToString(),
                                            Text = c.SoundNation.ToString()
                                        }).ToList();
            ViewBag.playerId = playerId;
            ViewBag.playerName = playerName;
            ViewBag.soundNation = counteries;
            return View();
        }
    }
}
