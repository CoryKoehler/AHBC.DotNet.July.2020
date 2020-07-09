using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace July8thExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            var userInput = Console.ReadLine();
            Console.WriteLine("enter another number");
            var secondUserInput = Console.ReadLine();

            var isDecimal = decimal.TryParse(userInput, out decimal userInputAsDecimal);
            var isSecondInputDecimal = decimal.TryParse(secondUserInput, out decimal secondUserInputAsDecimal);
            
            if (!isDecimal || !isSecondInputDecimal)
            {
                Console.WriteLine("Error - incorrect input - Try again");
                return;
            }

            var sum = userInputAsDecimal + secondUserInputAsDecimal;
            Console.WriteLine($"{userInputAsDecimal} + {secondUserInputAsDecimal}");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
