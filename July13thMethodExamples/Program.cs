using July13thExamples;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace July13thMethodExamples
{
    public class Program
    {
        #region First Example - remove comments to run!
        //private static void Main(string[] args)
        //{
        //   int darionsNumber = DarionsCoolMethod(5, 5);
        //    var accessorService = new AccessorService();
        //    var result = accessorService.DoSomething();
        //    accessorService.SomeProperty = "5";
        //}

        //public static int DarionsCoolMethod(int value, int valueTwo)
        //{
        //    var addition = value + valueTwo;
        //    return addition;
        //}
        #endregion

        #region Second Example - comment this out to run the first example!
        private static void Main(string[] args)
        {
            Console.WriteLine("Please input a number");
            var inputOne = Console.ReadLine();
            Console.WriteLine("Please input another number");
            var inputTwo = Console.ReadLine();

            var exercise19 = new Exercise19();

            var result = exercise19.SumUserInputs(inputOne, inputTwo);

            Console.WriteLine("Please input a number");
            var inputThree = Console.ReadLine();
            Console.WriteLine("Please input another number");
            var inputFour = Console.ReadLine();

            var resultTwo = exercise19.SumUserInputs(inputThree, inputFour);


            Console.WriteLine($"Here is the sum of numbers: {result}");
        }
        #endregion

        #region Third Example - ensure all others are commented out to run!
        //public static void Main(string[] args)
        //{
        //    string input = "This is Cool";
        //    string example = DarionsStringMethod(input);
        //    Console.WriteLine(example);
        //}

        //private static string DarionsStringMethod(string darionInput)
        //{
        //    string newVariable = $"Method {darionInput}";

        //    return newVariable;
        //}
        #endregion
    }
}