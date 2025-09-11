using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.ViewComponents
{
    public class MembershipPartial : ViewComponent
    {
        private readonly Context _context;

        public MembershipPartial(Context context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var degerler = _context.Memberships.OrderByDescending(x => x.MembershipId).ToList();
            return View(degerler);

        }
    }
}
