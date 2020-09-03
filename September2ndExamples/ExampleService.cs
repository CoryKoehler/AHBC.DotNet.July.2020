using System;
using System.Collections.Generic;
using System.Text;

namespace September2ndExamples
{
    public class ExampleService //: IExampleService
    {
        public (bool Success, int idkSomething, Exception exception) RetreiveIdkSomething()
        {
            (bool success, int idkSomething, Exception exception) returnValue = (true, 1, null);

            try
            {
                //do some logic
                return (true, 1, null);
            }
            catch (Exception ex)
            {
                returnValue.success = false;
                returnValue.exception = ex;

            }

            return returnValue;
        }
    }
}
