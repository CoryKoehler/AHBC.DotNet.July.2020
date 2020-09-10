using System;
namespace September10thTDDExample
{
    public class FizzBuzz
    {
        public string Generate(int input)
        {
            if (input % 5 == 0)
            {
                return "Buzz";
            } 
            else
            {
                return "Fizz";
            }
        }
    }
}
