using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Novemeber5thWebApp.Models;

namespace Novemeber5thWebApp.Controllers
{
    public class PartsController : Controller
    {
        // GET: PartsController
        private readonly HttpClient _httpClient;
        public PartsController()
        {
            var httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:5001/api/")
            };

            _httpClient = httpClient;
        }

        public ActionResult Index()
        {
            //use the http client to make a request to the api via the parts uri
            var response = _httpClient.GetAsync("Parts").GetAwaiter().GetResult();
            //grab the json from the response content
            var partsViewModelsJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            //turn case sensitivity off
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            //deserialzie the serialized json into our view model so that we can display it in the view
            var partsViewModels = JsonSerializer.Deserialize<IEnumerable<PartViewModel>>(partsViewModelsJson, options);

            //send the view models to the views
            return View(partsViewModels);
        }

        // GET: PartsController/Details/5
        public ActionResult Details(int id)
        {
            //use the http client to make a request to the api via the parts uri
            var response = _httpClient.GetAsync($"Parts/{id}").GetAwaiter().GetResult();

            //grab the json from the response content
            var partsViewModelsJson = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();

            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
            };
            //deserialzie the serialized json into our view model so that we can display it in the view
            var partsViewModel = JsonSerializer.Deserialize<PartViewModel>(partsViewModelsJson, options);

            //send the view models to the views
            return View(partsViewModel);
        }

        // GET: PartsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PartsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PartsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PartsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PartsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
