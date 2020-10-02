using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace October1stAspNetCalculatorStep1.Controllers
{
    public class CalculatorController : Controller
    {
        //this should be index but cory wanted to show how to create custom stuff
        //check out the startup end point section to see how this works        
        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult CalculateResult()
        {
            //do some work of validating the user input
            //do some work of actually calculating

            //display the results of all the above work somehow???
                //display it in the current page?
                //display it in another page?
                    //do we need another model?
                    //do we need another view??
        }
    }
}
