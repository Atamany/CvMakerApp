using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class StackPartial : ViewComponent
    {
        private readonly Context _context;

        public StackPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Stacks.ToList();
            return View(degerler);

        }
    }
}
