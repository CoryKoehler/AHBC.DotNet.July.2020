using System;
using October1stAspNetCalculatorStep1.Models;

namespace October1stAspNetCalculatorStep1.Services
{
    public class CalculationService : ICalculationService
    {
        public CalculatorViewModel Calculate(CalculatorViewModel model)
        {
            switch (model.Action)
            {
                case CalculatorType.Add:
                    model.Result = (model.InputOne + model.InputTwo).ToString();
                    break;
                case CalculatorType.Subtract:
                    model.Result = (model.InputOne - model.InputTwo).ToString();
                    break;
                case CalculatorType.Multiply:
                    model.Result = (model.InputOne * model.InputTwo).ToString();
                    break;
                case CalculatorType.Divide:
                    model.Result = (model.InputOne / model.InputTwo).ToString();
                    break;
            }
            return model;
        }
    }
}
