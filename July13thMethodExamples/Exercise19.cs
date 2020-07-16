using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace July13thMethodExamples
{
    public class Exercise19
    { 
        public int SumUserInputs(string valueOne, string valueTwo)
        {
            var valueOneAsInt = int.Parse(valueOne);
            var valueTwoAsInt = int.Parse(valueTwo);
            var someVariable = NoParameterMethod();
            Console.WriteLine(someVariable);
            return valueOneAsInt + valueTwoAsInt;
        }

        private int NoParameterMethod()
        {
            int numberOne = 1;
            int numberTwo = 2;

            var sumOfTwoNumbers = numberOne + numberTwo;
           
            return sumOfTwoNumbers;
        }
    }
}
