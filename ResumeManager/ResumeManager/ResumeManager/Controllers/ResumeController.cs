using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ResumeManager.Data;
using ResumeManager.Models;

namespace ResumeManager.Controllers
{
    public class ResumeController : Controller
    {
        private readonly ResumeDbContext _context;

        private readonly IWebHostEnvironment _webHost;




        public ResumeController(ResumeDbContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;

        }
        public IActionResult Index()
        {
            List<Applicant> applicants;
            applicants = _context.Applicants.ToList();
            return View(applicants);
        }

        [HttpGet]
        public IActionResult Create()
        {
            Applicant applicant = new Applicant();
            applicant.Experiences.Add(new Experience() { ExperienceId = 1 });
            //applicant.Experiences.Add(new Experience() { ExperienceId = 2 });
            //applicant.Experiences.Add(new Experience() { ExperienceId = 3 });
            return View(applicant);
        }


        [HttpPost]
        public IActionResult Create(Applicant applicant)
        {
            applicant.Experiences.RemoveAll(e => e.YearsWorked == 0);
            string uniqueFileName = GetUploadedFileName(applicant);
            applicant.PhotoUrl = uniqueFileName;

            _context.Add(applicant);
            _context.SaveChanges();
            return RedirectToAction("index");

        }


        private string GetUploadedFileName(Applicant applicant)
        {
            string uniqueFileName = null;

            if (applicant.ProfilePhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + applicant.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    applicant.ProfilePhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult Details(int Id)
        {
            Applicant applicant = _context.Applicants
                .Include(e => e.Experiences)
                .Where(a => a.Id == Id).FirstOrDefault();
            return View(applicant);
        }
        [HttpGet]
        public IActionResult Delete(int Id)
        {
            Applicant applicant = _context.Applicants
                .Include(e => e.Experiences)
                .Where(a => a.Id == Id).FirstOrDefault();
            return View(applicant);
        }
        [HttpPost]
        public IActionResult Delete(Applicant applicant)
        {
            _context.Attach(applicant);
            _context.Entry(applicant).State = EntityState.Deleted;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int Id)
        {
            Applicant applicant = _context.Applicants
                .Include(e => e.Experiences)
                .Where(a => a.Id == Id).FirstOrDefault();
            return View(applicant);
        }
        [HttpPost]
        public IActionResult Update(int id, Applicant updatedApplicant)
        {
            {
                var existingApplicant = _context.Applicants
                    .Include(a => a.Experiences)
                    .FirstOrDefault(a => a.Id == id);

                if (existingApplicant != null)
                {
                    existingApplicant.Name = updatedApplicant.Name;
                    existingApplicant.Gender = updatedApplicant.Gender;
                    existingApplicant.Age = updatedApplicant.Age;
                    existingApplicant.Qualification = updatedApplicant.Qualification;
                    existingApplicant.TotalExperience = updatedApplicant.TotalExperience;

                    // Handle photo update
                    if (updatedApplicant.ProfilePhoto != null)
                    {
                        string uniqueFileName = GetUploadedFileName(updatedApplicant);
                        existingApplicant.PhotoUrl = uniqueFileName;
                    }

                    // Update experiences
                    existingApplicant.Experiences.Clear();
                    existingApplicant.Experiences.AddRange(updatedApplicant.Experiences);

                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}
