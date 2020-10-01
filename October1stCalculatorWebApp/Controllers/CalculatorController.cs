using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using October1stCalculatorWebApp.Models;
using October1stCalculatorWebApp.Services;
using System;

namespace October1stCalculatorWebApp.Controllers
{

    /// <summary>
    /// SOLID - Single Responsiblity Principle (SRP) - CalculatorControl is only responsible for being a control.
    /// It facilitates web requests and providing a model to the view.
    /// </summary>
    public class CalculatorController : Controller
    {
        private readonly IMathService _mathService;
        private readonly IHttpContextAccessor _httpContext;

        public CalculatorController(IMathService mathService, IHttpContextAccessor httpContext)
        {
            _mathService = mathService;
            _httpContext = httpContext;   
        }

        public IActionResult Index(CalculateRequest request)
        {
            // We could also access this data in the controller
            //_httpContext.HttpContext.Session.GetString("lastRequest");
            //_httpContext.HttpContext.Request.Cookies.FirstOrDefault(x => x.Key == "lastRequest").Value;

            return View(request);
        }

        [HttpPost]
        public IActionResult Calculate(CalculateRequest request)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            // Loosely Typed  View Data
            ViewData["StartTime"] = DateTime.Now;

            // Strongly Typed Model
            var model = _mathService.Calculate(request);

            // Loosely Typed View Bag
            ViewBag.EndTime = DateTime.Now;

            // Loosely Typed Temp Data (Read Once)
            var lastRequest = $"The last request was to {request.Type} {request.FirstNumber} and {request.SecondNumber}";
            TempData["LastRequest"] = lastRequest;

            // Setting in the session to be reused
            _httpContext.HttpContext.Session.SetString("lastRequest", lastRequest);

            // Setting in the cookie (always in the response)
            _httpContext.HttpContext.Response.Cookies.Append("lastRequest", lastRequest);

            return View(model);
        }

    }
}
