using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Assessment5Review.Models;

namespace Assessment5Review.Controllers
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
            return View("GetAge");
        }

        public IActionResult Result(string userName, int age)
        {
            if (age >= 18)
            {
                ViewData["CanVote"] = $"{ userName} can vote";
            }
            if (age >= 21)
            {
                ViewData["CanDrink"] = $"{userName} can Drink";
            }
            if (age < 18)
            {
                ViewData["TooYoung"] = $"{userName} is still in high school.";
            }
            if (age >= 25)
            {
                ViewData["CanRent"] = $"{userName} can drive.";
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
