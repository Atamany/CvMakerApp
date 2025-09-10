using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
