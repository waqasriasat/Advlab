

using AdvLab_WebApp.Models;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.Blazor;
using System.Net.Http.Headers;

namespace AdvLab_WebApp.Controllers
{
    public class ReceptionController : Controller
    {
        private readonly SampleEfContext _context;
        private readonly IWebHostEnvironment _webHost;
        public ReceptionController(SampleEfContext context, IWebHostEnvironment webHost)
        {
            _context = context;
            _webHost = webHost;
        }
        public async Task<IActionResult> Index()
        {
            List<PatReg> patRegs;
            patRegs = await _context.PatRegs.ToListAsync();
            return View(patRegs);
        }
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.InitialList = await GetInitialList();
            ViewBag.RelationList = await GetRelationList();
            ViewBag.AgeTypeList = await GetAgeTypeList();
            ViewBag.GenderList = await GetGenderList();
            PatReg PatRegs = new PatReg();
            DescCashier DescCashiers = new DescCashier();
            DescCashiers.DescLabs.Add(new DescLab() { LabNo = 1 });
            var model = new CreateViewModel
            {
                PatReg = PatRegs,
                DescCashier = DescCashiers
            };
            return View(model);


        }
        [HttpPost]

        public async Task<IActionResult> Create(CreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.DescCashier.DescLabs.RemoveAll(e => e.Charges == 0);
                string uniqueFileName = GetUploadedFileName(model.PatReg);
                model.PatReg.PhotoUrl = uniqueFileName;
                _context.PatRegs.Add(model.PatReg);
                await _context.SaveChangesAsync();
                model.DescCashier.MRNO = model.PatReg.MRNO;
                _context.DescCashiers.Add(model.DescCashier);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        private string GetUploadedFileName(PatReg patRegs)
        {
            string uniqueFileName = null;

            if (patRegs.ProfilePhoto != null)
            {
                string uploadsFolder = Path.Combine(_webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + patRegs.ProfilePhoto.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    patRegs.ProfilePhoto.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        [HttpPost]
        private async Task<List<SelectListItem>> GetInitialList()
        {
            var apiUrl = "https://localhost:7121/API/Receptions/GetInitialList";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string token = HttpContext.Session.GetString("AccessToken");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var Initials = await response.Content.ReadFromJsonAsync<List<PatReg_Shortkey>>();
                        if (Initials != null)
                        {
             
                            var selectList = Initials
                                .Select(l => new SelectListItem { Value = l.Initial, Text = l.Initial })
                                .ToList();

                            selectList.Insert(0, new SelectListItem { Value = "Please Select", Text = "Please Select" });

                            return selectList;
                        }
                    }
                    else
                    {
                        // Handle non-success response
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                }

                return new List<SelectListItem>();
            }
        }
        [HttpPost]
        private async Task<List<SelectListItem>> GetRelationList()
        {
            var apiUrl = "https://localhost:7121/API/Receptions/GetRelationList";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string token = HttpContext.Session.GetString("AccessToken");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var Relations = await response.Content.ReadFromJsonAsync<List<PatReg_Shortkey>>();
                        if (Relations != null)
                        {

                            var selectList = Relations
                                .Select(l => new SelectListItem { Value = l.Relation, Text = l.Relation })
                                .ToList();

                            selectList.Insert(0, new SelectListItem { Value = "Please Select", Text = "Please Select" });

                            return selectList;
                        }
                    }
                    else
                    {
                        // Handle non-success response
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                }

                return new List<SelectListItem>();
            }
        }
        [HttpPost]
        private async Task<List<SelectListItem>> GetAgeTypeList()
        {
            var apiUrl = "https://localhost:7121/API/Receptions/GetAgeTypeList";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string token = HttpContext.Session.GetString("AccessToken");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var AgeTypes = await response.Content.ReadFromJsonAsync<List<PatReg_Shortkey>>();
                        if (AgeTypes != null)
                        {

                            var selectList = AgeTypes
                                .Select(l => new SelectListItem { Value = l.Years, Text = l.Years })
                                .ToList();

                            selectList.Insert(0, new SelectListItem { Value = "Please Select", Text = "Please Select" });

                            return selectList;
                        }
                    }
                    else
                    {
                        // Handle non-success response
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                }

                return new List<SelectListItem>();
            }
        }
        [HttpPost]
        private async Task<List<SelectListItem>> GetGenderList()
        {
            var apiUrl = "https://localhost:7121/API/Receptions/GetGenderList";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string token = HttpContext.Session.GetString("AccessToken");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var Genders = await response.Content.ReadFromJsonAsync<List<PatReg_Shortkey>>();
                        if (Genders != null)
                        {

                            var selectList = Genders
                                .Select(l => new SelectListItem { Value = l.Gender, Text = l.Gender })
                                .ToList();

                            selectList.Insert(0, new SelectListItem { Value = "Please Select", Text = "Please Select" });

                            return selectList;
                        }
                    }
                    else
                    {
                        // Handle non-success response
                    }
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                }

                return new List<SelectListItem>();
            }
        }
        [HttpPost]
        public async Task<IActionResult> GetDefaultNameKeys(string InitialValue)
        {
            var apiUrl = "https://localhost:7121/API/Receptions/GetDefaultNameKeys?InitialValue=" + InitialValue;

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string token = HttpContext.Session.GetString("AccessToken");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var InitialValues = await response.Content.ReadFromJsonAsync<List<PatReg_Shortkey>>();
                        if (InitialValues != null && InitialValues.Any())
                        {
                            var firstInitialValues = InitialValues.First();
                            return Json(new { 
                                Initial = firstInitialValues.Initial,
                                Relation = firstInitialValues.Relation,
                                AgeType = firstInitialValues.Years,
                                Gender = firstInitialValues.Gender
                            });
                        }
                    }
                    else
                    {
                    }
                }
                catch (Exception ex)
                {
                }

                return Json(new {
                    Initial = string.Empty,
                    Relation = string.Empty,
                    AgeType = string.Empty,
                    Gender = string.Empty });
            }
        }
    
    }
}
