using AdvLab_WebApp.Models;
using AdvLab_WebApp.Models.Reception;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Net.Http.Headers;

namespace AdvLab_WebApp.Controllers
{
    public class ReceptionController : Controller
    {
        private readonly SampleEfContext _context;
        public ReceptionController(SampleEfContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var apiUrl = "https://localhost:7121/API/Receptions/All";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    string token = HttpContext.Session.GetString("AccessToken");
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        //var responseData = await response.Content.ReadAsStringAsync();
                        //var receptionViewModels = JsonConvert.DeserializeObject<List<ReceptionViewModel>>(responseData);
                        //return View(receptionViewModels);

                        var responseData = await response.Content.ReadAsStringAsync();
                        var receptionViewModel = JsonConvert.DeserializeObject<ReceptionViewModel>(responseData);
                        return View(receptionViewModel);
                    }
                    else
                    {
                        var errorMessage = await response.Content.ReadAsStringAsync();
                        ViewBag.ErrorMessage = errorMessage;
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = $"An error occurred: {ex.Message}";
                }
            }
            return View();
        }
    }
}
