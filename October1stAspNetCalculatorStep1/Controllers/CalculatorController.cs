using Microsoft.AspNetCore.Mvc;
using October1stAspNetCalculatorStep1.Models;
using October1stAspNetCalculatorStep1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace October1stAspNetCalculatorStep1.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalculationService _calculationService;

        public CalculatorController(ICalculationService calculationService)
        {
            _calculationService = calculationService;
        }
                
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateResult(CalculatorViewModel model)
        {

            var calculatorViewModel = _calculationService.Calculate(model);
            
            var viewResultModel = new ResultViewModel
            {
                Result = calculatorViewModel.Result
            };

            //do some work of validating the user input
            //do some work of actually calculating

            //display the results of all the above work somehow???
            //display it in the current page?
            //display it in another page?
            //do we need another model?
            //do we need another view??
            return View(viewResultModel);
        }
    }
}
