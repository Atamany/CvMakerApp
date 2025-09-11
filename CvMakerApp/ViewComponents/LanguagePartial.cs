using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class LanguagePartial : ViewComponent
    {
        private readonly Context _context;

        public LanguagePartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Languages.ToList();
            return View(degerler);
        }
    }
}
