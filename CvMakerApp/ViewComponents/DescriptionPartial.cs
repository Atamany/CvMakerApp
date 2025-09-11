using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class DescriptionPartial : ViewComponent
    {
        private readonly Context _context;

        public DescriptionPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Descriptions.ToList();
            return View(degerler);

        }
    }
}
