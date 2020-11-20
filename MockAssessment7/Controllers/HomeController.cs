using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockAssessment7.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace MockAssessment7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HttpClient _httpclient;
        private JsonSerializerOptions _options;

        public HomeController(ILogger<HomeController> logger)
        {
            // https://grandcircusco.github.io/demo-apis/donuts.json
            // https://grandcircusco.github.io/demo-apis/donuts/3.json
            _logger = logger;

            _httpclient = new HttpClient()
            {
                BaseAddress = new Uri("https://grandcircusco.github.io/demo-apis/")
            };

            _options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            };
        }

        public IActionResult Index()
        {
            //var response = _httpclient.GetAsync("/donuts.json").GetAwaiter().GetResult();
            //var jsonResponseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            //var donuts = JsonSerializer.Deserialize<List<Donut>>(jsonResponseString, _options);
            //return View(donuts);

            return View();
        }

        public IActionResult Search(int id)
        {
            var response = _httpclient.GetAsync($"donuts/{id}.json").GetAwaiter().GetResult();
            var jsonResponseString = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            if(response.StatusCode != System.Net.HttpStatusCode.OK)
            {
                //return some other view if the id doesnt return something good
                return View();
            }
            var donut = JsonSerializer.Deserialize<Donut>(jsonResponseString, _options);
            //var jsonDocument = JsonDocument.Parse(jsonResponseString).RootElement.GetProperty("photo").GetString();
            //var jsonDocument = JsonDocument.Parse(jsonResponseString).RootElement.GetProperty("photo").GetRawText();
            //var photoUrl = JsonSerializer.Deserialize<string>(jsonDocument);

            return View(donut);
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
