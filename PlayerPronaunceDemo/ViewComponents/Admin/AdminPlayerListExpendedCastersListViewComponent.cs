using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerPronaunceDemo.Context;

namespace PlayerPronaunceDemo.ViewComponents.Admin
{
    
    public class AdminPlayerListExpendedCastersList : ViewComponent
    {
        private readonly PPContext _context;

        public AdminPlayerListExpendedCastersList(PPContext context)
        {
            _context = context;
        }

        public  IViewComponentResult Invoke()
        {
            var values =  _context.Sounds.ToList();
            return View(values);
        }
    }
}
