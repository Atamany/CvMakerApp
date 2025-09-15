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
        [HttpGet]
        public IActionResult Education()
        {
            var deger = _context.Educations.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddEducation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEducation(Entity.Entities.Education education)
        {
            _context.Add(education);
            _context.SaveChanges();
            return RedirectToAction("Education");
        }
        public IActionResult DeleteEducation(int id)
        {
            var deger = _context.Educations.Find(id);
            if (deger != null)
            {
                _context.Educations.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Education");
        }
        [HttpGet]
        public IActionResult UpdateEducation(int id)
        {
            var deger = _context.Educations.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateEducation(Entity.Entities.Education education)
        {
            var deger = _context.Educations.Find(education.EducationId);
            if (deger != null)
            {
                deger.SchoolName = education.SchoolName;
                deger.Department = education.Department;
                deger.EducationalType = education.EducationalType;
                deger.StartDate = education.StartDate;
                deger.EndDate = education.EndDate;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Education", "Default");
        }
        [HttpGet]
        public IActionResult Membership()
        {
            var deger = _context.Memberships.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddMembership()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddMembership(Entity.Entities.Membership membership)
        {
            _context.Add(membership);
            _context.SaveChanges();
            return RedirectToAction("Membership");
        }
        public IActionResult DeleteMembership(int id)
        {
            var deger = _context.Memberships.Find(id);
            if (deger != null)
            {
                _context.Memberships.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Membership");
        }
        [HttpGet]
        public IActionResult UpdateMembership(int id)
        {
            var deger = _context.Memberships.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateMembership(Entity.Entities.Membership membership)
        {
            var deger = _context.Memberships.Find(membership.MembershipId);
            if (deger != null)
            {
                deger.Organisation = membership.Organisation;
                deger.Position = membership.Position;
                deger.StartDate = membership.StartDate;
                deger.EndDate = membership.EndDate;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Membership", "Default");
        }
        [HttpGet]
        public IActionResult Language()
        {
            var deger = _context.Languages.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddLanguage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddLanguage(Entity.Entities.Language language)
        {
            _context.Add(language);
            _context.SaveChanges();
            return RedirectToAction("Language");
        }
        public IActionResult DeleteLanguage(int id)
        {
            var deger = _context.Languages.Find(id);
            if (deger != null)
            {
                _context.Languages.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Language");
        }
        [HttpGet]
        public IActionResult UpdateLanguage(int id)
        {
            var deger = _context.Languages.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateLanguage(Entity.Entities.Language language)
        {
            var deger = _context.Languages.Find(language.LanguageID);
            if (deger != null)
            {
                deger.LanguageName = language.LanguageName;
                deger.LanguageLevel = language.LanguageLevel;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Language", "Default");
        }
        [HttpGet]
        public IActionResult Stack()
        {
            var deger = _context.Stacks.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddStack()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStack(Entity.Entities.Stack stack)
        {
            _context.Add(stack);
            _context.SaveChanges();
            return RedirectToAction("Stack");
        }
        public IActionResult DeleteStack(int id)
        {
            var deger = _context.Stacks.Find(id);
            if (deger != null)
            {
                _context.Stacks.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Stack");
        }
        [HttpGet]
        public IActionResult UpdateStack(int id)
        {
            var deger = _context.Stacks.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateStack(Entity.Entities.Stack stack)
        {
            var deger = _context.Stacks.Find(stack.StackId);
            if (deger != null)
            {
                deger.Description = stack.Description;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Stack", "Default");
        }
        [HttpGet]
        public IActionResult Voluntary()
        {
            var deger = _context.Voluntaries.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddVoluntary()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddVoluntary(Entity.Entities.Voluntary voluntary)
        {
            _context.Add(voluntary);
            _context.SaveChanges();
            return RedirectToAction("Voluntary");
        }
        public IActionResult DeleteVoluntary(int id)
        {
            var deger = _context.Voluntaries.Find(id);
            if (deger != null)
            {
                _context.Voluntaries.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Voluntary");
        }
        [HttpGet]
        public IActionResult UpdateVoluntary(int id)
        {
            var deger = _context.Voluntaries.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateVoluntary(Entity.Entities.Voluntary voluntary)
        {
            var deger = _context.Voluntaries.Find(voluntary.VoluntaryId);
            if (deger != null)
            {
                deger.CompanyName = voluntary.CompanyName;
                deger.Position = voluntary.Position;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Voluntary", "Default");
        }
        [HttpGet]
        public IActionResult Testimonial()
        {
            var deger = _context.Testimonials.ToList();
            return View(deger);
        }
        [HttpGet]
        public IActionResult AddTestimonial()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddTestimonial(Entity.Entities.Testimonial testimonial)
        {
            _context.Add(testimonial);
            _context.SaveChanges();
            return RedirectToAction("Testimonial");
        }
        public IActionResult DeleteTestimonial(int id)
        {
            var deger = _context.Testimonials.Find(id);
            if (deger != null)
            {
                _context.Testimonials.Remove(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Testimonial");
        }
        [HttpGet]
        public IActionResult UpdateTestimonial(int id)
        {
            var deger = _context.Testimonials.Find(id);
            return View(deger);
        }
        [HttpPost]
        public IActionResult UpdateTestimonial(Entity.Entities.Testimonial testimonial)
        {
            var deger = _context.Testimonials.Find(testimonial.TestimonialId);
            if (deger != null)
            {
                deger.TestimonialName = testimonial.TestimonialName;
                deger.Position = testimonial.Position;
                deger.Company = testimonial.Company;
                _context.Update(deger);
                _context.SaveChanges();
            }
            return RedirectToAction("Testimonial", "Default");
        }
    }
}
