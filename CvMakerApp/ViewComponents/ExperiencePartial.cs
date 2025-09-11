using CvMakerApp.Entity.Context;
using CvMakerApp.Entity.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class ExperiencePartial : ViewComponent
    {
        private readonly Context _context;

        public ExperiencePartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Experiences.OrderByDescending(x=>x.ExperienceId).ToList();
            return View(degerler);

        }
    }
}
