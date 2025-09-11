using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class VoluntaryPartial : ViewComponent
    {
        private readonly Context _context;

        public VoluntaryPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Voluntaries.OrderByDescending(x => x.VoluntaryId).ToList();
            return View(degerler);

        }
    }
}
