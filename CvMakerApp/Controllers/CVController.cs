using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class CVController : Controller
    {
        private readonly Context _context;
        public CVController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult StylePartial()
        {
            return PartialView();
        }
    }
}
