using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult Header()
        {
            return PartialView();
        }
        public PartialViewResult Navbar()
        {
            return PartialView();
        }
        public PartialViewResult Sidebar()
        {
            return PartialView();
        }
        public PartialViewResult Script()
        {
            return PartialView();
        }
    }
}
