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

        public IViewComponentResult Invoke()
        {
            var values = _context.Sounds.ToList();
            return View(values);
        }
    }
}
