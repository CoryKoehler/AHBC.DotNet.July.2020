using System;
using October1stAspNetCalculatorStep1.Models;

namespace October1stAspNetCalculatorStep1.Services
{
    public interface ICalculationService
    {
        CalculatorViewModel Calculate(CalculatorViewModel model);
    }
}
