using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AspNetCoreMvc.Models;

namespace AspNetCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPrivacy()
        {
            return View("Privacy");
        }

        public ActionResult Admin()
        {
            Console.WriteLine("Admin started...");
            return View();
        }
    
        [HttpPost]
        public ActionResult Admin(PersonModel person)
        {
            Console.WriteLine("Saving...");
            int personId = person.PersonId;
            string name = person.Name;
            string gender = person.Gender;
            string city = person.City;
    
            return View("Admin");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
