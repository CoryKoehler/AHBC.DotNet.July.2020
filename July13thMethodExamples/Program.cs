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
        //    Add(5, 5);
        //    var accessorService = new AccessorService();
        //    var result = accessorService.DoSomething();
        //    accessorService.SomeProperty = "5";
        //}

        //public static void Add(int value, int valueTwo)
        //{
        //    var addition = value + valueTwo;
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
            var result = exercise19.SumUserInputs(int.Parse(inputOne), int.Parse(inputTwo));

            Console.WriteLine($"Here is the sum of numbers: {result}");
        }
        #endregion
    }
}
