using CvMakerApp.Entity.Context;
using Microsoft.AspNetCore.Mvc;

namespace CvMakerApp.Controllers
{
    public class DefaultController : Controller
    {
        private readonly Context _context;

        public DefaultController(Context context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var deger = _context.Titles.FirstOrDefault();
            return View(deger);
        }
        [HttpPost]
        public IActionResult Index(Entity.Entities.Title title)
        {
            var deger = _context.Titles.FirstOrDefault();
            if (deger != null)
            {
                deger.Name = title.Name;
                deger.Surname = title.Surname;
                deger.Description = title.Description;
                deger.WebUrl = title.WebUrl;
                deger.Phone = title.Phone;
                deger.Email = title.Email;
                deger.ImageUrl = title.ImageUrl;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Index", "Default");
        }
        [HttpGet]
        public IActionResult Description()
        {
            var deger = _context.Descriptions.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddDescription()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDescription(Entity.Entities.Description description)
        {
            _context.Add(description);
            _context.SaveChanges();
            return RedirectToAction("Description");
        }
        public IActionResult DeleteDescription(int id)
        {
            var deger = _context.Descriptions.Find(id);
            if (deger != null)
            {
                _context.Descriptions.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Description");
        }
        [HttpGet]
        public IActionResult UpdateDescription(int id)
        {
            var deger = _context.Descriptions.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateDescription(Entity.Entities.Description description)
        {
            var deger = _context.Descriptions.Find(description.DescriptionId);
            if (deger != null)
            {
                deger.DescriptionText = description.DescriptionText;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Description", "Default");
        }
        [HttpGet]
        public IActionResult Experience()
        {
            var deger = _context.Experiences.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddExperience()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddExperience(Entity.Entities.Experience experience)
        {
            _context.Add(experience);
            _context.SaveChanges();
            return RedirectToAction("Experience");
        }
        public IActionResult DeleteExperience(int id)
        {
            var deger = _context.Experiences.Find(id);
            if (deger != null)
            {
                _context.Experiences.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Experience");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var deger = _context.Experiences.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateExperience(Entity.Entities.Experience experience)
        {
            var deger = _context.Experiences.Find(experience.ExperienceId);
            if (deger != null)
            {
                deger.Company = experience.Company;
                deger.Position = experience.Position;
                deger.StartDate = experience.StartDate;
                deger.EndDate = experience.EndDate;
                deger.Description = experience.Description;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Experience", "Default");
        }
    }
}
