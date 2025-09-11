using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class EducationPartial : ViewComponent
    {
        private readonly Context _context;

        public EducationPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Educations.OrderByDescending(x => x.EducationId).ToList();
            return View(degerler);

        }
    }
}
