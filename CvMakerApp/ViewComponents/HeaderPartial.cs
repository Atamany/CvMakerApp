using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class HeaderPartial : ViewComponent
    {
        private readonly Context _context;

        public HeaderPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var deger = _context.Titles.FirstOrDefault();
            return View(deger);

        }
    }
}