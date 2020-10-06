using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using October1stAspNetCalculatorStep1.Models;

namespace October1stAspNetCalculatorStep1.Models
{
    public class CalculatorViewModel
    {
        public decimal InputOne { get; set; } //'$12.12'
        public decimal InputTwo { get; set; }
        public CalculatorType Action { get; set; }
        public string Result { get; set; }
    }
}
