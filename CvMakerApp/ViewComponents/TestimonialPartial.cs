using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class TestimonialPartial : ViewComponent
    {
        private readonly Context _context;

        public TestimonialPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Testimonials.ToList();
            return View(degerler);

        }
    }
}
