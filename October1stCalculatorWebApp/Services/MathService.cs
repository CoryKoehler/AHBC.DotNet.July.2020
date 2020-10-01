using October1stCalculatorWebApp.Models;

namespace October1stCalculatorWebApp.Services
{
    public interface IMathService
    {
        CalculateResult Calculate(CalculateRequest request);
        CalculateRequest GetLastRequest();
    }

    public class MathService : IMathService
    {
        private CalculateRequest _lastRequest;

        public CalculateResult Calculate(CalculateRequest request)
        {
            _lastRequest = request;

            switch (request.Type)
            {
                case CalculateType.Add:
                    return new CalculateResult { Result = request.FirstNumber + request.SecondNumber };
                case CalculateType.Subtract:
                    return new CalculateResult { Result = request.FirstNumber - request.SecondNumber };
                case CalculateType.Multiply:
                    return new CalculateResult { Result = request.FirstNumber * request.SecondNumber };
                case CalculateType.Divide:
                    return new CalculateResult { Result = request.FirstNumber / request.SecondNumber };
                default:
                    return null;
            }
        }

        public CalculateRequest GetLastRequest()
        {
            return _lastRequest;
        }
    }
}
