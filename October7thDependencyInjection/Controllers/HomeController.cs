using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using October7thDependencyInjection.Models;
using October7thDependencyInjection.Services;

namespace October7thDependencyInjection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly IHttpContextAccessor _httpContextAccessor;


        public HomeController(IHttpContextAccessor httpContextAccessor, ISingletonService singletonService, IScopedService scopedService, ITransientService transientService)
        {
            _httpContextAccessor = httpContextAccessor;
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
        }

        //singleton
        public IActionResult Index()
        {
            return View("Index", _singletonService.GetGuid());
        }
        public IActionResult Scoped()
        {
            return View("Scoped", _scopedService.GetGuid());
        }
        public IActionResult Transient()
        {
            return View("Transient", _transientService.GetGuid());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
