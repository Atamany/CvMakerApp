using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
